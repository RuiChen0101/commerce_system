using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_system{
    class MainViewLoader{
        private ItemInfo itemInfo;
        private ItemOrder itemOrder;
        private MainWindow mainWindow;
        private Dictionary<string,List<string>> idDict=new Dictionary<string, List<string>>();
        private string currentClickedItem;
        public MainViewLoader(ItemInfo ii, ItemOrder io, MainWindow mw){
            this.itemInfo = ii;
            this.itemOrder = io;
            this.mainWindow = mw;
            this.initItemData();
            this.initItemBtn();
            mainWindow.onItemClick += this.onItemClick;
        }

        public void onItemClick(object sender, EventArgs e){
        }
        
        private void initItemData(){
            idDict.Add("cpu", fillIDListLength(itemInfo.getCpuItemIDList().Take(6).ToList<string>()));
            idDict.Add("mb", fillIDListLength(itemInfo.getMbItemIDList().Take(6).ToList<string>()));
            idDict.Add("mem", fillIDListLength(itemInfo.getMemItemIDList().Take(6).ToList<string>()));
            idDict.Add("hdd", fillIDListLength(itemInfo.getHddItemIDList().Take(6).ToList<string>()));
            idDict.Add("gpu", fillIDListLength(itemInfo.getGpuItemIDList().Take(6).ToList<string>()));
            idDict.Add("set", fillIDListLength(itemInfo.getSetItemIDList().Take(6).ToList<string>()));
        }

        private void initItemBtn(){
            foreach(string type in itemInfo.getTypeList()){
                mainWindow.setTabBtn(type, idDict[type]);
            }
        }

        private List<string> fillIDListLength(List<string> l){
            while (l.Count < 6){
                l.Add("null");
            }
            return l;
        }
    }
}
