using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_system{
    class MainViewLoader{
        private ItemInfo itemInfo;
        private ItemOrder itemOrder;
        private MainWindow mainWindow;
        private Dictionary<string,List<string>> idDict=new Dictionary<string, List<string>>();
        private string currentClickedItem=null;

        public MainViewLoader(ItemInfo ii, ItemOrder io, MainWindow mw){
            this.itemInfo = ii;
            this.itemOrder = io;
            this.mainWindow = mw;
            this.initItemData();
            this.initItemBtn();
            mainWindow.onItemClick += this.onItemClick;
            mainWindow.onAddToCartClick += this.onAddToCartClick;
        }

        public void onItemClick(object sender, EventArgs e){
            string senderName = ((Button)sender).Name;
            string[] idData = senderName.Split('_');
            idData[1] = idData[1].Last().ToString();
            currentClickedItem = idDict[idData[0]][int.Parse(idData[1])-1];
            mainWindow.setDesc(itemInfo.getItemName(currentClickedItem)+"\n"+itemInfo.getItemDesc(currentClickedItem));
            mainWindow.setItemPrice(itemInfo.getItemPrice(currentClickedItem));
        }

        public void onAddToCartClick(object sender, EventArgs e){
            if (currentClickedItem != null){
                itemOrder.addToOrder(currentClickedItem);
                mainWindow.setTotalPrice(itemOrder.getTotalPrice().ToString());
                string[] orderRow = { itemInfo.getItemName(currentClickedItem), itemInfo.getItemTypeName(currentClickedItem), itemInfo.getItemPrice(currentClickedItem) };
                mainWindow.addNewOrderTableRow(orderRow);
            }
        }

        private void initItemData(){
            idDict.Add(itemInfo.getTypeList()[0], fillIDListLength(itemInfo.getCpuItemIDList().Take(6).ToList<string>()));
            idDict.Add(itemInfo.getTypeList()[1], fillIDListLength(itemInfo.getMbItemIDList().Take(6).ToList<string>()));
            idDict.Add(itemInfo.getTypeList()[2], fillIDListLength(itemInfo.getMemItemIDList().Take(6).ToList<string>()));
            idDict.Add(itemInfo.getTypeList()[3], fillIDListLength(itemInfo.getHddItemIDList().Take(6).ToList<string>()));
            idDict.Add(itemInfo.getTypeList()[4], fillIDListLength(itemInfo.getGpuItemIDList().Take(6).ToList<string>()));
            idDict.Add(itemInfo.getTypeList()[5], fillIDListLength(itemInfo.getSetItemIDList().Take(6).ToList<string>()));
        }

        private void initItemBtn(){
            foreach(string type in itemInfo.getTypeList()){
                List<string> imgRefList = new List<string>();
                foreach(string id in idDict[type]){
                    if (id.Equals("null")){
                        imgRefList.Add("null");
                    }
                    else{
                        imgRefList.Add(itemInfo.getItemImgRef(id));
                    }
                }
                mainWindow.setTabBtn(type, imgRefList);
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
