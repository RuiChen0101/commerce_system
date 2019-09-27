using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commerce_system
{
    public partial class EntryWindow : Form
    {
        private InitialFiles _initial;
        private ItemInfo _itemInfo;
        private ItemOrder _itemOrder;
        private MainWindow _mainWindow;
        private InventoryWindow _inventoryWindow;
        private MainViewLoader _viewLoader;
        public EntryWindow()
        {
            InitializeComponent();
            this.InitialAllClass();
            _mainWindow.FormClosed += this.HandelOrderSyatemClose;
            _inventoryWindow.FormClosed += this.HandelInventorySyatemClose;
        }

        //initial all base class
        private void InitialAllClass()
        {
            _initial = new InitialFiles();
            _itemInfo = new ItemInfo(_initial);
            _itemOrder = new ItemOrder(_itemInfo);
            _mainWindow = new MainWindow();
            _inventoryWindow = new InventoryWindow();
            _viewLoader = new MainViewLoader(_itemInfo, _itemOrder, _mainWindow);
        }

        //on _openOrderSystem click
        private void OpenOrderSyatem(object sender, EventArgs e)
        {
            this._openOrderSystem.Enabled = false;
            _mainWindow.Show();
        }

        //on _openInventorySystem click
        private void OpenInventorySystem(object sender, EventArgs e)
        {
            this._openInventorySystem.Enabled = false;
            _inventoryWindow.Show();
        }

        //exit program
        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //release _openOrderSystem when form close
        private void HandelOrderSyatemClose(object sender, FormClosedEventArgs e)
        {
            this._openOrderSystem.Enabled = true;
        }

        //release _openInventorySystem when form close
        private void HandelInventorySyatemClose(object sender, FormClosedEventArgs e)
        {
            this._openInventorySystem.Enabled = true;
        }
    }
}
