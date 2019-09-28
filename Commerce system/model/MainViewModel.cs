﻿using System;
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
        private Dictionary<string, List<string>> _idDictionary = new Dictionary<string, List<string>>();
        private Dictionary<string, int> _totalPage = new Dictionary<string, int>();
        private Dictionary<string, int> _currentPage = new Dictionary<string, int>();
        private string _currentClickedItem = null;

        //default constructor
        public MainViewModel(ItemInfo itemInfo)
        {
            this._itemInfo = itemInfo;
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
        public void UpdateCurrentItem(String type, int index)
        {
            this._currentClickedItem = _idDictionary[type][index];
        }

        //return currentItem
        public string GetCurrentItem()
        {
            return this._currentClickedItem;
        }

        //return page data
        public Tuple<int,int> GetCurrentAndTotalPage(string type)
        {
            return new Tuple<int, int>(_currentPage[type],_totalPage[type]);
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