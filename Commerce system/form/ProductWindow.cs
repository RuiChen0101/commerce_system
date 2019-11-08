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
        private const string ITEM_EDIT_MODE_STRING = "編輯商品";
        private const string ITEM_CREATE_MODE_STRING = "新增商品";
        private const string ITEM_SAVE_MODE_STRING = "儲存商品";
        private const string TYPE_EDIT_MODE_STRING = "編輯";
        private const string TYPE_CREATE_MODE_STRING = "新增類別";

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
            this.SetUpItemList();
            this.SetUpTypeList();
            this.SetUpTypeComboBox();
            this.ClearForm();
            _itemInfo._itemCreateEvent += this.HandleItemUpdateEvent;
            _itemInfo._itemDataUpdateEvent += this.HandleItemUpdateEvent;
            _typeInfo._typesUpdateEvent += this.HandleTypeUpdateEvent;
        }

        //set up item list
        private void SetUpItemList()
        {
            this._itemList.Items.Clear();
            foreach (string id in _itemInfo.GetTotalIdList())
            {
                this._itemList.Items.Add(_itemInfo.GetItemName(id));
            }
        }

        //set up type list
        private void SetUpTypeList()
        {
            this._typeList.Items.Clear();
            foreach (string id in _typeInfo.GetTypeList())
            {
                this._typeList.Items.Add(_typeInfo.GetTypeName(id));
            }
        }

        //set up type
        private void SetUpTypeComboBox()
        {
            this._itemType.Items.Clear();
            foreach (string typeName in _typeInfo.GetTypeNameList())
            {
                this._itemType.Items.Add(typeName);
            }
        }

        //handle item update
        private void HandleItemUpdateEvent()
        {
            this.SetUpItemList();
        }

        //handle type update
        private void HandleTypeUpdateEvent()
        {
            this.SetUpTypeList();
            this.SetUpTypeComboBox();
        }

        //clear form
        private void ClearForm()
        {
            this._productEditGroupBox.Text = ITEM_EDIT_MODE_STRING;
            this._itemSave.Text = SAVE_BUTTON_STRING;
            this._typeEditGroupBox.Text = TYPE_EDIT_MODE_STRING;
            this._typeItemList.Items.Clear();
            this._itemName.Text = "";
            this._itemPrice.Text = "";
            this._itemType.Text = "";
            this._itemType.SelectedIndex = -1;
            this._itemImageReference.Text = "";
            this._itemDescription.Text = "";
            this._typeName.Text = "";
            this._typeSave.Enabled = false;
            this._itemSave.Enabled = false;
        }

        //on create item click
        private void ClickCreateItem(object sender, EventArgs e)
        {
            this.ClearForm();
            this._createItem.Enabled = false;
            this._itemSave.Text = CREATE_BUTTON_STRING;
            this._productEditGroupBox.Text = ITEM_CREATE_MODE_STRING;
            _viewModel.SetItemEditIndex(ProductPresentationModel.CREATE_INDEX);
        }

        //on create type click
        private void ClickCreateType(object sender, EventArgs e)
        {
            this.ClearForm();
            this._createType.Enabled = false;
            this._typeEditGroupBox.Text = TYPE_CREATE_MODE_STRING;
            _viewModel.SetTypeEditIndex(ProductPresentationModel.CREATE_INDEX);
        }

        //on item save click
        private void ClickItemSave(object sender, EventArgs e)
        {
            _viewModel.StartItemSave();
            this.ClearForm();
            this._createItem.Enabled = false;
        }

        //on type save click
        private void ClickTypeSave(object sender, EventArgs e)
        {
            _viewModel.StartTypeSave();
            this.ClearForm();
            this._createType.Enabled = false;
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

        //product list index change
        private void ChangeListIndex(object sender, EventArgs e)
        {
            this._productEditGroupBox.Text = ITEM_EDIT_MODE_STRING;
            this._itemSave.Text = SAVE_BUTTON_STRING;
            this._createItem.Enabled = true;
            _viewModel.SetItemEditIndex(this._itemList.SelectedIndex);
            string id = _itemInfo.GetTotalIdList()[this._itemList.SelectedIndex];
            this.UpdateItemForm(id);
            this._itemSave.Enabled = false;
        }

        //type list index change
        private void ChangeTypeIndex(object sender, EventArgs e)
        {
            this._typeEditGroupBox.Text = TYPE_EDIT_MODE_STRING;
            this._createType.Enabled = true;
            _viewModel.SetTypeEditIndex(this._typeList.SelectedIndex);
            string id = _typeInfo.GetTypeList()[this._typeList.SelectedIndex];
            this.UpdateTypeForm(id);
            this._typeSave.Enabled = false;
        }

        //update type from
        private void UpdateTypeForm(string id)
        {
            this._typeName.Text = _typeInfo.GetTypeName(id);
            this._typeItemList.Items.Clear();
            foreach (string itemId in _itemInfo.GetItemIdListByType(id))
            {
                this._typeItemList.Items.Add(_itemInfo.GetItemName(itemId));
            }
        }

        //update Item from
        private void UpdateItemForm(string id)
        {
            this._itemName.Text = _itemInfo.GetItemName(id);
            this._itemPrice.Text = _itemInfo.GetItemPrice(id).ToString();
            this._itemType.Text = _itemInfo.GetItemTypeName(id);
            this._itemImageReference.Text = _itemInfo.GetItemImageReference(id);
            this._itemDescription.Text = _itemInfo.GetItemDescription(id);
        }

        //item field text change
        private void ChangeItemFieldText(object sender, EventArgs e)
        {
            _viewModel.SetItemFieldName(this._itemName.Text);
            _viewModel.SetItemFieldPrice(this._itemPrice.Text);
            _viewModel.SetItemFieldType(this._itemType.Text);
            _viewModel.SetItemFieldImage(this._itemImageReference.Text);
            _viewModel.SetItemFieldDescription(this._itemDescription.Text);
            this._itemSave.Enabled = _viewModel.IsItemSaveEnable();
        }

        //type field text change
        private void ChangeTypeFieldText(object sender, EventArgs e)
        {
            _viewModel.SetTypeFieldName(this._typeName.Text);
            this._typeSave.Enabled = _viewModel.IsTypeSaveEnable();
        }
    }
}