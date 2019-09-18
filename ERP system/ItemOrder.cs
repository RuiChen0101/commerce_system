using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_system{
    class ItemOrder{
        private List<string> orderIDList = new List<string> { };
        private ItemInfo itemInfo;
        public ItemOrder(ItemInfo ii){
            this.itemInfo = ii;
        }
    }
}