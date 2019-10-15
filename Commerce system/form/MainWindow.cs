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
        private MainViewModel _viewModel;
        private PaymentDialog _paymentDialog;

        private const string ITEM_PRICE_STRING = "單價: ";
        private const string TOTAL_PRICE_STRING = "總價: ";
        private const string STOCK_LEFT_STRING = "庫存數量: ";
        private const string MONEY_UNIT = "元";
        private const string DELETE_ICON_PATH = ".\\img\\icon\\delete.png";

        private Dictionary<string, List<Button>> _buttonDictionary = new Dictionary<string, List<Button>>();

        //default constructor
        public MainWindow(ItemInfo itemInfo, ItemOrder itemOrder)
        {
            InitializeComponent();
            this.InitialProcessorButtonDictionary();
            this.InitialBoardButtonDictionary();
            this.InitialMemoryButtonDictionary();
            this.InitialDriveButtonDictionary();
            this.InitialCardButtonDictionary();
            this.InitialSetButtonDictionary();
            this._itemInfo = itemInfo;
            this._itemOrder = itemOrder;
            this._viewModel = new MainViewModel(_itemInfo,_itemOrder);
            this._paymentDialog = new PaymentDialog();
            this.InitialAllItemButton();
            this.HandleTabIndexChanged(null, null);
        }

        //setting item button
        private void SetTabButton(string type, List<string> imageReference)
        {
            for (int i = 0; i < MainViewModel.DISPLAY_ITEM_COUNT; i++)
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
            string[] orderRow = { "", _itemInfo.GetItemName(id), _itemInfo.GetItemTypeName(id), _itemInfo.GetItemPrice(id).ToString(Constants.NUMBER_BREAK_KEY_WORD),"1","100" };
            this._orderList.Rows.Add(orderRow);
            this._addToCart.Enabled = _viewModel.IsAddToCartEnable();
        }

        //handel tabindex change 
        private void HandleTabIndexChanged(object sender, TabControlEventArgs e)
        {
            this.UpdatePageIndicator();
            this.UpdatePageButtonStatus();
        }

        //update page indicator data
        private void UpdatePageIndicator()
        {
            this._pageIndicate.Text = _viewModel.GetCurrentAndTotalPage(_itemInfo.GetTypeList()[this._itemTab.SelectedIndex]);
        }

        //change page button enable status
        private void UpdatePageButtonStatus()
        {
            int tabIndex = this._itemTab.SelectedIndex;
            this._previousPage.Enabled = _viewModel.IsPreviousPageEnable(_itemInfo.GetTypeList()[this._itemTab.SelectedIndex]);
            this._nextPage.Enabled = _viewModel.IsNextPageEnable(_itemInfo.GetTypeList()[this._itemTab.SelectedIndex]);
        }

        //change page
        private void ClickNextPage(object sender, EventArgs e)
        {
            string type = _itemInfo.GetTypeList()[this._itemTab.SelectedIndex];
            _viewModel.ChangeToNextPage(type);
            this.UpdatePageIndicator();
            this.UpdatePageButtonStatus();
            this.SetTabButton(type, _viewModel.GetItemImageByType(type));
        }

        //change page
        private void ClickPreviousPage(object sender, EventArgs e)
        {
            string type = _itemInfo.GetTypeList()[this._itemTab.SelectedIndex];
            _viewModel.ChangeToPreviousPage(type);
            this.UpdatePageIndicator();
            this.UpdatePageButtonStatus();
            this.SetTabButton(type, _viewModel.GetItemImageByType(type));
        }

        //hangdle order record delete
        private void DeleteOrderRecord(int index)
        {
            _itemOrder.DeleteFromOrder(index);
            this._orderList.Rows.RemoveAt(index);
            this._totalPrice.Text = TOTAL_PRICE_STRING + _itemOrder.GetTotalPrice().ToString(Constants.NUMBER_BREAK_KEY_WORD) + MONEY_UNIT;
            this._addToCart.Enabled = _viewModel.IsAddToCartEnable();
        }

        //handle cell click event
        private void ClickCellContent(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                this.DeleteOrderRecord(e.RowIndex);
            }
        }

        //start checkout
        private void ClickCheckOut(object sender, EventArgs e)
        {
            DialogResult result = _paymentDialog.ShowDialog();
            if (result == DialogResult.Yes)
            {
                this._orderList.Rows.Clear();
                this._itemOrder.ClearOrder();
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

        //initial all item button
        private void InitialAllItemButton()
        {
            this.SetTabButton(ItemInfo.TYPE_PROCESSOR, _viewModel.GetItemImageByType(ItemInfo.TYPE_PROCESSOR));
            this.SetTabButton(ItemInfo.TYPE_BOARD, _viewModel.GetItemImageByType(ItemInfo.TYPE_BOARD));
            this.SetTabButton(ItemInfo.TYPE_MEMORY, _viewModel.GetItemImageByType(ItemInfo.TYPE_MEMORY));
            this.SetTabButton(ItemInfo.TYPE_CARD, _viewModel.GetItemImageByType(ItemInfo.TYPE_CARD));
            this.SetTabButton(ItemInfo.TYPE_DRIVE, _viewModel.GetItemImageByType(ItemInfo.TYPE_DRIVE));
            this.SetTabButton(ItemInfo.TYPE_SET, _viewModel.GetItemImageByType(ItemInfo.TYPE_SET));
        }

        //initialize processor button dictionary
        private void InitialProcessorButtonDictionary()
        {
            _buttonDictionary.Add(ItemInfo.TYPE_PROCESSOR, new List<Button>
            {
                this._processorItem1,
                this._processorItem2,
                this._processorItem3,
                this._processorItem4,
                this._processorItem5,
                this._processorItem6,
            });
        }

        //initialize board button dictionary
        private void InitialBoardButtonDictionary()
        {
            _buttonDictionary.Add(ItemInfo.TYPE_BOARD, new List<Button>
            {
                this._boardItem1,
                this._boardItem2,
                this._boardItem3,
                this._boardItem4,
                this._boardItem5,
                this._boardItem6,
            });
        }

        //initialize memory button dictionary
        private void InitialMemoryButtonDictionary()
        {
            _buttonDictionary.Add(ItemInfo.TYPE_MEMORY, new List<Button>
            {
                this._memoryItem1,
                this._memoryItem2,
                this._memoryItem3,
                this._memoryItem4,
                this._memoryItem5,
                this._memoryItem6,
            });
        }

        //initialize drive button dictionary
        private void InitialDriveButtonDictionary()
        {
            _buttonDictionary.Add(ItemInfo.TYPE_DRIVE, new List<Button>
            {
                this._driveItem1,
                this._driveItem2,
                this._driveItem3,
                this._driveItem4,
                this._driveItem5,
                this._driveItem6,
            });
        }

        //initialize card button dictionary
        private void InitialCardButtonDictionary()
        {
            _buttonDictionary.Add(ItemInfo.TYPE_CARD, new List<Button>
            {
                this._cardItem1,
                this._cardItem2,
                this._cardItem3,
                this._cardItem4,
                this._cardItem5,
                this._cardItem6,
            });
        }

        //initialize set button dictionary
        private void InitialSetButtonDictionary()
        {
            _buttonDictionary.Add(ItemInfo.TYPE_SET, new List<Button>
            {
                this._setItem1,
                this._setItem2,
                this._setItem3,
                this._setItem4,
                this._setItem5,
                this._setItem6,
            });
        }
    }
}
