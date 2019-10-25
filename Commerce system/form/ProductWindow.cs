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
    public partial class ProductWindow : Form
    {
        private ItemInfo _itemInfo;
        private TypeInfo _typeInfo;
        private ProductPresentationModel _viewModel;

        public ProductWindow(ItemInfo itemInfo, TypeInfo typeInfo)
        {
            InitializeComponent();
            this._itemInfo = itemInfo;
            this._typeInfo = typeInfo;
            this._viewModel = new ProductPresentationModel(this._itemInfo, this._typeInfo);
            this.SetUpList();
            this.SetUpTypeComboBox();
            this.ClearForm();
        }

        //set up item list
        private void SetUpList()
        {
            foreach (string id in _itemInfo.GetTotalIdList())
            {
                this._productList.Items.Add(_itemInfo.GetItemName(id));
            }
        }

        //set up type
        private void SetUpTypeComboBox()
        {
            foreach(string typeName in _typeInfo.GetTypeNameList())
            {
                this._itemType.Items.Add(typeName);
            }
        }

        //clear form
        private void ClearForm()
        {
            this._itemName.Text = "";
            this._itemPrice.Text = "";
            this._itemType.Text = "";
            this._itemImageReference.Text = "";
            this._productSave.Enabled = false;
        }

        //on create product click
        private void ClickCreateProduct(object sender, EventArgs e)
        {

        }

        //on product save click
        private void ClickProductSave(object sender, EventArgs e)
        {

        }

        //on open file click
        private void ClickOpenFile(object sender, EventArgs e)
        {

        }

        //number input only
        private void CheckNumberInput(object sender, KeyPressEventArgs e)
        {
            e.Handled = !_viewModel.IsNumberInput(e.KeyChar);
        }
    }
}