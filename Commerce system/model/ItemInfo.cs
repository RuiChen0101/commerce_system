using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce_system
{
    public class ItemInfo
    {
        public event OnStockChangeEventHandler _stockChangeEvent;
        public delegate void OnStockChangeEventHandler();

        public event OnItemDataUpdateEventHandler _itemDataUpdateEvent;
        public delegate void OnItemDataUpdateEventHandler();

        public event OnItemCreateEventHandler _itemCreateEvent;
        public delegate void OnItemCreateEventHandler();

        private const string NAME_KEY = "name";
        private const string TYPE_KEY = "type";
        private const string IMAGE_KEY = "imgref";
        private const string DESCRIPTION_KEY = "desc";
        private const string PRICE_KEY = "price";
        private const string STOCK_KEY = "stock";

        private const string INITIAL_FILE_PATH = ".//item.ini";

        private string[] _keyList = { NAME_KEY, TYPE_KEY, IMAGE_KEY, DESCRIPTION_KEY, PRICE_KEY };

        private Dictionary<string, List<string>> _itemList = new Dictionary<string, List<string>>();
        private List<string> _totalItemList = new List<string>();

        private InitialFiles _initial;
        private TypeInfo _typeInfo;

        //deafult constructor
        public ItemInfo(TypeInfo typeInfo)
        {
            this._initial = new InitialFiles(INITIAL_FILE_PATH);
            this._typeInfo = typeInfo;
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
            return id != null ? _initial.ReadInitial(id, TYPE_KEY) : "";
        }

        //get item image reference
        public string GetItemImageReference(string id)
        {
            return id != null ? _initial.ReadInitial(id, IMAGE_KEY) : "";
        }

        //get item description
        public string GetItemDescription(string id)
        {
            return id != null ? _initial.ReadInitial(id, DESCRIPTION_KEY) : "";
        }

        //get item price
        public int GetItemPrice(string id)
        {
            return id != null ? int.Parse(_initial.ReadInitial(id, PRICE_KEY)) : 0;
        }

        //get item stock
        public int GetItemStock(string id)
        {
            return id != null ? int.Parse(_initial.ReadInitial(id, STOCK_KEY)) : 0;
        }

        //get item type name by translate type string
        public string GetItemTypeName(string id)
        {
            string type = this.GetItemType(id);
            return this._typeInfo.GetTypeName(type);
        }

        //set stock
        public void WriteBackStockQuantity(string id, int quantity)
        {
            int leftStock = this.GetItemStock(id) + quantity;
            _initial.WriteInitial(id, STOCK_KEY, leftStock.ToString());
            _stockChangeEvent();
        }

        //update item
        public void UpdateItem(string id, string[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                _initial.WriteInitial(id, _keyList[i], data[i]);
            }
            _itemDataUpdateEvent();
        }

        //new item
        public void CreateItem(string[] data)
        {
            string id = this.GetIdVacancy();
            for (int i = 0; i < data.Length; i++)
            {
                _initial.WriteInitial(id, _keyList[i], data[i]);
            }
            _initial.WriteInitial(id, STOCK_KEY, 0.ToString());
            this.InitialAllItemIdList();
            _itemCreateEvent();
        }

        //get all item id list by input bype
        public List<string> GetItemIdListByType(string type)
        {
            if (_itemList.ContainsKey(type))
            {
                return _itemList[type];
            }
            else
            {
                return new List<string>();
            }
        }

        //get all id list
        public List<string> GetTotalIdList()
        {
            return this._totalItemList;
        }

        //get vacancy
        private string GetIdVacancy()
        {
            const string ITEM = "item";
            string id = "";
            for (int i = 0; i <= _totalItemList.Capacity; i++)
            {
                id = ITEM + i.ToString();
                if (!_totalItemList.Contains(id))
                {
                    break;
                }
            }
            return id;
        }

        //retrive and classify exist item from ini
        private void InitialAllItemIdList()
        {
            this._itemList.Clear();
            this._totalItemList.Clear();
            string[] allSections = _initial.GetSectionNames();
            foreach ( String section in allSections )
            {
                String type = this.GetItemType(section);
                if (!this._itemList.ContainsKey(type))
                {
                    this._itemList.Add(type, new List<string>());
                }
                this._itemList[type].Add(section);
                this._totalItemList.Add(section);
            }
        }
    }
}
