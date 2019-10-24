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
            this._createProduct = new System.Windows.Forms.Button();
            this._productEditGroupBox = new System.Windows.Forms.GroupBox();
            this._itemDescription = new System.Windows.Forms.RichTextBox();
            this._openFile = new System.Windows.Forms.Button();
            this._itemImageReference = new System.Windows.Forms.TextBox();
            this._itemCategory = new System.Windows.Forms.ComboBox();
            this._moneyUnitLabel = new System.Windows.Forms.Label();
            this._itemPrice = new System.Windows.Forms.TextBox();
            this._itemName = new System.Windows.Forms.TextBox();
            this._itemDescriptionLabel = new System.Windows.Forms.Label();
            this._itemImageReferenceLabel = new System.Windows.Forms.Label();
            this._itemCategoryLabel = new System.Windows.Forms.Label();
            this._itemPriceLabel = new System.Windows.Forms.Label();
            this._itemNameLabel = new System.Windows.Forms.Label();
            this._productSave = new System.Windows.Forms.Button();
            this._productList = new System.Windows.Forms.ListView();
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
            this._productManagementSystemLabel.Location = new System.Drawing.Point(279, 9);
            this._productManagementSystemLabel.Name = "_productManagementSystemLabel";
            this._productManagementSystemLabel.Size = new System.Drawing.Size(315, 61);
            this._productManagementSystemLabel.TabIndex = 1;
            this._productManagementSystemLabel.Text = "商品管理系統";
            // 
            // _tab
            // 
            this._tab.Controls.Add(this._productTabPage);
            this._tab.Controls.Add(this._categoryTabPage);
            this._tab.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._tab.Location = new System.Drawing.Point(12, 73);
            this._tab.Name = "_tab";
            this._tab.SelectedIndex = 0;
            this._tab.Size = new System.Drawing.Size(860, 576);
            this._tab.TabIndex = 2;
            // 
            // _productTabPage
            // 
            this._productTabPage.Controls.Add(this._createProduct);
            this._productTabPage.Controls.Add(this._productEditGroupBox);
            this._productTabPage.Controls.Add(this._productList);
            this._productTabPage.Location = new System.Drawing.Point(4, 25);
            this._productTabPage.Name = "_productTabPage";
            this._productTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._productTabPage.Size = new System.Drawing.Size(852, 547);
            this._productTabPage.TabIndex = 0;
            this._productTabPage.Text = "商品管理";
            this._productTabPage.UseVisualStyleBackColor = true;
            // 
            // _createProduct
            // 
            this._createProduct.Location = new System.Drawing.Point(6, 507);
            this._createProduct.Name = "_createProduct";
            this._createProduct.Size = new System.Drawing.Size(249, 34);
            this._createProduct.TabIndex = 2;
            this._createProduct.Text = "新增商品";
            this._createProduct.UseVisualStyleBackColor = true;
            // 
            // _productEditGroupBox
            // 
            this._productEditGroupBox.Controls.Add(this._itemDescription);
            this._productEditGroupBox.Controls.Add(this._openFile);
            this._productEditGroupBox.Controls.Add(this._itemImageReference);
            this._productEditGroupBox.Controls.Add(this._itemCategory);
            this._productEditGroupBox.Controls.Add(this._moneyUnitLabel);
            this._productEditGroupBox.Controls.Add(this._itemPrice);
            this._productEditGroupBox.Controls.Add(this._itemName);
            this._productEditGroupBox.Controls.Add(this._itemDescriptionLabel);
            this._productEditGroupBox.Controls.Add(this._itemImageReferenceLabel);
            this._productEditGroupBox.Controls.Add(this._itemCategoryLabel);
            this._productEditGroupBox.Controls.Add(this._itemPriceLabel);
            this._productEditGroupBox.Controls.Add(this._itemNameLabel);
            this._productEditGroupBox.Controls.Add(this._productSave);
            this._productEditGroupBox.Location = new System.Drawing.Point(261, 6);
            this._productEditGroupBox.Name = "_productEditGroupBox";
            this._productEditGroupBox.Size = new System.Drawing.Size(585, 535);
            this._productEditGroupBox.TabIndex = 1;
            this._productEditGroupBox.TabStop = false;
            this._productEditGroupBox.Text = "編輯商品";
            // 
            // _itemDescription
            // 
            this._itemDescription.Location = new System.Drawing.Point(13, 247);
            this._itemDescription.Name = "_itemDescription";
            this._itemDescription.Size = new System.Drawing.Size(566, 248);
            this._itemDescription.TabIndex = 12;
            this._itemDescription.Text = "";
            // 
            // _openFile
            // 
            this._openFile.Location = new System.Drawing.Point(413, 161);
            this._openFile.Name = "_openFile";
            this._openFile.Size = new System.Drawing.Size(100, 28);
            this._openFile.TabIndex = 11;
            this._openFile.Text = "瀏覽";
            this._openFile.UseVisualStyleBackColor = true;
            // 
            // _itemImageReference
            // 
            this._itemImageReference.Location = new System.Drawing.Point(137, 164);
            this._itemImageReference.Name = "_itemImageReference";
            this._itemImageReference.Size = new System.Drawing.Size(264, 23);
            this._itemImageReference.TabIndex = 10;
            // 
            // _itemCategory
            // 
            this._itemCategory.FormattingEnabled = true;
            this._itemCategory.Location = new System.Drawing.Point(409, 101);
            this._itemCategory.Name = "_itemCategory";
            this._itemCategory.Size = new System.Drawing.Size(121, 24);
            this._itemCategory.TabIndex = 9;
            // 
            // _moneyUnitLabel
            // 
            this._moneyUnitLabel.AutoSize = true;
            this._moneyUnitLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._moneyUnitLabel.Location = new System.Drawing.Point(261, 102);
            this._moneyUnitLabel.Name = "_moneyUnitLabel";
            this._moneyUnitLabel.Size = new System.Drawing.Size(43, 20);
            this._moneyUnitLabel.TabIndex = 8;
            this._moneyUnitLabel.Text = "NTD";
            // 
            // _itemPrice
            // 
            this._itemPrice.Location = new System.Drawing.Point(105, 101);
            this._itemPrice.Name = "_itemPrice";
            this._itemPrice.Size = new System.Drawing.Size(150, 23);
            this._itemPrice.TabIndex = 7;
            // 
            // _itemName
            // 
            this._itemName.Location = new System.Drawing.Point(118, 45);
            this._itemName.Name = "_itemName";
            this._itemName.Size = new System.Drawing.Size(334, 23);
            this._itemName.TabIndex = 6;
            // 
            // _itemDescriptionLabel
            // 
            this._itemDescriptionLabel.AutoSize = true;
            this._itemDescriptionLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._itemDescriptionLabel.Location = new System.Drawing.Point(9, 223);
            this._itemDescriptionLabel.Name = "_itemDescriptionLabel";
            this._itemDescriptionLabel.Size = new System.Drawing.Size(90, 20);
            this._itemDescriptionLabel.TabIndex = 5;
            this._itemDescriptionLabel.Text = "商品介紹(*)";
            // 
            // _itemImageReferenceLabel
            // 
            this._itemImageReferenceLabel.AutoSize = true;
            this._itemImageReferenceLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._itemImageReferenceLabel.Location = new System.Drawing.Point(9, 164);
            this._itemImageReferenceLabel.Name = "_itemImageReferenceLabel";
            this._itemImageReferenceLabel.Size = new System.Drawing.Size(122, 20);
            this._itemImageReferenceLabel.TabIndex = 4;
            this._itemImageReferenceLabel.Text = "商品圖片路徑(*)";
            // 
            // _itemCategoryLabel
            // 
            this._itemCategoryLabel.AutoSize = true;
            this._itemCategoryLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._itemCategoryLabel.Location = new System.Drawing.Point(311, 102);
            this._itemCategoryLabel.Name = "_itemCategoryLabel";
            this._itemCategoryLabel.Size = new System.Drawing.Size(90, 20);
            this._itemCategoryLabel.TabIndex = 3;
            this._itemCategoryLabel.Text = "商品類別(*)";
            // 
            // _itemPriceLabel
            // 
            this._itemPriceLabel.AutoSize = true;
            this._itemPriceLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._itemPriceLabel.Location = new System.Drawing.Point(9, 102);
            this._itemPriceLabel.Name = "_itemPriceLabel";
            this._itemPriceLabel.Size = new System.Drawing.Size(90, 20);
            this._itemPriceLabel.TabIndex = 2;
            this._itemPriceLabel.Text = "商品價格(*)";
            // 
            // _itemNameLabel
            // 
            this._itemNameLabel.AutoSize = true;
            this._itemNameLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._itemNameLabel.Location = new System.Drawing.Point(9, 45);
            this._itemNameLabel.Name = "_itemNameLabel";
            this._itemNameLabel.Size = new System.Drawing.Size(90, 20);
            this._itemNameLabel.TabIndex = 1;
            this._itemNameLabel.Text = "商品名稱(*)";
            // 
            // _productSave
            // 
            this._productSave.Location = new System.Drawing.Point(479, 501);
            this._productSave.Name = "_productSave";
            this._productSave.Size = new System.Drawing.Size(100, 28);
            this._productSave.TabIndex = 0;
            this._productSave.Text = "儲存";
            this._productSave.UseVisualStyleBackColor = true;
            // 
            // _productList
            // 
            this._productList.HideSelection = false;
            this._productList.Location = new System.Drawing.Point(6, 6);
            this._productList.Name = "_productList";
            this._productList.Size = new System.Drawing.Size(249, 495);
            this._productList.TabIndex = 0;
            this._productList.UseCompatibleStateImageBehavior = false;
            // 
            // _categoryTabPage
            // 
            this._categoryTabPage.Location = new System.Drawing.Point(4, 25);
            this._categoryTabPage.Name = "_categoryTabPage";
            this._categoryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._categoryTabPage.Size = new System.Drawing.Size(852, 547);
            this._categoryTabPage.TabIndex = 1;
            this._categoryTabPage.Text = "類別管理";
            this._categoryTabPage.UseVisualStyleBackColor = true;
            // 
            // ProductWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this._tab);
            this.Controls.Add(this._productManagementSystemLabel);
            this.MaximumSize = new System.Drawing.Size(900, 700);
            this.MinimumSize = new System.Drawing.Size(900, 700);
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
        private System.Windows.Forms.ListView _productList;
        private System.Windows.Forms.TabPage _categoryTabPage;
        private System.Windows.Forms.Label _itemImageReferenceLabel;
        private System.Windows.Forms.Label _itemCategoryLabel;
        private System.Windows.Forms.Label _itemPriceLabel;
        private System.Windows.Forms.Label _itemNameLabel;
        private System.Windows.Forms.Label _itemDescriptionLabel;
        private System.Windows.Forms.Button _openFile;
        private System.Windows.Forms.TextBox _itemImageReference;
        private System.Windows.Forms.ComboBox _itemCategory;
        private System.Windows.Forms.Label _moneyUnitLabel;
        private System.Windows.Forms.TextBox _itemPrice;
        private System.Windows.Forms.TextBox _itemName;
        private System.Windows.Forms.RichTextBox _itemDescription;
    }
}