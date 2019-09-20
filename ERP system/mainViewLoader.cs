using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_system
{
    class MainViewLoader
    {
        private ItemInfo _itemInfo;
        private ItemOrder _itemOrder;
        private MainWindow _mainWindow;
        private Dictionary<string,List<string>> _idDict=new Dictionary<string, List<string>>();
        private string _currentClickedItem=null;

        //default constructor
        public MainViewLoader(ItemInfo itemInfo, ItemOrder itemOrder, MainWindow mainWindow)
        {
            this._itemInfo = itemInfo;
            this._itemOrder = itemOrder;
            this._mainWindow = mainWindow;
            this.InitItemDict();
            this.InitItemBtn();
            _mainWindow._onItemClick += this.OnItemClick;
            _mainWindow._onAddToOrderClick += this.OnAddToOrderClick;
        }

        //handel item button click event
        public void OnItemClick(object sender, EventArgs e)
        {
            string senderTag = ((Button)sender).Tag.ToString();
            string[] idData = senderTag.Split('_');
            _currentClickedItem = _idDict[idData[0]][int.Parse(idData[1])-1];
            _mainWindow.SetDesc(_itemInfo.GetItemName(_currentClickedItem)+"\n"+_itemInfo.GetItemDesc(_currentClickedItem));
            _mainWindow.SetItemPrice(_itemInfo.GetItemPrice(_currentClickedItem));
        }

        //handel add_to_cart button click event
        public void OnAddToOrderClick(object sender, EventArgs e)
        {
            if (_currentClickedItem != null){
                _itemOrder.AddToOrder(_currentClickedItem);
                _mainWindow.SetTotalPrice(_itemOrder.GetTotalPrice().ToString());
                string[] orderRow = { _itemInfo.GetItemName(_currentClickedItem), _itemInfo.GetItemTypeName(_currentClickedItem), _itemInfo.GetItemPrice(_currentClickedItem) };
                _mainWindow.AddNewOrderTableRow(orderRow);
            }
        }

        //initialize item id dictionary
        private void InitItemDict()
        {
            _idDict.Add(_itemInfo.GetTypeList()[0], FillIdListLength(_itemInfo.GetCpuItemIdList().Take(6).ToList<string>()));
            _idDict.Add(_itemInfo.GetTypeList()[1], FillIdListLength(_itemInfo.GetMbItemIdList().Take(6).ToList<string>()));
            _idDict.Add(_itemInfo.GetTypeList()[2], FillIdListLength(_itemInfo.GetMemItemIdList().Take(6).ToList<string>()));
            _idDict.Add(_itemInfo.GetTypeList()[3], FillIdListLength(_itemInfo.GetHddItemIdList().Take(6).ToList<string>()));
            _idDict.Add(_itemInfo.GetTypeList()[4], FillIdListLength(_itemInfo.GetGpuItemIdList().Take(6).ToList<string>()));
            _idDict.Add(_itemInfo.GetTypeList()[5], FillIdListLength(_itemInfo.GetSetItemIdList().Take(6).ToList<string>()));
        }

        //initialize all item button
        private void InitItemBtn()
        {
            foreach( string type in _itemInfo.GetTypeList() )
            {
                List<string> imgRefList = new List<string>();
                foreach( string id in _idDict[type] )
                {
                    if (id.Equals(Constants.NULL_STRING))
                    {
                        imgRefList.Add(Constants.NULL_STRING);
                    }
                    else{
                        imgRefList.Add(_itemInfo.GetItemImgRef(id));
                    }
                }
                _mainWindow.SetTabBtn(type, imgRefList);
            }
        }

        //fill empty space of id List with "null"
        private List<string> FillIdListLength(List<string> l)
        {
            while (l.Count < 6)
            {
                l.Add(Constants.NULL_STRING);
            }
            return l;
        }
    }
}
