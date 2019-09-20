using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commerce_system
{
    static class Entry
    {
        /// 應用程式的主要進入點。
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            InitialFiles ini = new InitialFiles();
            ItemInfo itemInfo = new ItemInfo(ini);
            ItemOrder itemOrder = new ItemOrder(itemInfo);
            MainWindow mainWindow = new MainWindow();
            MainViewLoader viewLoader = new MainViewLoader(itemInfo, itemOrder, mainWindow);
            Application.Run(mainWindow);
        }
    }
}
