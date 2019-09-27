﻿using System;
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
        private MainViewModel _viewModel;
        public EntryWindow()
        {
            InitializeComponent();
            this.InitialAllClass();
        }

        //initial all base class
        private void InitialAllClass()
        {
            _initial = new InitialFiles();
            _itemInfo = new ItemInfo(_initial);
            _itemOrder = new ItemOrder(_itemInfo);
            _viewModel = new MainViewModel(_itemInfo);
        }

        //on _openOrderSystem click
        private void OpenOrderSystem(object sender, EventArgs e)
        {
            this._openOrderSystem.Enabled = false;
            MainWindow mainWindow = new MainWindow(_itemInfo, _itemOrder, _viewModel);
            mainWindow.Show();
            mainWindow.FormClosed += this.HandleOrderSystemClose;
        }

        //on _openInventorySystem click
        private void OpenInventorySystem(object sender, EventArgs e)
        {
            this._openInventorySystem.Enabled = false;
            InventoryWindow inventoryWindow = new InventoryWindow();
            inventoryWindow.Show();
            inventoryWindow.FormClosed += this.HandleInventorySystemClose;
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
    }
}