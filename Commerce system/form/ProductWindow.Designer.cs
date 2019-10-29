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
            this._productList = new System.Windows.Forms.ListBox();
            this._createProduct = new System.Windows.Forms.Button();
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
            this._productSave = new System.Windows.Forms.Button();
            this._categoryTabPage = new System.Windows.Forms.TabPage();
            this._tab.SuspendLayout();
            this._productTabPage.SuspendLayout();
            this._productEditGroupBox.SuspendLayout();
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
            this._tab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._tab.Name = "_tab";
            this._tab.SelectedIndex = 0;
            this._tab.Size = new System.Drawing.Size(1147, 720);
            this._tab.TabIndex = 2;
            // 
            // _productTabPage
            // 
            this._productTabPage.Controls.Add(this._productList);
            this._productTabPage.Controls.Add(this._createProduct);
            this._productTabPage.Controls.Add(this._productEditGroupBox);
            this._productTabPage.Location = new System.Drawing.Point(4, 28);
            this._productTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._productTabPage.Name = "_productTabPage";
            this._productTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._productTabPage.Size = new System.Drawing.Size(1139, 688);
            this._productTabPage.TabIndex = 0;
            this._productTabPage.Text = "商品管理";
            this._productTabPage.UseVisualStyleBackColor = true;
            // 
            // _productList
            // 
            this._productList.FormattingEnabled = true;
            this._productList.ItemHeight = 19;
            this._productList.Location = new System.Drawing.Point(8, 8);
            this._productList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._productList.Name = "_productList";
            this._productList.Size = new System.Drawing.Size(331, 612);
            this._productList.TabIndex = 3;
            this._productList.SelectedIndexChanged += new System.EventHandler(this.ChangeListIndex);
            // 
            // _createProduct
            // 
            this._createProduct.Location = new System.Drawing.Point(8, 634);
            this._createProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._createProduct.Name = "_createProduct";
            this._createProduct.Size = new System.Drawing.Size(332, 42);
            this._createProduct.TabIndex = 2;
            this._createProduct.Text = "新增商品";
            this._createProduct.UseVisualStyleBackColor = true;
            this._createProduct.Click += new System.EventHandler(this.ClickCreateProduct);
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
            this._productEditGroupBox.Controls.Add(this._productSave);
            this._productEditGroupBox.Location = new System.Drawing.Point(348, 8);
            this._productEditGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._productEditGroupBox.Name = "_productEditGroupBox";
            this._productEditGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._productEditGroupBox.Size = new System.Drawing.Size(780, 669);
            this._productEditGroupBox.TabIndex = 1;
            this._productEditGroupBox.TabStop = false;
            this._productEditGroupBox.Text = "編輯商品";
            // 
            // _itemDescription
            // 
            this._itemDescription.Location = new System.Drawing.Point(17, 309);
            this._itemDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._itemDescription.Name = "_itemDescription";
            this._itemDescription.Size = new System.Drawing.Size(753, 309);
            this._itemDescription.TabIndex = 12;
            this._itemDescription.Text = "";
            this._itemDescription.TextChanged += new System.EventHandler(this.ChangeFieldText);
            // 
            // _openFile
            // 
            this._openFile.Location = new System.Drawing.Point(551, 201);
            this._openFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this._itemImageReference.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._itemImageReference.Name = "_itemImageReference";
            this._itemImageReference.Size = new System.Drawing.Size(351, 27);
            this._itemImageReference.TabIndex = 10;
            this._itemImageReference.TextChanged += new System.EventHandler(this.ChangeFieldText);
            // 
            // _itemType
            // 
            this._itemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._itemType.FormattingEnabled = true;
            this._itemType.ImeMode = System.Windows.Forms.ImeMode.Off;
            this._itemType.Location = new System.Drawing.Point(545, 126);
            this._itemType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._itemType.Name = "_itemType";
            this._itemType.Size = new System.Drawing.Size(160, 27);
            this._itemType.TabIndex = 9;
            this._itemType.TextChanged += new System.EventHandler(this.ChangeFieldText);
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
            this._itemPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._itemPrice.Name = "_itemPrice";
            this._itemPrice.Size = new System.Drawing.Size(199, 27);
            this._itemPrice.TabIndex = 7;
            this._itemPrice.TextChanged += new System.EventHandler(this.ChangeFieldText);
            this._itemPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumberInput);
            // 
            // _itemName
            // 
            this._itemName.ImeMode = System.Windows.Forms.ImeMode.Off;
            this._itemName.Location = new System.Drawing.Point(157, 56);
            this._itemName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._itemName.Name = "_itemName";
            this._itemName.Size = new System.Drawing.Size(444, 27);
            this._itemName.TabIndex = 6;
            this._itemName.TextChanged += new System.EventHandler(this.ChangeFieldText);
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
            // _productSave
            // 
            this._productSave.Location = new System.Drawing.Point(639, 626);
            this._productSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._productSave.Name = "_productSave";
            this._productSave.Size = new System.Drawing.Size(133, 35);
            this._productSave.TabIndex = 0;
            this._productSave.Text = "儲存";
            this._productSave.UseVisualStyleBackColor = true;
            this._productSave.Click += new System.EventHandler(this.ClickProductSave);
            // 
            // _categoryTabPage
            // 
            this._categoryTabPage.Location = new System.Drawing.Point(4, 28);
            this._categoryTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._categoryTabPage.Name = "_categoryTabPage";
            this._categoryTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._categoryTabPage.Size = new System.Drawing.Size(1139, 688);
            this._categoryTabPage.TabIndex = 1;
            this._categoryTabPage.Text = "類別管理";
            this._categoryTabPage.UseVisualStyleBackColor = true;
            // 
            // ProductWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 816);
            this.Controls.Add(this._tab);
            this.Controls.Add(this._productManagementSystemLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1194, 863);
            this.MinimumSize = new System.Drawing.Size(1194, 863);
            this.Name = "ProductWindow";
            this.Text = "ProductManagement";
            this._tab.ResumeLayout(false);
            this._productTabPage.ResumeLayout(false);
            this._productEditGroupBox.ResumeLayout(false);
            this._productEditGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _productManagementSystemLabel;
        private System.Windows.Forms.TabControl _tab;
        private System.Windows.Forms.TabPage _productTabPage;
        private System.Windows.Forms.Button _createProduct;
        private System.Windows.Forms.GroupBox _productEditGroupBox;
        private System.Windows.Forms.Button _productSave;
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
        private System.Windows.Forms.ListBox _productList;
    }
}