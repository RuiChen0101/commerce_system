using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_system{
    class ItemOrder{
        private List<string> orderIDList = new List<string> { };
        private int totalPrice = 0;
        private ItemInfo itemInfo;

        public ItemOrder(ItemInfo ii){
            this.itemInfo = ii;
        }

        public void addToOrder(string itemId){
            orderIDList.Add(itemId);
            totalPrice += int.Parse(itemInfo.getItemPrice(itemId));
        }

        public int getTotalPrice(){
            return totalPrice;
        }
    }
}