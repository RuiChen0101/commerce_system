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
    public partial class SupplyDialog : Form
    {
        private string _itemId;
        private ItemInfo _itemInfo;
        public SupplyDialog(ItemInfo itemInfo, string id)
        {
            InitializeComponent();
            this._itemId = id;
            this._itemInfo = itemInfo;
            this.InitialDialog();
        }

        //init ui
        private void InitialDialog()
        {
            const string MONEY_UNIT = "元";
            this._itemName.Text = _itemInfo.GetItemName(_itemId);
            this._itemType.Text = _itemInfo.GetItemTypeName(_itemId);
            this._itemPrice.Text = _itemInfo.GetItemPrice(_itemId).ToString(Constants.NUMBER_BREAK_KEY_WORD) + MONEY_UNIT;
            this._itemStock.Text = _itemInfo.GetItemStock(_itemId).ToString();
        }

        //ok click
        private void ClickOk(object sender, EventArgs e)
        {
            if (this._itemSupply.Text.Length != 0)
            {
                _itemInfo.WriteBackStockQuantity(this._itemId, int.Parse(this._itemSupply.Text));
                this.Close();
            }
        }

        //cancel click
        private void ClickCancel(object sender, EventArgs e)
        {
            this.Close();
        }

        //number input limit
        private void CheckNumberInput(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }
    }
}
