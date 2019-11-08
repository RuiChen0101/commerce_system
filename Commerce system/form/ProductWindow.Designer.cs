namespace Commerce_system
{
    partial class ProductWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._productManagementSystemLabel = new System.Windows.Forms.Label();
            this._tab = new System.Windows.Forms.TabControl();
            this._productTabPage = new System.Windows.Forms.TabPage();
            this._itemList = new System.Windows.Forms.ListBox();
            this._createItem = new System.Windows.Forms.Button();
            this._productEditGroupBox = new System.Windows.Forms.GroupBox();
            this._itemDescription = new System.Windows.Forms.RichTextBox();
            this._openFile = new System.Windows.Forms.Button();
            this._itemImageReference = new System.Windows.Forms.TextBox();
            this._itemType = new System.Windows.Forms.ComboBox();
            this._moneyUnitLabel = new System.Windows.Forms.Label();
            this._itemPrice = new System.Windows.Forms.TextBox();
            this._itemName = new System.Windows.Forms.TextBox();
            this._itemDescriptionLabel = new System.Windows.Forms.Label();
            this._itemImageReferenceLabel = new System.Windows.Forms.Label();
            this._itemTypeLabel = new System.Windows.Forms.Label();
            this._itemPriceLabel = new System.Windows.Forms.Label();
            this._itemNameLabel = new System.Windows.Forms.Label();
            this._itemSave = new System.Windows.Forms.Button();
            this._categoryTabPage = new System.Windows.Forms.TabPage();
            this._typeList = new System.Windows.Forms.ListBox();
            this._createType = new System.Windows.Forms.Button();
            this._typeEditGroupBox = new System.Windows.Forms.GroupBox();
            this._typeItemList = new System.Windows.Forms.ListBox();
            this._typeName = new System.Windows.Forms.TextBox();
            this._typeProductListLabel = new System.Windows.Forms.Label();
            this._typeNameLabel = new System.Windows.Forms.Label();
            this._typeSave = new System.Windows.Forms.Button();
            this._tab.SuspendLayout();
            this._productTabPage.SuspendLayout();
            this._productEditGroupBox.SuspendLayout();
            this._categoryTabPage.SuspendLayout();
            this._typeEditGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // _productManagementSystemLabel
            // 
            this._productManagementSystemLabel.AutoSize = true;
            this._productManagementSystemLabel.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._productManagementSystemLabel.Location = new System.Drawing.Point(372, 11);
            this._productManagementSystemLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._productManagementSystemLabel.Name = "_productManagementSystemLabel";
            this._productManagementSystemLabel.Size = new System.Drawing.Size(393, 76);
            this._productManagementSystemLabel.TabIndex = 1;
            this._productManagementSystemLabel.Text = "商品管理系統";
            // 
            // _tab
            // 
            this._tab.Controls.Add(this._productTabPage);
            this._tab.Controls.Add(this._categoryTabPage);
            this._tab.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._tab.Location = new System.Drawing.Point(16, 91);
            this._tab.Margin = new System.Windows.Forms.Padding(4);
            this._tab.Name = "_tab";
            this._tab.SelectedIndex = 0;
            this._tab.Size = new System.Drawing.Size(1147, 720);
            this._tab.TabIndex = 2;
            // 
            // _productTabPage
            // 
            this._productTabPage.Controls.Add(this._itemList);
            this._productTabPage.Controls.Add(this._createItem);
            this._productTabPage.Controls.Add(this._productEditGroupBox);
            this._productTabPage.Location = new System.Drawing.Point(4, 28);
            this._productTabPage.Margin = new System.Windows.Forms.Padding(4);
            this._productTabPage.Name = "_productTabPage";
            this._productTabPage.Padding = new System.Windows.Forms.Padding(4);
            this._productTabPage.Size = new System.Drawing.Size(1139, 688);
            this._productTabPage.TabIndex = 0;
            this._productTabPage.Text = "商品管理";
            this._productTabPage.UseVisualStyleBackColor = true;
            // 
            // _itemList
            // 
            this._itemList.FormattingEnabled = true;
            this._itemList.ItemHeight = 19;
            this._itemList.Location = new System.Drawing.Point(8, 8);
            this._itemList.Margin = new System.Windows.Forms.Padding(4);
            this._itemList.Name = "_itemList";
            this._itemList.Size = new System.Drawing.Size(331, 593);
            this._itemList.TabIndex = 3;
            this._itemList.SelectedIndexChanged += new System.EventHandler(this.ChangeListIndex);
            // 
            // _createItem
            // 
            this._createItem.Location = new System.Drawing.Point(8, 634);
            this._createItem.Margin = new System.Windows.Forms.Padding(4);
            this._createItem.Name = "_createItem";
            this._createItem.Size = new System.Drawing.Size(332, 42);
            this._createItem.TabIndex = 2;
            this._createItem.Text = "新增商品";
            this._createItem.UseVisualStyleBackColor = true;
            this._createItem.Click += new System.EventHandler(this.ClickCreateItem);
            // 
            // _productEditGroupBox
            // 
            this._productEditGroupBox.Controls.Add(this._itemDescription);
            this._productEditGroupBox.Controls.Add(this._openFile);
            this._productEditGroupBox.Controls.Add(this._itemImageReference);
            this._productEditGroupBox.Controls.Add(this._itemType);
            this._productEditGroupBox.Controls.Add(this._moneyUnitLabel);
            this._productEditGroupBox.Controls.Add(this._itemPrice);
            this._productEditGroupBox.Controls.Add(this._itemName);
            this._productEditGroupBox.Controls.Add(this._itemDescriptionLabel);
            this._productEditGroupBox.Controls.Add(this._itemImageReferenceLabel);
            this._productEditGroupBox.Controls.Add(this._itemTypeLabel);
            this._productEditGroupBox.Controls.Add(this._itemPriceLabel);
            this._productEditGroupBox.Controls.Add(this._itemNameLabel);
            this._productEditGroupBox.Controls.Add(this._itemSave);
            this._productEditGroupBox.Location = new System.Drawing.Point(348, 8);
            this._productEditGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this._productEditGroupBox.Name = "_productEditGroupBox";
            this._productEditGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this._productEditGroupBox.Size = new System.Drawing.Size(780, 669);
            this._productEditGroupBox.TabIndex = 1;
            this._productEditGroupBox.TabStop = false;
            this._productEditGroupBox.Text = "編輯商品";
            // 
            // _itemDescription
            // 
            this._itemDescription.ImeMode = System.Windows.Forms.ImeMode.Off;
            this._itemDescription.Location = new System.Drawing.Point(17, 309);
            this._itemDescription.Margin = new System.Windows.Forms.Padding(4);
            this._itemDescription.Name = "_itemDescription";
            this._itemDescription.Size = new System.Drawing.Size(753, 309);
            this._itemDescription.TabIndex = 12;
            this._itemDescription.Text = "";
            this._itemDescription.TextChanged += new System.EventHandler(this.ChangeItemFieldText);
            // 
            // _openFile
            // 
            this._openFile.Location = new System.Drawing.Point(551, 201);
            this._openFile.Margin = new System.Windows.Forms.Padding(4);
            this._openFile.Name = "_openFile";
            this._openFile.Size = new System.Drawing.Size(133, 35);
            this._openFile.TabIndex = 11;
            this._openFile.Text = "瀏覽";
            this._openFile.UseVisualStyleBackColor = true;
            this._openFile.Click += new System.EventHandler(this.ClickOpenFile);
            // 
            // _itemImageReference
            // 
            this._itemImageReference.ImeMode = System.Windows.Forms.ImeMode.Off;
            this._itemImageReference.Location = new System.Drawing.Point(183, 205);
            this._itemImageReference.Margin = new System.Windows.Forms.Padding(4);
            this._itemImageReference.Name = "_itemImageReference";
            this._itemImageReference.ReadOnly = true;
            this._itemImageReference.Size = new System.Drawing.Size(351, 27);
            this._itemImageReference.TabIndex = 10;
            this._itemImageReference.TextChanged += new System.EventHandler(this.ChangeItemFieldText);
            // 
            // _itemType
            // 
            this._itemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._itemType.FormattingEnabled = true;
            this._itemType.ImeMode = System.Windows.Forms.ImeMode.Off;
            this._itemType.Location = new System.Drawing.Point(545, 126);
            this._itemType.Margin = new System.Windows.Forms.Padding(4);
            this._itemType.Name = "_itemType";
            this._itemType.Size = new System.Drawing.Size(160, 27);
            this._itemType.TabIndex = 9;
            this._itemType.TextChanged += new System.EventHandler(this.ChangeItemFieldText);
            // 
            // _moneyUnitLabel
            // 
            this._moneyUnitLabel.AutoSize = true;
            this._moneyUnitLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._moneyUnitLabel.Location = new System.Drawing.Point(348, 128);
            this._moneyUnitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._moneyUnitLabel.Name = "_moneyUnitLabel";
            this._moneyUnitLabel.Size = new System.Drawing.Size(54, 25);
            this._moneyUnitLabel.TabIndex = 8;
            this._moneyUnitLabel.Text = "NTD";
            // 
            // _itemPrice
            // 
            this._itemPrice.ImeMode = System.Windows.Forms.ImeMode.Off;
            this._itemPrice.Location = new System.Drawing.Point(140, 126);
            this._itemPrice.Margin = new System.Windows.Forms.Padding(4);
            this._itemPrice.Name = "_itemPrice";
            this._itemPrice.Size = new System.Drawing.Size(199, 27);
            this._itemPrice.TabIndex = 7;
            this._itemPrice.TextChanged += new System.EventHandler(this.ChangeItemFieldText);
            this._itemPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumberInput);
            // 
            // _itemName
            // 
            this._itemName.ImeMode = System.Windows.Forms.ImeMode.Off;
            this._itemName.Location = new System.Drawing.Point(157, 56);
            this._itemName.Margin = new System.Windows.Forms.Padding(4);
            this._itemName.Name = "_itemName";
            this._itemName.Size = new System.Drawing.Size(444, 27);
            this._itemName.TabIndex = 6;
            this._itemName.TextChanged += new System.EventHandler(this.ChangeItemFieldText);
            // 
            // _itemDescriptionLabel
            // 
            this._itemDescriptionLabel.AutoSize = true;
            this._itemDescriptionLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._itemDescriptionLabel.Location = new System.Drawing.Point(12, 279);
            this._itemDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._itemDescriptionLabel.Name = "_itemDescriptionLabel";
            this._itemDescriptionLabel.Size = new System.Drawing.Size(113, 25);
            this._itemDescriptionLabel.TabIndex = 5;
            this._itemDescriptionLabel.Text = "商品介紹(*)";
            // 
            // _itemImageReferenceLabel
            // 
            this._itemImageReferenceLabel.AutoSize = true;
            this._itemImageReferenceLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._itemImageReferenceLabel.Location = new System.Drawing.Point(12, 205);
            this._itemImageReferenceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._itemImageReferenceLabel.Name = "_itemImageReferenceLabel";
            this._itemImageReferenceLabel.Size = new System.Drawing.Size(153, 25);
            this._itemImageReferenceLabel.TabIndex = 4;
            this._itemImageReferenceLabel.Text = "商品圖片路徑(*)";
            // 
            // _itemTypeLabel
            // 
            this._itemTypeLabel.AutoSize = true;
            this._itemTypeLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._itemTypeLabel.Location = new System.Drawing.Point(415, 128);
            this._itemTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._itemTypeLabel.Name = "_itemTypeLabel";
            this._itemTypeLabel.Size = new System.Drawing.Size(113, 25);
            this._itemTypeLabel.TabIndex = 3;
            this._itemTypeLabel.Text = "商品類別(*)";
            // 
            // _itemPriceLabel
            // 
            this._itemPriceLabel.AutoSize = true;
            this._itemPriceLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._itemPriceLabel.Location = new System.Drawing.Point(12, 128);
            this._itemPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._itemPriceLabel.Name = "_itemPriceLabel";
            this._itemPriceLabel.Size = new System.Drawing.Size(113, 25);
            this._itemPriceLabel.TabIndex = 2;
            this._itemPriceLabel.Text = "商品價格(*)";
            // 
            // _itemNameLabel
            // 
            this._itemNameLabel.AutoSize = true;
            this._itemNameLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._itemNameLabel.Location = new System.Drawing.Point(12, 56);
            this._itemNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._itemNameLabel.Name = "_itemNameLabel";
            this._itemNameLabel.Size = new System.Drawing.Size(113, 25);
            this._itemNameLabel.TabIndex = 1;
            this._itemNameLabel.Text = "商品名稱(*)";
            // 
            // _itemSave
            // 
            this._itemSave.Location = new System.Drawing.Point(639, 626);
            this._itemSave.Margin = new System.Windows.Forms.Padding(4);
            this._itemSave.Name = "_itemSave";
            this._itemSave.Size = new System.Drawing.Size(133, 35);
            this._itemSave.TabIndex = 0;
            this._itemSave.Text = "儲存";
            this._itemSave.UseVisualStyleBackColor = true;
            this._itemSave.Click += new System.EventHandler(this.ClickItemSave);
            // 
            // _categoryTabPage
            // 
            this._categoryTabPage.Controls.Add(this._typeList);
            this._categoryTabPage.Controls.Add(this._createType);
            this._categoryTabPage.Controls.Add(this._typeEditGroupBox);
            this._categoryTabPage.Location = new System.Drawing.Point(4, 28);
            this._categoryTabPage.Margin = new System.Windows.Forms.Padding(4);
            this._categoryTabPage.Name = "_categoryTabPage";
            this._categoryTabPage.Padding = new System.Windows.Forms.Padding(4);
            this._categoryTabPage.Size = new System.Drawing.Size(1139, 688);
            this._categoryTabPage.TabIndex = 1;
            this._categoryTabPage.Text = "類別管理";
            this._categoryTabPage.UseVisualStyleBackColor = true;
            // 
            // _typeList
            // 
            this._typeList.FormattingEnabled = true;
            this._typeList.ItemHeight = 19;
            this._typeList.Location = new System.Drawing.Point(9, 10);
            this._typeList.Margin = new System.Windows.Forms.Padding(4);
            this._typeList.Name = "_typeList";
            this._typeList.Size = new System.Drawing.Size(331, 593);
            this._typeList.TabIndex = 6;
            this._typeList.SelectedIndexChanged += new System.EventHandler(this.ChangeTypeIndex);
            // 
            // _createType
            // 
            this._createType.Location = new System.Drawing.Point(9, 630);
            this._createType.Margin = new System.Windows.Forms.Padding(4);
            this._createType.Name = "_createType";
            this._createType.Size = new System.Drawing.Size(332, 42);
            this._createType.TabIndex = 5;
            this._createType.Text = "新增類別";
            this._createType.UseVisualStyleBackColor = true;
            this._createType.Click += new System.EventHandler(this.ClickCreateType);
            // 
            // _typeEditGroupBox
            // 
            this._typeEditGroupBox.Controls.Add(this._typeItemList);
            this._typeEditGroupBox.Controls.Add(this._typeName);
            this._typeEditGroupBox.Controls.Add(this._typeProductListLabel);
            this._typeEditGroupBox.Controls.Add(this._typeNameLabel);
            this._typeEditGroupBox.Controls.Add(this._typeSave);
            this._typeEditGroupBox.Location = new System.Drawing.Point(349, 10);
            this._typeEditGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this._typeEditGroupBox.Name = "_typeEditGroupBox";
            this._typeEditGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this._typeEditGroupBox.Size = new System.Drawing.Size(780, 669);
            this._typeEditGroupBox.TabIndex = 4;
            this._typeEditGroupBox.TabStop = false;
            this._typeEditGroupBox.Text = "編輯";
            // 
            // _typeItemList
            // 
            this._typeItemList.FormattingEnabled = true;
            this._typeItemList.ItemHeight = 19;
            this._typeItemList.Location = new System.Drawing.Point(17, 266);
            this._typeItemList.Margin = new System.Windows.Forms.Padding(4);
            this._typeItemList.Name = "_typeItemList";
            this._typeItemList.Size = new System.Drawing.Size(755, 327);
            this._typeItemList.TabIndex = 7;
            // 
            // _typeName
            // 
            this._typeName.ImeMode = System.Windows.Forms.ImeMode.Off;
            this._typeName.Location = new System.Drawing.Point(256, 88);
            this._typeName.Margin = new System.Windows.Forms.Padding(4);
            this._typeName.Name = "_typeName";
            this._typeName.Size = new System.Drawing.Size(444, 27);
            this._typeName.TabIndex = 6;
            this._typeName.TextChanged += new System.EventHandler(this.ChangeTypeFieldText);
            // 
            // _typeProductListLabel
            // 
            this._typeProductListLabel.AutoSize = true;
            this._typeProductListLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._typeProductListLabel.Location = new System.Drawing.Point(12, 220);
            this._typeProductListLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._typeProductListLabel.Name = "_typeProductListLabel";
            this._typeProductListLabel.Size = new System.Drawing.Size(112, 25);
            this._typeProductListLabel.TabIndex = 5;
            this._typeProductListLabel.Text = "類別內商品";
            // 
            // _typeNameLabel
            // 
            this._typeNameLabel.AutoSize = true;
            this._typeNameLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._typeNameLabel.Location = new System.Drawing.Point(111, 88);
            this._typeNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._typeNameLabel.Name = "_typeNameLabel";
            this._typeNameLabel.Size = new System.Drawing.Size(113, 25);
            this._typeNameLabel.TabIndex = 1;
            this._typeNameLabel.Text = "類別名稱(*)";
            // 
            // _typeSave
            // 
            this._typeSave.Enabled = false;
            this._typeSave.Location = new System.Drawing.Point(639, 626);
            this._typeSave.Margin = new System.Windows.Forms.Padding(4);
            this._typeSave.Name = "_typeSave";
            this._typeSave.Size = new System.Drawing.Size(133, 35);
            this._typeSave.TabIndex = 0;
            this._typeSave.Text = "新增";
            this._typeSave.UseVisualStyleBackColor = true;
            this._typeSave.Click += new System.EventHandler(this.ClickTypeSave);
            // 
            // ProductWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 813);
            this.Controls.Add(this._tab);
            this.Controls.Add(this._productManagementSystemLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1195, 860);
            this.MinimumSize = new System.Drawing.Size(1195, 860);
            this.Name = "ProductWindow";
            this.Text = "ProductManagement";
            this._tab.ResumeLayout(false);
            this._productTabPage.ResumeLayout(false);
            this._productEditGroupBox.ResumeLayout(false);
            this._productEditGroupBox.PerformLayout();
            this._categoryTabPage.ResumeLayout(false);
            this._typeEditGroupBox.ResumeLayout(false);
            this._typeEditGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _productManagementSystemLabel;
        private System.Windows.Forms.TabControl _tab;
        private System.Windows.Forms.TabPage _productTabPage;
        private System.Windows.Forms.Button _createItem;
        private System.Windows.Forms.GroupBox _productEditGroupBox;
        private System.Windows.Forms.Button _itemSave;
        private System.Windows.Forms.TabPage _categoryTabPage;
        private System.Windows.Forms.Label _itemImageReferenceLabel;
        private System.Windows.Forms.Label _itemTypeLabel;
        private System.Windows.Forms.Label _itemPriceLabel;
        private System.Windows.Forms.Label _itemNameLabel;
        private System.Windows.Forms.Label _itemDescriptionLabel;
        private System.Windows.Forms.Button _openFile;
        private System.Windows.Forms.TextBox _itemImageReference;
        private System.Windows.Forms.ComboBox _itemType;
        private System.Windows.Forms.Label _moneyUnitLabel;
        private System.Windows.Forms.TextBox _itemPrice;
        private System.Windows.Forms.TextBox _itemName;
        private System.Windows.Forms.RichTextBox _itemDescription;
        private System.Windows.Forms.ListBox _itemList;
        private System.Windows.Forms.ListBox _typeList;
        private System.Windows.Forms.Button _createType;
        private System.Windows.Forms.GroupBox _typeEditGroupBox;
        private System.Windows.Forms.TextBox _typeName;
        private System.Windows.Forms.Label _typeProductListLabel;
        private System.Windows.Forms.Label _typeNameLabel;
        private System.Windows.Forms.Button _typeSave;
        private System.Windows.Forms.ListBox _typeItemList;
    }
}