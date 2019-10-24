using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce_system
{
    public class MainPresentationModel
    {
        public const int DISPLAY_ITEM_COUNT = 6;
        private ItemInfo _itemInfo;
        private ItemOrder _itemOrder;
        private Dictionary<string, List<string>> _idDictionary = new Dictionary<string, List<string>>();
        private Dictionary<string, int> _totalPage = new Dictionary<string, int>();
        private Dictionary<string, int> _currentPage = new Dictionary<string, int>();
        private string _currentClickedItem = null;

        //default constructor
        public MainPresentationModel(ItemInfo itemInfo, ItemOrder itemOrder)
        {
            this._itemInfo = itemInfo;
            this._itemOrder = itemOrder;
            this.InitialItemDictionary();
            this.InitialPageData();
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
        public string UpdateCurrentItemByTag(string senderTag)
        {
            const char BREAK_CHAR = '_';
            string[] idData = senderTag.Split(BREAK_CHAR);
            this._currentClickedItem = _idDictionary[idData[0]][int.Parse(idData[1]) - 1];
            return this._currentClickedItem;
        }

        //return currentItem
        public string GetCurrentItem()
        {
            return this._currentClickedItem;
        }

        //return page data
        public string GetCurrentAndTotalPage(string type)
        {
            const string BACK_SLASH = "/";
            return _currentPage[type].ToString() + BACK_SLASH + _totalPage[type].ToString();
        }

        //check PreviousPage button is enable
        public bool IsPreviousPageEnable(string type)
        {
            return _currentPage[type] != 1;
        }

        //check NextPage button is enable
        public bool IsNextPageEnable(string type)
        {
            return _currentPage[type] != _totalPage[type];
        }

        //check NextPage button is enable
        public bool IsAddToCartEnable()
        {
            return !_itemOrder.IsInOrder(this._currentClickedItem) && !(_itemInfo.GetItemStock(this._currentClickedItem) <= 0);
        }

        //change to next page
        public void ChangeToNextPage(string type)
        {
            if (IsNextPageEnable(type))
            {
                _currentPage[type]++;
                _idDictionary[type] = FillIdListLength(_itemInfo.GetItemIdListByType(type).Skip((_currentPage[type] - 1) * DISPLAY_ITEM_COUNT).Take(DISPLAY_ITEM_COUNT).ToList<string>());
            }
        }

        //change to previous page
        public void ChangeToPreviousPage(string type)
        {
            if (IsPreviousPageEnable(type))
            {
                _currentPage[type]--;
                _idDictionary[type] = FillIdListLength(_itemInfo.GetItemIdListByType(type).Skip((_currentPage[type] - 1) * DISPLAY_ITEM_COUNT).Take(DISPLAY_ITEM_COUNT).ToList<string>());
            }
        }

        //initialize item id dictionary
        private void InitialItemDictionary()
        {
            _idDictionary.Add(ItemInfo.TYPE_PROCESSOR, FillIdListLength(_itemInfo.GetItemIdListByType(ItemInfo.TYPE_PROCESSOR).Take(DISPLAY_ITEM_COUNT).ToList<string>()));
            _idDictionary.Add(ItemInfo.TYPE_BOARD, FillIdListLength(_itemInfo.GetItemIdListByType(ItemInfo.TYPE_BOARD).Take(DISPLAY_ITEM_COUNT).ToList<string>()));
            _idDictionary.Add(ItemInfo.TYPE_MEMORY, FillIdListLength(_itemInfo.GetItemIdListByType(ItemInfo.TYPE_MEMORY).Take(DISPLAY_ITEM_COUNT).ToList<string>()));
            _idDictionary.Add(ItemInfo.TYPE_DRIVE, FillIdListLength(_itemInfo.GetItemIdListByType(ItemInfo.TYPE_DRIVE).Take(DISPLAY_ITEM_COUNT).ToList<string>()));
            _idDictionary.Add(ItemInfo.TYPE_CARD, FillIdListLength(_itemInfo.GetItemIdListByType(ItemInfo.TYPE_CARD).Take(DISPLAY_ITEM_COUNT).ToList<string>()));
            _idDictionary.Add(ItemInfo.TYPE_SET, FillIdListLength(_itemInfo.GetItemIdListByType(ItemInfo.TYPE_SET).Take(DISPLAY_ITEM_COUNT).ToList<string>()));
        }

        //initial page data
        private void InitialPageData()
        {
            _totalPage.Add(ItemInfo.TYPE_PROCESSOR,((_itemInfo.GetItemIdListByType(ItemInfo.TYPE_PROCESSOR).Count + DISPLAY_ITEM_COUNT - 1) / DISPLAY_ITEM_COUNT));
            _totalPage.Add(ItemInfo.TYPE_BOARD, ((_itemInfo.GetItemIdListByType(ItemInfo.TYPE_BOARD).Count + DISPLAY_ITEM_COUNT - 1) / DISPLAY_ITEM_COUNT));
            _totalPage.Add(ItemInfo.TYPE_MEMORY, ((_itemInfo.GetItemIdListByType(ItemInfo.TYPE_MEMORY).Count + DISPLAY_ITEM_COUNT - 1) / DISPLAY_ITEM_COUNT));
            _totalPage.Add(ItemInfo.TYPE_DRIVE, ((_itemInfo.GetItemIdListByType(ItemInfo.TYPE_DRIVE).Count + DISPLAY_ITEM_COUNT - 1) / DISPLAY_ITEM_COUNT));
            _totalPage.Add(ItemInfo.TYPE_CARD, ((_itemInfo.GetItemIdListByType(ItemInfo.TYPE_CARD).Count + DISPLAY_ITEM_COUNT - 1) / DISPLAY_ITEM_COUNT));
            _totalPage.Add(ItemInfo.TYPE_SET, ((_itemInfo.GetItemIdListByType(ItemInfo.TYPE_SET).Count + DISPLAY_ITEM_COUNT - 1) / DISPLAY_ITEM_COUNT));
            _currentPage.Add(ItemInfo.TYPE_PROCESSOR, 1);
            _currentPage.Add(ItemInfo.TYPE_BOARD, 1);
            _currentPage.Add(ItemInfo.TYPE_MEMORY, 1);
            _currentPage.Add(ItemInfo.TYPE_DRIVE, 1);
            _currentPage.Add(ItemInfo.TYPE_CARD, 1);
            _currentPage.Add(ItemInfo.TYPE_SET, 1);
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
