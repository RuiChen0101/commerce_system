﻿using System;
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
        private TypeInfo _typeInfo;
        private Dictionary<string, List<string>> _idDictionary = new Dictionary<string, List<string>>();
        private Dictionary<string, int> _totalPage = new Dictionary<string, int>();
        private Dictionary<string, int> _currentPage = new Dictionary<string, int>();
        private string _currentClickedItem = null;

        //default constructor
        public MainPresentationModel(ItemInfo itemInfo, TypeInfo typeInfo, ItemOrder itemOrder)
        {
            this._itemInfo = itemInfo;
            this._itemOrder = itemOrder;
            this._typeInfo = typeInfo;
            this.InitialItemDictionary();
            this.InitialPageData();
            this.InitialCurrentPage();
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

        //set to null
        public void ClearCurrentClickedItem()
        {
            this._currentClickedItem = null;
        }

        //get order Row
        public string[] GetItemRowInfo(string id)
        {
            string[] orderRow = { "", _itemInfo.GetItemName(id), _itemInfo.GetItemTypeName(id), _itemInfo.GetItemPrice(id).ToString(Constants.NUMBER_BREAK_KEY_WORD), _itemOrder.GetItemQuantity(id).ToString(), _itemOrder.GetItemTotalPriceById(id).ToString(Constants.NUMBER_BREAK_KEY_WORD) };
            return orderRow;
        }

        //update current clicked item id
        public string UpdateCurrentItemByTag(string senderTag)
        {
            const char BREAK_CHAR = '_';
            string[] idData = senderTag.Split(BREAK_CHAR);
            this._currentClickedItem = _idDictionary[idData[0]][int.Parse(idData[1])];
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
            return _currentPage[type] > 1;
        }

        //check NextPage button is enable
        public bool IsNextPageEnable(string type)
        {
            return _currentPage[type] < _totalPage[type];
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

        // handle item create event
        public void HandleItemUpdateEvent()
        {
            this.InitialPageData();
            this.UpdateItemDictionary();
        }

        // handle item create event
        public void HandleTypeUpdateEvent()
        {
            this.UpdateCurrentPage();
            this.InitialPageData();
            this.UpdateItemDictionary();
        }

        //update item id dictionary
        private void UpdateItemDictionary()
        {
            foreach (string type in this._typeInfo.GetTypeList())
            {
                if (_idDictionary.ContainsKey(type))
                {
                    _idDictionary[type] = FillIdListLength(_itemInfo.GetItemIdListByType(type).Skip((_currentPage[type] - 1) * DISPLAY_ITEM_COUNT).Take(DISPLAY_ITEM_COUNT).ToList<string>());
                }
                else
                {
                    _idDictionary.Add(type, FillIdListLength(_itemInfo.GetItemIdListByType(type).Take(DISPLAY_ITEM_COUNT).ToList<string>()));
                }
            }
        }

        //initialize item id dictionary
        private void InitialItemDictionary()
        {
            foreach (string type in this._typeInfo.GetTypeList())
            {
                _idDictionary.Add(type, FillIdListLength(_itemInfo.GetItemIdListByType(type).Take(DISPLAY_ITEM_COUNT).ToList<string>()));
            }
        }

        //initial page data
        private void InitialPageData()
        {
            _totalPage.Clear();
            foreach (string type in this._typeInfo.GetTypeList())
            {
                int totalPageCount = (_itemInfo.GetItemIdListByType(type).Count + DISPLAY_ITEM_COUNT - 1) / DISPLAY_ITEM_COUNT;
                if (!_totalPage.ContainsKey(type))
                {
                    _totalPage.Add(type, totalPageCount < 1 ? 1 : totalPageCount);
                }
                else
                {
                    _totalPage[type] = totalPageCount;
                }
            }
        }

        //update current Page
        private void UpdateCurrentPage()
        {
            foreach (string type in this._typeInfo.GetTypeList())
            {
                if (!_currentPage.ContainsKey(type))
                {
                    _currentPage.Add(type, 1);
                }
            }
        }

        //initial current Page
        private void InitialCurrentPage()
        {
            foreach (string type in this._typeInfo.GetTypeList())
            {
                _currentPage.Add(type, 1);
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
