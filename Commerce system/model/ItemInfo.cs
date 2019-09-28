using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce_system
{
    public class ItemInfo
    {
        public const string TYPE_PROCESSOR = "cpu";
        public const string TYPE_BOARD = "mb";
        public const string TYPE_MEMORY = "mem";
        public const string TYPE_DRIVE = "hdd";
        public const string TYPE_CARD = "gpu";
        public const string TYPE_SET = "set";

        public const int TYPE_BOARD_INDEX = 0;
        public const int TYPE_PROCESSOR_INDEX = 1;
        public const int TYPE_MEMORY_INDEX = 2;
        public const int TYPE_DRIVE_INDEX = 3;
        public const int TYPE_CARD_INDEX = 4;
        public const int TYPE_SET_INDEX = 5;

        private const string NAME_KEY = "name";
        private const string TYPE_KEY = "type";
        private const string IMAGE_KEY = "imgref";
        private const string DESCRIPTION_KEY = "desc";
        private const string PRICE_KEY = "price";

        private readonly List<string> _typeList = new List<string>() { TYPE_BOARD, TYPE_PROCESSOR, TYPE_MEMORY, TYPE_DRIVE, TYPE_CARD, TYPE_SET };
        private readonly List<string> _typeNameList = new List<string>() { "主機板", "CPU", "記憶體", "硬碟", "顯示卡", "套裝電腦" };

        private List<string> _processorItemIdList = new List<string>();
        private List<string> _boardItemIdList = new List<string>();
        private List<string> _memoryItemIdList = new List<string>();
        private List<string> _driveItemIdList = new List<string>();
        private List<string> _cardItemIdList = new List<string>();
        private List<string> _setItemIdList = new List<string>();

        private InitialFiles _initial;

        //deafult constructor
        public ItemInfo(InitialFiles initial)
        {
            this._initial = initial;
            this.InitialAllItemIdList();
        }

        //get item name
        public string GetItemName(string id)
        {
            return _initial.ReadInitial(id, NAME_KEY);
        }

        //get item type
        public string GetItemType(string id)
        {
            return _initial.ReadInitial(id, TYPE_KEY);
        }

        //get item image reference
        public string GetItemImageReference(string id)
        {
            return _initial.ReadInitial(id, IMAGE_KEY);
        }

        //get item description
        public string GetItemDescription(string id)
        {
            return _initial.ReadInitial(id, DESCRIPTION_KEY);
        }

        //get item price
        public int GetItemPrice(string id)
        {
            return int.Parse(_initial.ReadInitial(id, PRICE_KEY));
        }

        //get item type name by translate type string
        public string GetItemTypeName(string id)
        {
            string type = this.GetItemType(id);
            int typeIndex = _typeList.FindIndex(x => x == type);
            return this._typeNameList[typeIndex];
        }

        //get all item id list by input bype
        public List<string> GetItemIdListByType(string type)
        {
            List<string>[] typeIdList = { _boardItemIdList, _processorItemIdList, _memoryItemIdList, _driveItemIdList, _cardItemIdList, _setItemIdList };
            int typeIndex = _typeList.FindIndex(x => x == type);
            return typeIdList[typeIndex];
        }

        //get all type
        public List<string> GetTypeList()
        {
            return this._typeList;
        }

        //retrive and classify exist item from ini
        private void InitialAllItemIdList()
        {
            this.ClearAllIdList();
            string[] allSections = _initial.GetSectionNames();
            List<string>[] typeIdList = { _boardItemIdList, _processorItemIdList, _memoryItemIdList, _driveItemIdList, _cardItemIdList, _setItemIdList };
            foreach ( String section in allSections )
            {
                String type = this.GetItemType(section);
                int typeIndex = _typeList.FindIndex(x => x == type);
                typeIdList[typeIndex].Add(section);
            }
        }

        //clear all id list
        private void ClearAllIdList()
        {
            _processorItemIdList.Clear();
            _boardItemIdList.Clear();
            _memoryItemIdList.Clear();
            _driveItemIdList.Clear();
            _cardItemIdList.Clear();
            _setItemIdList.Clear();
        }
    }
}
