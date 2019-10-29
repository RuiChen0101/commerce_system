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
        private const string EDIT_MODE_STRING = "編輯商品";
        private const string CREATE_MODE_STRING = "新增商品";
        private const string SAVE_MODE_STRING = "儲存商品";
        private const string CREATE_BUTTON_STRING = "新增";
        private const string SAVE_BUTTON_STRING = "儲存";

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
            _itemInfo._itemCreateEvent += this.HandleItemUpdateEvent;
            _itemInfo._itemDataUpdateEvent += this.HandleItemUpdateEvent;
        }

        //set up item list
        private void SetUpList()
        {
            this._productList.Items.Clear();
            foreach (string id in _itemInfo.GetTotalIdList())
            {
                this._productList.Items.Add(_itemInfo.GetItemName(id));
            }
        }

        //set up type
        private void SetUpTypeComboBox()
        {
            foreach (string typeName in _typeInfo.GetTypeNameList())
            {
                this._itemType.Items.Add(typeName);
            }
        }

        //handle item update
        private void HandleItemUpdateEvent()
        {
            this.SetUpList();
        }

        //clear form
        private void ClearForm()
        {
            this._productEditGroupBox.Text = EDIT_MODE_STRING;
            this._productSave.Text = SAVE_BUTTON_STRING;
            this._itemName.Text = "";
            this._itemPrice.Text = "";
            this._itemType.Text = "";
            this._itemType.SelectedIndex = -1;
            this._itemImageReference.Text = "";
            this._itemDescription.Text = "";
            this._productSave.Enabled = false;
        }

        //on create product click
        private void ClickCreateProduct(object sender, EventArgs e)
        {
            this.ClearForm();
            this._createProduct.Enabled = false;
            this._productSave.Text = CREATE_BUTTON_STRING;
            this._productEditGroupBox.Text = CREATE_MODE_STRING;
            _viewModel.SetEditIndex(ProductPresentationModel.CREATE_INDEX);
        }

        //on product save click
        private void ClickProductSave(object sender, EventArgs e)
        {
            _viewModel.StartSave();
            this.ClearForm();
        }

        //on open file click
        private void ClickOpenFile(object sender, EventArgs e)
        {
            const string FILTER = "image files (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp|All files (*.*)|*.*";
            const int FILTER_INDEX = 1;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = FILTER;
            openFileDialog.FilterIndex = FILTER_INDEX;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this._itemImageReference.Text = _viewModel.HandleFileOpen(openFileDialog.FileName);
            }
        }

        //number input only
        private void CheckNumberInput(object sender, KeyPressEventArgs e)
        {
            e.Handled = !_viewModel.IsNumberInput(e.KeyChar);
        }

        //list index change
        private void ChangeListIndex(object sender, EventArgs e)
        {
            this._productEditGroupBox.Text = EDIT_MODE_STRING;
            this._productSave.Text = SAVE_BUTTON_STRING;
            this._createProduct.Enabled = true;
            _viewModel.SetEditIndex(this._productList.SelectedIndex);
            string id = _itemInfo.GetTotalIdList()[this._productList.SelectedIndex];
            this.UpdateForm(id);
            this._productSave.Enabled = false;
        }

        //update from
        private void UpdateForm(string id)
        {
            this._itemName.Text = _itemInfo.GetItemName(id);
            this._itemPrice.Text = _itemInfo.GetItemPrice(id).ToString();
            this._itemType.Text = _itemInfo.GetItemTypeName(id);
            this._itemImageReference.Text = _itemInfo.GetItemImageReference(id);
            this._itemDescription.Text = _itemInfo.GetItemDescription(id);
        }

        //field text change
        private void ChangeFieldText(object sender, EventArgs e)
        {
            _viewModel.SetFieldName(this._itemName.Text);
            _viewModel.SetFieldPrice(this._itemPrice.Text);
            _viewModel.SetFieldType(this._itemType.Text);
            _viewModel.SetFieldImage(this._itemImageReference.Text);
            _viewModel.SetFieldDescription(this._itemDescription.Text);
            this._productSave.Enabled = _viewModel.IsSaveEnable();
        }
    }
}