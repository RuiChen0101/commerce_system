using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_system{
    class MainViewLoader{
        private ItemInfo itemInfo;
        private ItemOrder itemOrder;
        private MainWindow mainWindow;
        public MainViewLoader(ItemInfo ii, ItemOrder io, MainWindow mw){
            this.itemInfo = ii;
            this.itemOrder = io;
            this.mainWindow = mw;
        }
    }
}
