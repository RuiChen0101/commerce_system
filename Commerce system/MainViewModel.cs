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
        private Dictionary<string, List<string>> _idDictionary = new Dictionary<string, List<string>>();
        private int[] _totalPage = { 0,0,0,0,0,0 };
        private int[] _currentPage = { 1,1,1,1,1,1 };
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
        public Tuple<int,int> GetCurrentAndTotalPage(int index)
        {
            return new Tuple<int, int>(_currentPage[index],_totalPage[index]);
        }

        //check PreviousPage button is enable
        public bool IsPreviousPageEnable(int index)
        {
            return _currentPage[index] != 1;
        }

        //check NextPage button is enable
        public bool IsNextPageEnable(int index)
        {
            return _currentPage[index] != _totalPage[index];
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

        //initial page data
        private void InitialPageData()
        {
            _totalPage[ItemInfo.TYPE_PROCESSOR_INDEX] = ((_itemInfo.GetProcessorItemIdList().Count + DISPLAY_ITEM_COUNT - 1) / DISPLAY_ITEM_COUNT);
            _totalPage[ItemInfo.TYPE_BOARD_INDEX] = ((_itemInfo.GetBoardItemIdList().Count + DISPLAY_ITEM_COUNT - 1) / DISPLAY_ITEM_COUNT);
            _totalPage[ItemInfo.TYPE_MEMORY_INDEX] = ((_itemInfo.GetMemoryItemIdList().Count + DISPLAY_ITEM_COUNT - 1) / DISPLAY_ITEM_COUNT);
            _totalPage[ItemInfo.TYPE_DRIVE_INDEX] = ((_itemInfo.GetDriveItemIdList().Count + DISPLAY_ITEM_COUNT - 1) / DISPLAY_ITEM_COUNT);
            _totalPage[ItemInfo.TYPE_CARD_INDEX] = ((_itemInfo.GetCardItemIdList().Count + DISPLAY_ITEM_COUNT - 1) / DISPLAY_ITEM_COUNT);
            _totalPage[ItemInfo.TYPE_SET_INDEX] = ((_itemInfo.GetSetItemIdList().Count + DISPLAY_ITEM_COUNT - 1) / DISPLAY_ITEM_COUNT);
            Console.WriteLine(_totalPage[ItemInfo.TYPE_BOARD_INDEX].ToString());
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
