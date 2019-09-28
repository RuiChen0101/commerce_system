using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce_system
{
    public class ItemOrder
    {
        private List<string> _orderIdList = new List<string>();
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
            _orderIdList.Add(itemId);
            _totalPrice += _itemInfo.GetItemPrice(itemId);
        }

        //delete record
        public void DeleteFromOrder(int index)
        {
            _totalPrice -= _itemInfo.GetItemPrice(_orderIdList[index]);
            _orderIdList.RemoveAt(index);
        }

        //return total price
        public int GetTotalPrice()
        {
            return _totalPrice;
        }
    }
}
