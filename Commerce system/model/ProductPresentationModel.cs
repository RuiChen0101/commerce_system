using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce_system
{
    public class ProductPresentationModel
    {
        public const int CREATE_INDEX = -1;

        private string _itemName = "";
        private string _itemType = "";
        private string _itemPrice = "";
        private string _itemImage = "";
        private string _itemDescription = "";
        private string _typeName = "";
        private int _itemEditIndex = CREATE_INDEX;
        private int _typeEditIndex = CREATE_INDEX;

        private ItemInfo _itemInfo;
        private TypeInfo _typeInfo;

        public ProductPresentationModel(ItemInfo itemInfo, TypeInfo typeInfo)
        {
            this._itemInfo = itemInfo;
            this._typeInfo = typeInfo;
        }

        //is number only input
        public bool IsNumberInput(char input)
        {
            return Char.IsDigit(input) || Char.IsControl(input);
        }

        //IsSaveEnable
        public bool IsItemSaveEnable()
        {
            return _itemName != "" && _itemType != "" && _itemPrice != "" && _itemImage != "" && _itemDescription != "";
        }

        //IsSaveEnable
        public bool IsTypeSaveEnable()
        {
            return _typeName != "" && _typeEditIndex == CREATE_INDEX;
        }

        //update index
        public void SetTypeEditIndex(int index)
        {
            _typeEditIndex = index;
        }

        //update index
        public void SetItemEditIndex(int index)
        {
            _itemEditIndex = index;
        }

        //update data
        public void SetItemFieldName(string name)
        {
            _itemName = name;
        }

        //update data
        public void SetItemFieldType(string type)
        {
            _itemType = type;
        }

        //update data
        public void SetItemFieldPrice(string price)
        {
            _itemPrice = price;
        }

        //update data
        public void SetItemFieldImage(string image)
        {
            _itemImage = image;
        }

        //update data
        public void SetItemFieldDescription(string description)
        {
            _itemDescription = description;
        }

        //update data
        public void SetTypeFieldName(string name)
        {
            _typeName = name;
        }

        //HandelFileOpen
        public string HandleFileOpen(string inputFilePath)
        {
            const char BREAK_CHAR = '\\';
            string fileName = inputFilePath.Split(BREAK_CHAR).Last();
            string destination = Constants.IMAGE_FILE_PATH + fileName;
            if (!File.Exists(destination))
            {
                File.Copy(inputFilePath, destination);
            }
            return fileName;
        }
        
        //start item save
        public void StartItemSave()
        {
            string[] data = { _itemName, _typeInfo.GetTypeIdByName(_itemType), _itemImage, _itemDescription, _itemPrice };
            if (_itemEditIndex != CREATE_INDEX)
            {
                string id = _itemInfo.GetTotalIdList()[_itemEditIndex];
                _itemInfo.UpdateItem(id, data);
            }
            else
            {
                _itemInfo.CreateItem(data);
            }
        }

        //start type save
        public void StartTypeSave()
        {
            string[] data = { _typeName };
            Console.WriteLine(_typeEditIndex);
            if (_typeEditIndex != CREATE_INDEX)
            {
                string id = _typeInfo.GetTypeList()[_typeEditIndex];
                _typeInfo.UpdateType(id, data);
            }
            else
            {
                _typeInfo.CreateType(data);
            }
        }
    }
}
