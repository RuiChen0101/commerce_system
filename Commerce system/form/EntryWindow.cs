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
        private ItemInfo _itemInfo;
        private ItemOrder _itemOrder;
        private TypeInfo _typeInfo;
        public EntryWindow()
        {
            InitializeComponent();
            this.InitialAllClass();
        }

        //initial all base class
        private void InitialAllClass()
        {
            _typeInfo = new TypeInfo();
            _itemInfo = new ItemInfo(_typeInfo);
            _itemOrder = new ItemOrder(_itemInfo);
        }

        //on _openOrderSystem click
        private void OpenOrderSystem(object sender, EventArgs e)
        {
            this._openOrderSystem.Enabled = false;
            MainWindow mainWindow = new MainWindow(_itemInfo, _typeInfo, _itemOrder);
            mainWindow.Show();
            mainWindow.FormClosed += this.HandleOrderSystemClose;
        }

        //on _openInventorySystem click
        private void OpenInventorySystem(object sender, EventArgs e)
        {
            this._openInventorySystem.Enabled = false;
            InventoryWindow inventoryWindow = new InventoryWindow(_itemInfo);
            inventoryWindow.Show();
            inventoryWindow.FormClosed += this.HandleInventorySystemClose;
        }

        //on _openProductManageSystem click
        private void OpenProductSystem(object sender, EventArgs e)
        {
            this._openProductManageSystem.Enabled = false;
            ProductWindow productWindow = new ProductWindow(_itemInfo, _typeInfo);
            productWindow.Show();
            productWindow.FormClosed += this.HandleProductSystemClose;
        }

        //exit program
        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //release _openOrderSystem when form close
        private void HandleOrderSystemClose(object sender, FormClosedEventArgs e)
        {
            this._openOrderSystem.Enabled = true;
        }

        //release _openInventorySystem when form close
        private void HandleInventorySystemClose(object sender, FormClosedEventArgs e)
        {
            this._openInventorySystem.Enabled = true;
        }

        //release _openProductManageSystem when form close
        private void HandleProductSystemClose(object sender, FormClosedEventArgs e)
        {
            this._openProductManageSystem.Enabled = true;
        }
    }
}
