using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce_system
{
    public class ItemOrder
    {
        private Dictionary<string,int> _orderIdList = new Dictionary<string, int>();
        private int _totalPrice = 0;
        private ItemInfo _itemInfo;

        //default constructor
        public ItemOrder(ItemInfo itemInfo)
        {
            this._itemInfo = itemInfo;
        }

        //store ordered id and update total price
        public void AddToOrder(string itemId)
        {
            _orderIdList.Add(itemId,1);
            _totalPrice += _itemInfo.GetItemPrice(itemId);
        }

        //delete record
        public void DeleteFromOrder(int index)
        {
            string key = _orderIdList.ElementAt(index).Key;
            _totalPrice -= _itemInfo.GetItemPrice(key);
            _orderIdList.Remove(key);
        }

        //check item already in order
        public bool IsInOrder(string id)
        {
            return _orderIdList.ContainsKey(id);
        }

        //clear order list
        public void ClearOrder()
        {
            _orderIdList.Clear();
            _totalPrice = 0;
        }

        //return total price
        public int GetTotalPrice()
        {
            return _totalPrice;
        }
    }
}
