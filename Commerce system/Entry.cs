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
            EntryWindow entryWindow = new EntryWindow();
            Application.Run(entryWindow);
        }
    }
}
