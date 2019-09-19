using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_system{
    public partial class MainWindow : Form{
        private Dictionary<string, List<Button>> btnDict = new Dictionary<string, List<Button>>();
        private const string imgFilePath = ".\\img\\";

        public event EventHandler onItemClick;
        public event EventHandler onAddToCartClick;

        public MainWindow(){
            InitializeComponent();
            this.initBtnDict();
        }

        public void setDesc(string desc){
            this.description.Text = desc;
        }

        public void setItemPrice(string price){
            this.item_price.Text = "單價: " + price;
        }

        public void setTotalPrice(string price){
            this.total_price.Text = "總價: " + price;
        }

        public void addNewOrderTableRow(string [] row){
            this.order_list.Rows.Add(row);
        }

        public void setTabBtn(string type, List<string> imgRef){
            for(int i = 0; i < 6; i++){
                if (imgRef[i].Equals("null")){
                    btnDict[type][i].Enabled = false;
                    btnDict[type][i].BackgroundImage=null;
                }else{
                    btnDict[type][i].Enabled = true;
                    btnDict[type][i].BackgroundImage = new Bitmap(imgFilePath+ imgRef[i]);
                }
            }
        }

        private void itemClick(object sender, EventArgs e){
            EventHandler handler = onItemClick;
            handler?.Invoke(sender, e);
        }

        private void addToCartClick(object sender, EventArgs e){
            EventHandler handler = onAddToCartClick;
            handler?.Invoke(sender, e);
        }

        private void initBtnDict(){
            btnDict.Add("cpu", new List<Button> {
                this.cpu_item1,
                this.cpu_item2,
                this.cpu_item3,
                this.cpu_item4,
                this.cpu_item5,
                this.cpu_item6,
            });
            btnDict.Add("mb", new List<Button> {
                this.mb_item1,
                this.mb_item2,
                this.mb_item3,
                this.mb_item4,
                this.mb_item5,
                this.mb_item6,
            });
            btnDict.Add("mem", new List<Button> {
                this.mem_item1,
                this.mem_item2,
                this.mem_item3,
                this.mem_item4,
                this.mem_item5,
                this.mem_item6,
            });
            btnDict.Add("hdd", new List<Button> {
                this.hdd_item1,
                this.hdd_item2,
                this.hdd_item3,
                this.hdd_item4,
                this.hdd_item5,
                this.hdd_item6,
            });
            btnDict.Add("gpu", new List<Button> {
                this.gpu_item1,
                this.gpu_item2,
                this.gpu_item3,
                this.gpu_item4,
                this.gpu_item5,
                this.gpu_item6,
            });
            btnDict.Add("set", new List<Button> {
                this.set_item1,
                this.set_item2,
                this.set_item3,
                this.set_item4,
                this.set_item5,
                this.set_item6,
            });
        }
    }
}
