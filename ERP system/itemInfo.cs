using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_system {
    class ItemInfo{
        private List<string> typeList = new List<string> { "cpu", "mb", "mem", "hdd", "gpu", "set" };
        private List<string> itemInfoMeta = new List<string> {"name","type","desc","price"};
        private List<string> cpuItemIDList = new List<string> { };
        private List<string> mbItemIDList = new List<string> { };
        private List<string> memItemIDList = new List<string> { };
        private List<string> hddItemIDList = new List<string> { };
        private List<string> gpuItemIDList = new List<string> { };
        private List<string> setItemIDList = new List<string> { };

        private IniFile ini;

        public ItemInfo(IniFile ini){
            this.ini = ini;
            this.initAllItemIDList();
        }

        public string getItemName(string ID){
            return ini.readIni(ID,itemInfoMeta[0]);
        }

        public string getItemType(string ID){
            return ini.readIni(ID, itemInfoMeta[1]);
        }

        public string getItemDesc(string ID){
            return ini.readIni(ID, itemInfoMeta[2]);
        }

        public string getItemPrice(string ID){
            return ini.readIni(ID, itemInfoMeta[3]);
        }

        public string getItemTypeName(string ID){
            string type = this.getItemType(ID);
            string typeName="";
            switch (type){
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

        public List<string> getCpuItemIDList(){
            return this.cpuItemIDList;
        }

        public List<string> getMbItemIDList(){
            return this.mbItemIDList;
        }

        public List<string> getMemItemIDList(){
            return this.memItemIDList;
        }

        public List<string> getHddItemIDList(){
            return this.hddItemIDList;
        }

        public List<string> getGpuItemIDList(){
            return this.gpuItemIDList;
        }

        public List<string> getSetItemIDList(){
            return this.setItemIDList;
        }

        public List<string> getTypeList(){
            return this.typeList;
        }

        private void initAllItemIDList(){
            this.clearAllIDList();
            string[] allSections = ini.GetSectionNames();
            foreach(String section in allSections){
                String type = this.getItemType(section);
                switch (type){
                    case "cpu":
                        cpuItemIDList.Add(section);
                        break;
                    case "mb":
                        mbItemIDList.Add(section);
                        break;
                    case "mem":
                        memItemIDList.Add(section);
                        break;
                    case "hdd":
                        hddItemIDList.Add(section);
                        break;
                    case "gpu":
                        gpuItemIDList.Add(section);
                        break;
                    case "set":
                        setItemIDList.Add(section);
                        break;
                }
            }
        }

        private void clearAllIDList(){
            cpuItemIDList.Clear();
            mbItemIDList.Clear();
            memItemIDList.Clear();
            hddItemIDList.Clear();
            gpuItemIDList.Clear();
            setItemIDList.Clear();
        }
    }
}
