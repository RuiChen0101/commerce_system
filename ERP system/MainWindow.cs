using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_system
{
    public partial class MainWindow : Form
    {
        private Dictionary<string, List<Button>> _btnDict = new Dictionary<string, List<Button>>();
        private const string IMAGE_FILE_PATH = ".\\img\\";
        private const string ITEM_PRICE_STRING = "單價: ";
        private const string TOTAL_PRICE_STRING = "總價: ";

        public event EventHandler _onItemClick;
        public event EventHandler _onAddToOrderClick;

        //default constructor
        public MainWindow()
        {
            InitializeComponent();
            this.InitBtnDict();
        }

        //show description
        public void SetDesc(string desc)
        {
            this._descriptionBox.Text = desc;
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
        public void SetTabBtn(string type, List<string> imgRef)
        {
            for(int i = 0; i < 6; i++){
                if (imgRef[i].Equals(Constants.NULL_STRING))
                {
                    _btnDict[type][i].Enabled = false;
                    _btnDict[type][i].BackgroundImage=null;
                }else{
                    _btnDict[type][i].Enabled = true;
                    _btnDict[type][i].BackgroundImage = new Bitmap(IMAGE_FILE_PATH+ imgRef[i]);
                }
            }
        }

        //bubbling item button click event
        private void ItemClick(object sender, EventArgs e)
        {
            EventHandler handler = this._onItemClick;
            handler?.Invoke(sender, e);
        }

        //bubbling add_to_cart button click event
        private void AddToOrderClick(object sender, EventArgs e)
        {
            EventHandler handler = this._onAddToOrderClick;
            handler?.Invoke(sender, e);
        }

        //initialize button dictionary
        private void InitBtnDict()
        {
            _btnDict.Add("cpu", new List<Button>
            {
                this._cpuItem1,
                this._cpuItem2,
                this._cpuItem3,
                this._cpuItem4,
                this._cpuItem5,
                this._cpuItem6,
            });
            _btnDict.Add("mb", new List<Button>
            {
                this._mbItem1,
                this._mbItem2,
                this._mbItem3,
                this._mbItem4,
                this._mbItem5,
                this._mbItem6,
            });
            _btnDict.Add("mem", new List<Button>
            {
                this._memItem1,
                this._memItem2,
                this._memItem3,
                this._memItem4,
                this._memItem5,
                this._memItem6,
            });
            _btnDict.Add("hdd", new List<Button>
            {
                this._hddItem1,
                this._hddItem2,
                this._hddItem3,
                this._hddItem4,
                this._hddItem5,
                this._hddItem6,
            });
            _btnDict.Add("gpu", new List<Button>
            {
                this._gpuItem1,
                this._gpuItem2,
                this._gpuItem3,
                this._gpuItem4,
                this._gpuItem5,
                this._gpuItem6,
            });
            _btnDict.Add("set", new List<Button>
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
