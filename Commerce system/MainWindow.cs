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
        public event EventHandler _onItemClick;
        public event EventHandler _onAddToOrderClick;

        private const string IMAGE_FILE_PATH = ".\\img\\";
        private const string ITEM_PRICE_STRING = "單價: ";
        private const string TOTAL_PRICE_STRING = "總價: ";

        private Dictionary<string, List<Button>> _buttonDictionary = new Dictionary<string, List<Button>>();

        //default constructor
        public MainWindow()
        {
            InitializeComponent();
            this.InitialButtonDictionary();
        }

        //show description
        public void SetDescription(string description)
        {
            this._descriptionBox.Text = description;
        }

        //show item price
        public void SetItemPrice(string price)
        {
            this._itemPrice.Text = ITEM_PRICE_STRING + price;
        }

        //show total price
        public void SetTotalPrice(string price)
        {
            this._totalPrice.Text = TOTAL_PRICE_STRING + price;
        }

        //add new row for order table
        public void AddNewOrderTableRow(string [] row)
        {
            this._orderList.Rows.Add(row);
        }

        //setting item button
        public void SetTabButton(string type, List<string> imageReference)
        {
            for (int i = 0; i < MainViewLoader.DISPLAY_ITEM_COUNT; i++)
            {
                if (imageReference[i].Equals(Constants.NULL_STRING))
                {
                    _buttonDictionary[type][i].Enabled = false;
                    _buttonDictionary[type][i].BackgroundImage = null;
                }else
                {
                    _buttonDictionary[type][i].Enabled = true;
                    _buttonDictionary[type][i].BackgroundImage = new Bitmap(IMAGE_FILE_PATH + imageReference[i]);
                }
            }
        }

        //bubbling item button click event
        private void ClickItem(object sender, EventArgs e)
        {
            EventHandler handler = this._onItemClick;
            handler.Invoke(sender, e);
        }

        //bubbling add_to_cart button click event
        private void AddToOrderClick(object sender, EventArgs e)
        {
            EventHandler handler = this._onAddToOrderClick;
            handler.Invoke(sender, e);
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
