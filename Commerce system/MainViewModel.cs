using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commerce_system
{
    public class MainViewModel
    {
        public const int DISPLAY_ITEM_COUNT = 6;
        private ItemInfo _itemInfo;
        private ItemOrder _itemOrder;
        private Dictionary<string, List<string>> _idDictionary = new Dictionary<string, List<string>>();
        private string _currentClickedItem = null;

        //default constructor
        public MainViewModel(ItemInfo itemInfo, ItemOrder itemOrder)
        {
            this._itemInfo = itemInfo;
            this._itemOrder = itemOrder;
            this.InitialItemDictionary();
        }

        //reutrn item image list
        public List<string> GetItemImageByType(String type)
        {
            List<string> imageReferenceList = new List<string>();
            foreach (string id in _idDictionary[type])
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
            return imageReferenceList;
        }

        //update current clicked item id
        public void UpdateCurrentItem(String type, int index)
        {
            this._currentClickedItem = _idDictionary[type][index];
        }

        //return currentItem
        public string GetCurrentItem()
        {
            return this._currentClickedItem;
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
