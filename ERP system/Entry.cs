using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_system{
    static class Entry{
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main(){
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IniFile ini = new IniFile();
            ItemInfo itemInfo = new ItemInfo(ini);
            Application.Run(new MainWindow());
        }
    }
}
