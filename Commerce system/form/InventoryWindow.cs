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
    public partial class InventoryWindow : Form
    {
        private ItemInfo _itemInfo;
        private List<string> _totalIdList = new List<string>();
        private const string DELETE_ICON_PATH = ".\\img\\icon\\delivery-truck.bmp";
        public InventoryWindow(ItemInfo itemInfo)
        {
            this._itemInfo = itemInfo;
            InitializeComponent();
            this._totalIdList = _itemInfo.GetTotalIdList();
            this.SetUpInventoryList();
            _itemInfo._stockChangeEvent += this.UpdateStockEvent;
            _itemInfo._itemDataUpdateEvent += this.UpdateStockEvent;
            _itemInfo._itemCreateEvent += this.UpdateStockEvent;
        }

        //Initial Inventory List
        private void SetUpInventoryList()
        {
            this._inventoryList.Rows.Clear();
            foreach (string id in _totalIdList)
            {
                string[] itemRow = { _itemInfo.GetItemName(id), _itemInfo.GetItemTypeName(id), _itemInfo.GetItemPrice(id).ToString(Constants.NUMBER_BREAK_KEY_WORD), _itemInfo.GetItemStock(id).ToString(), "" };
                this._inventoryList.Rows.Add(itemRow);
            }
        }

        //draw supply image to data grid
        private void SetSupplyImageGrid(object sender, DataGridViewCellPaintingEventArgs e)
        {
            const int SUPPLY_INDEX = 4;
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == SUPPLY_INDEX)
            {
                Image image = Image.FromFile(DELETE_ICON_PATH);
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                int w = image.Width;
                int h = image.Height;
                var x = e.CellBounds.Left + ((e.CellBounds.Width - w) >> 1);
                var y = e.CellBounds.Top + ((e.CellBounds.Height - h) >> 1);
                e.Graphics.DrawImage(image, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        //stock update event handeler
        private void UpdateStockEvent()
        {
            this.SetUpInventoryList();
        }

        //Click Cell Content
        private void ChangeSelection(object sender, EventArgs e)
        {
            if (this._inventoryList.SelectedRows.Count != 0)
            {
                int index = this._inventoryList.SelectedRows[0].Index;
                string id = _totalIdList[index];
                this._itemPicture.BackgroundImage = new Bitmap(Constants.IMAGE_FILE_PATH + _itemInfo.GetItemImageReference(id));
                this._descriptionBox.Text = _itemInfo.GetItemDescription(id);
            }
        }

        // supply click
        private void ClickCellContent(object sender, DataGridViewCellEventArgs e)
        {
            const int SUPPLY_INDEX = 4;
            if (e.ColumnIndex == SUPPLY_INDEX)
            {
                SupplyDialog supply = new SupplyDialog(_itemInfo, _totalIdList[e.RowIndex]);
                supply.ShowDialog();
            }
        }
    }
}
