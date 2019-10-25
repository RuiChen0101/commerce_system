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
    public partial class MainWindow : Form
    {
        private ItemInfo _itemInfo;
        private ItemOrder _itemOrder;
        private TypeInfo _typeInfo;
        private MainPresentationModel _viewModel;
        private PaymentDialog _paymentDialog;

        private const string ITEM_PRICE_STRING = "單價: ";
        private const string TOTAL_PRICE_STRING = "總價: ";
        private const string STOCK_LEFT_STRING = "庫存數量: ";
        private const string MONEY_UNIT = "元";
        private const string DELETE_ICON_PATH = ".\\img\\icon\\delete.png";

        private const int PADDING = 2;

        private Dictionary<string, List<Button>> _buttonDictionary = new Dictionary<string, List<Button>>();

        //default constructor
        public MainWindow(ItemInfo itemInfo, TypeInfo typeInfo, ItemOrder itemOrder)
        {
            InitializeComponent();
            this._itemInfo = itemInfo;
            this._itemOrder = itemOrder;
            this._typeInfo = typeInfo;
            this._viewModel = new MainPresentationModel(_itemInfo, _typeInfo, _itemOrder);
            this._paymentDialog = new PaymentDialog();
            this.InitialItemTab();
            this.InitialAllItemButton();
            this.HandleTabIndexChanged(null, null);
            _itemInfo._stockChangeEvent += this.UpdateStockEvent;
        }

        //setting item button
        private void SetTabButton(string type, List<string> imageReference)
        {
            for (int i = 0; i < MainPresentationModel.DISPLAY_ITEM_COUNT; i++)
            {
                if (imageReference[i].Equals(Constants.NULL_STRING))
                {
                    _buttonDictionary[type][i].Enabled = false;
                    _buttonDictionary[type][i].BackgroundImage = null;
                }else
                {
                    _buttonDictionary[type][i].Enabled = true;
                    _buttonDictionary[type][i].BackgroundImage = new Bitmap(Constants.IMAGE_FILE_PATH + imageReference[i]);
                }
            }
        }

        //bubbling item button click event
        private void ClickItem(object sender, EventArgs e)
        {
            const string RETURN_CHAR = "\n";
            string senderTag = ((Button)sender).Tag.ToString();
            string id = _viewModel.UpdateCurrentItemByTag(senderTag);
            this._descriptionBox.Text = _itemInfo.GetItemName(id) + RETURN_CHAR + _itemInfo.GetItemDescription(id);
            this._itemPrice.Text = ITEM_PRICE_STRING + _itemInfo.GetItemPrice(id).ToString(Constants.NUMBER_BREAK_KEY_WORD) + MONEY_UNIT;
            this._itemStock.Text = STOCK_LEFT_STRING + _itemInfo.GetItemStock(id).ToString();
            this._addToCart.Enabled = _viewModel.IsAddToCartEnable();
        }

        //bubbling add_to_cart button click event
        private void AddToOrderClick(object sender, EventArgs e)
        {
            string id = _viewModel.GetCurrentItem();
            _itemOrder.AddToOrder(id);
            this._totalPrice.Text = TOTAL_PRICE_STRING + _itemOrder.GetTotalPrice().ToString(Constants.NUMBER_BREAK_KEY_WORD) + MONEY_UNIT;
            //string[] orderRow = { "", _itemInfo.GetItemName(id), _itemInfo.GetItemTypeName(id), _itemInfo.GetItemPrice(id).ToString(Constants.NUMBER_BREAK_KEY_WORD),1.ToString(), _itemInfo.GetItemPrice(id).ToString(Constants.NUMBER_BREAK_KEY_WORD) };
            this._orderList.Rows.Add(this._viewModel.GetItemRowInfo(id));
            this._addToCart.Enabled = _viewModel.IsAddToCartEnable();
            this._checkOut.Enabled = _itemOrder.IsCheckOutEnable();
        }

        //handel tabindex change 
        private void HandleTabIndexChanged(object sender, TabControlEventArgs e)
        {
            this.UpdatePageIndicator();
            this.UpdatePageButtonStatus();
            this.ClearItemInfo();
        }

        //update page indicator data
        private void UpdatePageIndicator()
        {
            this._pageIndicate.Text = _viewModel.GetCurrentAndTotalPage(this._itemTab.SelectedTab.Name);
        }

        //change page button enable status
        private void UpdatePageButtonStatus()
        {
            int tabIndex = this._itemTab.SelectedIndex;
            this._previousPage.Enabled = _viewModel.IsPreviousPageEnable(this._itemTab.SelectedTab.Name);
            this._nextPage.Enabled = _viewModel.IsNextPageEnable(this._itemTab.SelectedTab.Name);
        }

        //change page
        private void ClickNextPage(object sender, EventArgs e)
        {
            string type = this._itemTab.SelectedTab.Name;
            _viewModel.ChangeToNextPage(type);
            this.UpdatePageIndicator();
            this.UpdatePageButtonStatus();
            this.SetTabButton(type, _viewModel.GetItemImageByType(type));
            this.ClearItemInfo();
        }

        //change page
        private void ClickPreviousPage(object sender, EventArgs e)
        {
            string type = this._itemTab.SelectedTab.Name;
            _viewModel.ChangeToPreviousPage(type);
            this.UpdatePageIndicator();
            this.UpdatePageButtonStatus();
            this.SetTabButton(type, _viewModel.GetItemImageByType(type));
            this.ClearItemInfo();
        }

        //hangdle order record delete
        private void DeleteOrderRecord(int index)
        {
            _itemOrder.DeleteFromOrder(index);
            this._orderList.Rows.RemoveAt(index);
            this._totalPrice.Text = TOTAL_PRICE_STRING + _itemOrder.GetTotalPrice().ToString(Constants.NUMBER_BREAK_KEY_WORD) + MONEY_UNIT;
            this._addToCart.Enabled = _viewModel.IsAddToCartEnable();
            this._checkOut.Enabled = _itemOrder.IsCheckOutEnable();
        }

        //handle cell click event
        private void ClickCellContent(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                this.DeleteOrderRecord(e.RowIndex);
            }
        }

        //handle cell click event
        private void ChangeQuantity(object sender, DataGridViewCellEventArgs e)
        {
            const int QUANTITY_INDEX = 4;
            const int TOTAL_PRICE_INDEX = 5;
            if (e.ColumnIndex == QUANTITY_INDEX)
            {
                int newQuantity = int.Parse(this._orderList.Rows[e.RowIndex].Cells[QUANTITY_INDEX].Value.ToString());
                int result = _itemOrder.UpdateQuantity(e.RowIndex, newQuantity);
                if (newQuantity != result)
                {
                    const string STOCK_STATUS = "庫存狀態";
                    const string STOCK_NOT_ENOUGH = "庫存不足";
                    MessageBox.Show(STOCK_NOT_ENOUGH, STOCK_STATUS);
                }
                this._orderList.Rows[e.RowIndex].Cells[QUANTITY_INDEX].Value = result.ToString();
                this._orderList.Rows[e.RowIndex].Cells[TOTAL_PRICE_INDEX].Value = _itemOrder.GetItemTotalPrice(e.RowIndex).ToString(Constants.NUMBER_BREAK_KEY_WORD);
                this._totalPrice.Text = TOTAL_PRICE_STRING + _itemOrder.GetTotalPrice().ToString(Constants.NUMBER_BREAK_KEY_WORD) + MONEY_UNIT;
            }
        }

        //stock update event handeler
        private void UpdateStockEvent()
        {
            this._itemStock.Text = STOCK_LEFT_STRING + _itemInfo.GetItemStock(_viewModel.GetCurrentItem()).ToString();
            this._addToCart.Enabled = _viewModel.IsAddToCartEnable();
        }

        //start checkout
        private void ClickCheckOut(object sender, EventArgs e)
        {
            DialogResult result = _paymentDialog.ShowDialog();
            if (result == DialogResult.Yes)
            {
                this._orderList.Rows.Clear();
                this._itemOrder.ProceedCheckOut();
                this._totalPrice.Text = TOTAL_PRICE_STRING + _itemOrder.GetTotalPrice().ToString(Constants.NUMBER_BREAK_KEY_WORD) + MONEY_UNIT;
            }
        }

        //draw delete image to data grid
        private void SetDeleteImageGrid(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
                Image image = Image.FromFile(DELETE_ICON_PATH);
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                int w = image.Width >> 1;
                int h = image.Height >> 1;
                var x = e.CellBounds.Left + ((e.CellBounds.Width - w) >> 1);
                var y = e.CellBounds.Top + ((e.CellBounds.Height - h) >> 1);
                e.Graphics.DrawImage(image, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        //clear item info
        private void ClearItemInfo()
        {
            this._descriptionBox.Text = "";
            this._itemStock.Text = STOCK_LEFT_STRING;
            this._itemPrice.Text = ITEM_PRICE_STRING;
            this._addToCart.Enabled = false;
            this._viewModel.ClearCurrentClickedItem();
        }

        //initial item tab
        private void InitialItemTab()
        {
            foreach (string type in this._typeInfo.GetTypeList())
            {
                TabPage tabPage = new TabPage();
                tabPage.Name = type;
                tabPage.Text = _typeInfo.GetTypeName(type);
                tabPage.Padding = new Padding(PADDING);
                tabPage.Margin = new Padding(PADDING);
                List<Button> buttonList = new List<Button>();
                for (int i = 0 ; i < MainPresentationModel.DISPLAY_ITEM_COUNT ; i++)
                {
                    Button button = this.CreateButton(type, i);
                    tabPage.Controls.Add(button);
                    buttonList.Add(button);
                }
                this._itemTab.Controls.Add(tabPage);
                this._buttonDictionary.Add(type, buttonList);
            }
        }

        //new button
        private Button CreateButton(string type, int number)
        {
            const int X_BASE = 5;
            const int Y_BASE = 4;
            const int X_DELTA = 167;
            const int Y_DELTA = 141;
            const int WIDTH = 142;
            const int HEIGHT = 127;
            const int DIVIDER = 3;
            const string DASH = "_";
            Button button = new Button();
            button.BackgroundImageLayout = ImageLayout.Stretch;
            button.Name = type + number.ToString();
            button.Tag = type + DASH + number.ToString();
            button.Location = new Point(X_BASE + (X_DELTA * (number % DIVIDER)), Y_BASE + (Y_DELTA * (number / DIVIDER)));
            button.Size = new Size(WIDTH, HEIGHT);
            button.Padding = new Padding(PADDING);
            button.Click += this.ClickItem;
            return button;
        }

        //initial all item button
        private void InitialAllItemButton()
        {
            foreach (string type in this._typeInfo.GetTypeList())
            {
                this.SetTabButton(type, _viewModel.GetItemImageByType(type));
            }
        }
    }
}
