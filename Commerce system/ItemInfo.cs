using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce_system
{
    class ItemInfo
    {
        public const string TYPE_PROCESSOR = "cpu";
        public const string TYPE_BOARD = "mb";
        public const string TYPE_MEMORY = "mem";
        public const string TYPE_DRIVE = "hdd";
        public const string TYPE_CARD = "gpu";
        public const string TYPE_SET = "set";

        private const string NAME_KEY = "name";
        private const string TYPE_KEY = "type";
        private const string IMAGE_KEY = "imgref";
        private const string DESCRIPTION_KEY = "desc";
        private const string PRICE_KEY = "price";

        private readonly List<string> _typeList = new List<string>() { TYPE_PROCESSOR, TYPE_BOARD, TYPE_MEMORY, TYPE_DRIVE, TYPE_CARD, TYPE_SET };
        private readonly List<string> _typeNameList = new List<string>() { "CPU", "主機板", "記憶體", "硬碟", "顯示卡", "套裝電腦" };

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
        public string GetItemPrice(string id)
        {
            return _initial.ReadInitial(id, PRICE_KEY);
        }

        //get item type name by translate type string
        public string GetItemTypeName(string id)
        {
            string type = this.GetItemType(id);
            int typeIndex = _typeList.FindIndex(x => x == type);
            return this._typeNameList[typeIndex];
        }

        //get all processor item id list
        public List<string> GetProcessorItemIdList()
        {
            return this._processorItemIdList;
        }

        //get all mother board item id list
        public List<string> GetBoardItemIdList()
        {
            return this._boardItemIdList;
        }

        //get all memoryory item id list
        public List<string> GetMemoryItemIdList()
        {
            return this._memoryItemIdList;
        }

        //get all hard drive item id list
        public List<string> GetDriveItemIdList()
        {
            return this._driveItemIdList;
        }

        //get all card item id list
        public List<string> GetCardItemIdList()
        {
            return this._cardItemIdList;
        }

        //get all set item id list
        public List<string> GetSetItemIdList()
        {
            return this._setItemIdList;
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
            foreach ( String section in allSections )
            {
                String type = this.GetItemType(section);
                switch (type)
                {
                    case TYPE_PROCESSOR:
                        _processorItemIdList.Add(section);
                        break;
                    case TYPE_BOARD:
                        _boardItemIdList.Add(section);
                        break;
                    case TYPE_MEMORY:
                        _memoryItemIdList.Add(section);
                        break;
                    case TYPE_DRIVE:
                        _driveItemIdList.Add(section);
                        break;
                    case TYPE_CARD:
                        _cardItemIdList.Add(section);
                        break;
                    case TYPE_SET:
                        _setItemIdList.Add(section);
                        break;
                }
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
