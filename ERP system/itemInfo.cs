using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_system
{
    class ItemInfo
    {
        private readonly string[] _typeList = 
        {   "cpu",
            "mb",
            "mem",
            "hdd",
            "gpu",
            "set"
        };
        private readonly string[] _itemInfoMeta = 
        {   "name",
            "type",
            "imgref",
            "desc",
            "price"
        };
        private List<string> _cpuItemIdList = new List<string> { };
        private List<string> _mbItemIdList = new List<string> { };
        private List<string> _memItemIdList = new List<string> { };
        private List<string> _hddItemIdList = new List<string> { };
        private List<string> _gpuItemIdList = new List<string> { };
        private List<string> _setItemIDList = new List<string> { };

        private IniFile ini;

        //deafult constructor
        public ItemInfo(IniFile ini)
        {
            this.ini = ini;
            this.InitAllItemIdList();
        }

        //get item name
        public string GetItemName(string ID)
        {
            return ini.ReadIni(ID,_itemInfoMeta[0]);
        }

        //get item type
        public string GetItemType(string ID)
        {
            return ini.ReadIni(ID, _itemInfoMeta[1]);
        }

        //get item image reference
        public string GetItemImgRef(string ID)
        {
            return ini.ReadIni(ID, _itemInfoMeta[2]);
        }

        //get item description
        public string GetItemDesc(string ID)
        {
            return ini.ReadIni(ID, _itemInfoMeta[3]);
        }

        //get item price
        public string GetItemPrice(string ID)
        {
            return ini.ReadIni(ID, _itemInfoMeta[4]);
        }

        //get item type name by translate type string
        public string GetItemTypeName(string ID)
        {
            string type = this.GetItemType(ID);
            string typeName = "";
            switch (type)
            {
                case "cpu":
                    typeName = "CPU";
                    break;
                case "mb":
                    typeName = "主機板";
                    break;
                case "mem":
                    typeName = "記憶體";
                    break;
                case "hdd":
                    typeName = "硬碟";
                    break;
                case "gpu":
                    typeName = "顯示卡";
                    break;
                case "set":
                    typeName = "套裝電腦";
                    break;
            }
            return typeName;
        }

        //get all cpu item id list
        public List<string> GetCpuItemIdList()
        {
            return this._cpuItemIdList;
        }

        //get all mother board item id list
        public List<string> GetMbItemIdList()
        {
            return this._mbItemIdList;
        }

        //get all memory item id list
        public List<string> GetMemItemIdList()
        {
            return this._memItemIdList;
        }

        //get all hard drive item id list
        public List<string> GetHddItemIdList()
        {
            return this._hddItemIdList;
        }

        //get all gpu item id list
        public List<string> GetGpuItemIdList()
        {
            return this._gpuItemIdList;
        }

        //get all set item id list
        public List<string> GetSetItemIdList()
        {
            return this._setItemIDList;
        }

        //get all type
        public string[] GetTypeList()
        {
            return this._typeList;
        }

        //retrive and classify exist item from ini
        private void InitAllItemIdList()
        {
            this.ClearAllIdList();
            string[] allSections = ini.GetSectionNames();
            foreach( String section in allSections )
            {
                String type = this.GetItemType(section);
                switch (type)
                {
                    case "cpu":
                        _cpuItemIdList.Add(section);
                        break;
                    case "mb":
                        _mbItemIdList.Add(section);
                        break;
                    case "mem":
                        _memItemIdList.Add(section);
                        break;
                    case "hdd":
                        _hddItemIdList.Add(section);
                        break;
                    case "gpu":
                        _gpuItemIdList.Add(section);
                        break;
                    case "set":
                        _setItemIDList.Add(section);
                        break;
                }
            }
        }

        //clear all id list
        private void ClearAllIdList()
        {
            _cpuItemIdList.Clear();
            _mbItemIdList.Clear();
            _memItemIdList.Clear();
            _hddItemIdList.Clear();
            _gpuItemIdList.Clear();
            _setItemIDList.Clear();
        }
    }
}
