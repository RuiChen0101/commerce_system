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

        private string _name = "";
        private string _type = "";
        private string _price = "";
        private string _image = "";
        private string _description = "";
        private int _editIndex = CREATE_INDEX;

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
        public bool IsSaveEnable()
        {
            return _name != "" && _type != "" && _price != "" && _image != "" && _description != "";
        }
        
        //update index
        public void SetEditIndex(int index)
        {
            _editIndex = index;
        }

        //update data
        public void SetFieldName(string name)
        {
            _name = name;
        }

        //update data
        public void SetFieldType(string type)
        {
            _type = type;
        }

        //update data
        public void SetFieldPrice(string price)
        {
            _price = price;
        }

        //update data
        public void SetFieldImage(string image)
        {
            _image = image;
        }

        //update data
        public void SetFieldDescription(string description)
        {
            _description = description;
        }

        //HandelFileOpen
        public string HandleFileOpen(string inputFilePath)
        {
            const char BREAK_CHAR = '\\';
            string fileName = inputFilePath.Split(BREAK_CHAR).Last();
            File.Copy(inputFilePath, Constants.IMAGE_FILE_PATH + fileName, true);
            return fileName;
        }
        
        //start save
        public void StartSave()
        {
            string[] data = { _name, _typeInfo.GetTypeIdByName(_type), _image, _description, _price };
            if (_editIndex != CREATE_INDEX)
            {
                string id = _itemInfo.GetTotalIdList()[_editIndex];
                _itemInfo.UpdateItem(id, data);
            }
            else
            {
                _itemInfo.CreateItem(data);
            }
        }
    }
}
