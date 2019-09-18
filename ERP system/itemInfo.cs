using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_system {
    class ItemInfo{
        private List<string> itemInfoMeta = new List<string> {"name","type","desc","price"};
        private List<string> cpuItemIDList = new List<string> { "cpu_item001" };
        private List<string> mbItemIDList = new List<string> { };
        private List<string> memItemIDList = new List<string> { };
        private List<string> hddItemIDList = new List<string> { };
        private List<string> gpuItemIDList = new List<string> { };
        private List<string> setItemIDList = new List<string> { };

        private IniFile ini;

        public ItemInfo(IniFile ini){
            this.ini = ini;
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

        public List<string> getCpuItemIDList(){
            return cpuItemIDList;
        }

        public List<string> getMbItemIDList(){
            return mbItemIDList;
        }

        public List<string> getMemItemIDList(){
            return memItemIDList;
        }

        public List<string> getHddItemIDList(){
            return hddItemIDList;
        }

        public List<string> getGpuItemIDList(){
            return gpuItemIDList;
        }

        public List<string> getSetItemIDList(){
            return setItemIDList;
        }
    }
}
