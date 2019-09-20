using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commerce_system
{
    class MainViewLoader
    {
        public const int DISPLAY_ITEM_COUNT = 6;
        private ItemInfo _itemInfo;
        private ItemOrder _itemOrder;
        private MainWindow _mainWindow;
        private Dictionary<string, List<string>> _idDictionary = new Dictionary<string, List<string>>();
        private string _currentClickedItem = null;

        //default constructor
        public MainViewLoader(ItemInfo itemInfo, ItemOrder itemOrder, MainWindow mainWindow)
        {
            this._itemInfo = itemInfo;
            this._itemOrder = itemOrder;
            this._mainWindow = mainWindow;
            this.InitialItemDictionary();
            this.InitialItemButton();
            _mainWindow._onItemClick += this.OnItemClick;
            _mainWindow._onAddToOrderClick += this.OnAddToOrderClick;
        }

        //handel item button click event
        public void OnItemClick(object sender, EventArgs e)
        {
            const char BREAK_CHAR = '_';
            const string RETURN_CHAR = "\n";
            string senderTag = ((Button)sender).Tag.ToString();
            string[] idData = senderTag.Split(BREAK_CHAR);
            _currentClickedItem = _idDictionary[idData[0]][int.Parse(idData[1]) - 1];
            _mainWindow.SetDescription(_itemInfo.GetItemName(_currentClickedItem) + RETURN_CHAR + _itemInfo.GetItemDescription(_currentClickedItem));
            _mainWindow.SetItemPrice(_itemInfo.GetItemPrice(_currentClickedItem));
        }

        //handel add_to_cart button click event
        public void OnAddToOrderClick(object sender, EventArgs e)
        {
            if (_currentClickedItem != null)
            {
                _itemOrder.AddToOrder(_currentClickedItem);
                _mainWindow.SetTotalPrice(_itemOrder.GetTotalPrice().ToString());
                string[] orderRow = { _itemInfo.GetItemName(_currentClickedItem), _itemInfo.GetItemTypeName(_currentClickedItem), _itemInfo.GetItemPrice(_currentClickedItem) };
                _mainWindow.AddNewOrderTableRow(orderRow);
            }
        }

        //initialize item id dictionary
        private void InitialItemDictionary()
        {
            _idDictionary.Add(ItemInfo.TYPE_PROCESSOR, FillIdListLength(_itemInfo.GetProcessorItemIdList().Take(DISPLAY_ITEM_COUNT).ToList<string>()));
            _idDictionary.Add(ItemInfo.TYPE_BOARD, FillIdListLength(_itemInfo.GetBoardItemIdList().Take(DISPLAY_ITEM_COUNT).ToList<string>()));
            _idDictionary.Add(ItemInfo.TYPE_MEMORY, FillIdListLength(_itemInfo.GetMemoryItemIdList().Take(DISPLAY_ITEM_COUNT).ToList<string>()));
            _idDictionary.Add(ItemInfo.TYPE_DRIVE, FillIdListLength(_itemInfo.GetDriveItemIdList().Take(DISPLAY_ITEM_COUNT).ToList<string>()));
            _idDictionary.Add(ItemInfo.TYPE_CARD, FillIdListLength(_itemInfo.GetCardItemIdList().Take(DISPLAY_ITEM_COUNT).ToList<string>()));
            _idDictionary.Add(ItemInfo.TYPE_SET, FillIdListLength(_itemInfo.GetSetItemIdList().Take(DISPLAY_ITEM_COUNT).ToList<string>()));
        }

        //initialize all item button
        private void InitialItemButton()
        {
            foreach ( string type in _itemInfo.GetTypeList() )
            {
                List<string> imageReferenceList = new List<string>();
                foreach ( string id in _idDictionary[type] )
                {
                    if (id.Equals(Constants.NULL_STRING))
                    {
                        imageReferenceList.Add(Constants.NULL_STRING);
                    }
                    else
                    {
                        imageReferenceList.Add(_itemInfo.GetItemImageReference(id));
                    }
                }
                _mainWindow.SetTabButton(type, imageReferenceList);
            }
        }

        //fill empty space of id List with "null"
        private List<string> FillIdListLength(List<string> list)
        {
            while (list.Count < DISPLAY_ITEM_COUNT)
            {
                list.Add(Constants.NULL_STRING);
            }
            return list;
        }
    }
}
