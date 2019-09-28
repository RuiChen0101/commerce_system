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

        private const string ITEM_PRICE_STRING = "單價: ";
        private const string TOTAL_PRICE_STRING = "總價: ";
        private const string MONEY_UNIT = "元";
        private const string BACK_SLASH = "/";

        private Dictionary<string, List<Button>> _buttonDictionary = new Dictionary<string, List<Button>>();

        //default constructor
        public MainWindow(ItemInfo itemInfo, ItemOrder itemOrder, MainViewModel viewModel)
        {
            InitializeComponent();
            this.InitialButtonDictionary();
            this._itemInfo = itemInfo;
            this._itemOrder = itemOrder;
            this._viewModel = viewModel;
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
            const char BREAK_CHAR = '_';
            const string RETURN_CHAR = "\n";
            string senderTag = ((Button)sender).Tag.ToString();
            string[] idData = senderTag.Split(BREAK_CHAR);
            _viewModel.UpdateCurrentItem(idData[0], int.Parse(idData[1]) - 1);
            string id = _viewModel.GetCurrentItem();
            this._descriptionBox.Text = _itemInfo.GetItemName(id) + RETURN_CHAR + _itemInfo.GetItemDescription(id);
            this._itemPrice.Text = ITEM_PRICE_STRING + _itemInfo.GetItemPrice(id).ToString(Constants.NUMBER_BREAK_KEY_WORD) + MONEY_UNIT;
        }

        //bubbling add_to_cart button click event
        private void AddToOrderClick(object sender, EventArgs e)
        {
            string id = _viewModel.GetCurrentItem();
            _itemOrder.AddToOrder(id);
            this._totalPrice.Text = TOTAL_PRICE_STRING + _itemOrder.GetTotalPrice().ToString(Constants.NUMBER_BREAK_KEY_WORD) + MONEY_UNIT;
            string[] orderRow = { "null", _itemInfo.GetItemName(id), _itemInfo.GetItemTypeName(id), _itemInfo.GetItemPrice(id).ToString(Constants.NUMBER_BREAK_KEY_WORD) };
            this._orderList.Rows.Add(orderRow);
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

        //handel tabindex change 
        private void HandleTabIndexChanged(object sender, TabControlEventArgs e)
        {
            this.UpdatePageIndicator();
            this.UpdatePageButtonStatus();
        }

        //update page indicator data
        private void UpdatePageIndicator()
        {
            Tuple<int, int> pageData = _viewModel.GetCurrentAndTotalPage(_itemInfo.GetTypeList()[this._itemTab.SelectedIndex]);
            this._pageIndicate.Text = pageData.Item1.ToString() + BACK_SLASH + pageData.Item2.ToString();
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

        //initialize button dictionary
        private void InitialButtonDictionary()
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
            _buttonDictionary.Add(ItemInfo.TYPE_BOARD, new List<Button>
            {
                this._boardItem1,
                this._boardItem2,
                this._boardItem3,
                this._boardItem4,
                this._boardItem5,
                this._boardItem6,
            });
            _buttonDictionary.Add(ItemInfo.TYPE_MEMORY, new List<Button>
            {
                this._memoryItem1,
                this._memoryItem2,
                this._memoryItem3,
                this._memoryItem4,
                this._memoryItem5,
                this._memoryItem6,
            });
            _buttonDictionary.Add(ItemInfo.TYPE_DRIVE, new List<Button>
            {
                this._driveItem1,
                this._driveItem2,
                this._driveItem3,
                this._driveItem4,
                this._driveItem5,
                this._driveItem6,
            });
            _buttonDictionary.Add(ItemInfo.TYPE_CARD, new List<Button>
            {
                this._cardItem1,
                this._cardItem2,
                this._cardItem3,
                this._cardItem4,
                this._cardItem5,
                this._cardItem6,
            });
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
