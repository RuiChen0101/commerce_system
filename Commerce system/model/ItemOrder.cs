using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce_system
{
    public class ItemOrder
    {
        public const int UPDATE_SUCCESS = -1;
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
            if (_itemInfo.IsIdExist(itemId))
            {
                _orderIdList.Add(itemId, 1);
                _totalPrice += _itemInfo.GetItemPrice(itemId);
            }
        }

        //delete record
        public void DeleteFromOrder(int index)
        {
            if (_orderIdList.Count > index && index >= 0)
            {
                string id = _orderIdList.ElementAt(index).Key;
                _totalPrice -= _itemInfo.GetItemPrice(id) * _orderIdList[id];
                _orderIdList.Remove(id);
            }
        }

        //update record quantity
        public int UpdateQuantity(int index, int quantity)
        {
            if (_orderIdList.Count > index && index >= 0)
            {
                string id = _orderIdList.ElementAt(index).Key;
                quantity = _itemInfo.GetItemStock(id) >= quantity ? quantity : _itemInfo.GetItemStock(id);
                int quantityDelta = quantity - _orderIdList[id];
                _totalPrice += (_itemInfo.GetItemPrice(id) * quantityDelta);
                _orderIdList[id] = quantity;
                return quantity;
            }
            return 0;
        }

        //get item total price
        public int GetItemTotalPrice(int index)
        {
            if (_orderIdList.Count > index && index >= 0)
            {
                string id = _orderIdList.ElementAt(index).Key;
                return _itemInfo.GetItemPrice(id) * _orderIdList[id];
            }
            return 0;
        }

        //get item total price by id
        public int GetItemTotalPriceById(string id)
        {
            if (_orderIdList.ContainsKey(id))
            {
                return _itemInfo.GetItemPrice(id) * _orderIdList[id];
            }
            return 0;
        }

        //get item total price
        public int GetItemQuantity(string id)
        {
            if (_orderIdList.ContainsKey(id))
            {
                return _orderIdList[id];
            }
            return 0;
        }

        //check item already in order
        public bool IsInOrder(string id)
        {
            return id != null ? _orderIdList.ContainsKey(id) : false;
        }

        //if checkout can enable
        public bool IsCheckOutEnable()
        {
            return _orderIdList.Count != 0;
        }

        //clear order list
        public void ProceedCheckOut()
        {
            foreach (var item in _orderIdList)
            {
                _itemInfo.WriteBackStockQuantity(item.Key, -item.Value);
            }
            _orderIdList.Clear();
            _totalPrice = 0;
        }

        //return total price
        public int GetTotalPrice()
        {
            return _totalPrice;
        }

        //get order id list
        public List<string> GetOrderIdList()
        {
            return _orderIdList.Keys.ToList();
        }

        //item update
        public void HandleItemUpdateEvent()
        {
            this.UpdateTotalPrice();
        }

        //return total price
        private void UpdateTotalPrice()
        {
            this._totalPrice = 0;
            foreach (var item in _orderIdList)
            {
                this._totalPrice += _itemInfo.GetItemPrice(item.Key) * _orderIdList[item.Key];
            }
        }
    }
}
