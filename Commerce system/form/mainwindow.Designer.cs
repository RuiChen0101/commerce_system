namespace Commerce_system{
    partial class MainWindow{
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing){
            if (disposing && (components != null)){
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent(){
            this._itemTab = new System.Windows.Forms.TabControl();
            this._descriptionBox = new System.Windows.Forms.RichTextBox();
            this._itemGroup = new System.Windows.Forms.GroupBox();
            this._nextPage = new System.Windows.Forms.Button();
            this._previousPage = new System.Windows.Forms.Button();
            this._pageIndicate = new System.Windows.Forms.Label();
            this._pageLabel = new System.Windows.Forms.Label();
            this._addToCart = new System.Windows.Forms.Button();
            this._itemInfoGroup = new System.Windows.Forms.GroupBox();
            this._itemStock = new System.Windows.Forms.Label();
            this._itemPrice = new System.Windows.Forms.Label();
            this._orderList = new System.Windows.Forms.DataGridView();
            this._orderedItemDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this._orderedItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderedItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderedItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._quantity = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
            this._itemTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._totalPrice = new System.Windows.Forms.Label();
            this._checkOut = new System.Windows.Forms.Button();
            this._itemGroup.SuspendLayout();
            this._itemInfoGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._orderList)).BeginInit();
            this.SuspendLayout();
            // 
            // _itemTab
            // 
            this._itemTab.Location = new System.Drawing.Point(4, 20);
            this._itemTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._itemTab.Name = "_itemTab";
            this._itemTab.SelectedIndex = 0;
            this._itemTab.Size = new System.Drawing.Size(494, 298);
            this._itemTab.TabIndex = 0;
            this._itemTab.Selected += new System.Windows.Forms.TabControlEventHandler(this.HandleTabIndexChanged);
            // 
            // _descriptionBox
            // 
            this._descriptionBox.DetectUrls = false;
            this._descriptionBox.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._descriptionBox.Location = new System.Drawing.Point(6, 21);
            this._descriptionBox.Name = "_descriptionBox";
            this._descriptionBox.ReadOnly = true;
            this._descriptionBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this._descriptionBox.Size = new System.Drawing.Size(299, 94);
            this._descriptionBox.TabIndex = 1;
            this._descriptionBox.Text = "";
            // 
            // _itemGroup
            // 
            this._itemGroup.Controls.Add(this._nextPage);
            this._itemGroup.Controls.Add(this._previousPage);
            this._itemGroup.Controls.Add(this._pageIndicate);
            this._itemGroup.Controls.Add(this._pageLabel);
            this._itemGroup.Controls.Add(this._addToCart);
            this._itemGroup.Controls.Add(this._itemInfoGroup);
            this._itemGroup.Controls.Add(this._itemTab);
            this._itemGroup.Location = new System.Drawing.Point(13, 12);
            this._itemGroup.Margin = new System.Windows.Forms.Padding(0);
            this._itemGroup.Name = "_itemGroup";
            this._itemGroup.Size = new System.Drawing.Size(511, 511);
            this._itemGroup.TabIndex = 2;
            this._itemGroup.TabStop = false;
            this._itemGroup.Text = "商品";
            // 
            // _nextPage
            // 
            this._nextPage.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._nextPage.Image = global::Commerce_system.Properties.Resources.arrow_forward;
            this._nextPage.Location = new System.Drawing.Point(193, 470);
            this._nextPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._nextPage.Name = "_nextPage";
            this._nextPage.Size = new System.Drawing.Size(60, 30);
            this._nextPage.TabIndex = 6;
            this._nextPage.UseVisualStyleBackColor = true;
            this._nextPage.Click += new System.EventHandler(this.ClickNextPage);
            // 
            // _previousPage
            // 
            this._previousPage.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._previousPage.Image = global::Commerce_system.Properties.Resources.arrow_back;
            this._previousPage.Location = new System.Drawing.Point(127, 470);
            this._previousPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._previousPage.Name = "_previousPage";
            this._previousPage.Size = new System.Drawing.Size(60, 30);
            this._previousPage.TabIndex = 5;
            this._previousPage.UseVisualStyleBackColor = true;
            this._previousPage.Click += new System.EventHandler(this.ClickPreviousPage);
            // 
            // _pageIndicate
            // 
            this._pageIndicate.AutoSize = true;
            this._pageIndicate.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._pageIndicate.Location = new System.Drawing.Point(77, 472);
            this._pageIndicate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._pageIndicate.Name = "_pageIndicate";
            this._pageIndicate.Size = new System.Drawing.Size(47, 28);
            this._pageIndicate.TabIndex = 4;
            this._pageIndicate.Text = "1/1";
            // 
            // _pageLabel
            // 
            this._pageLabel.AutoSize = true;
            this._pageLabel.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._pageLabel.Location = new System.Drawing.Point(8, 472);
            this._pageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._pageLabel.Name = "_pageLabel";
            this._pageLabel.Size = new System.Drawing.Size(68, 28);
            this._pageLabel.TabIndex = 3;
            this._pageLabel.Text = "Page:";
            // 
            // _addToCart
            // 
            this._addToCart.Image = global::Commerce_system.Properties.Resources.add_shopping_cart;
            this._addToCart.Location = new System.Drawing.Point(411, 468);
            this._addToCart.Name = "_addToCart";
            this._addToCart.Size = new System.Drawing.Size(88, 37);
            this._addToCart.TabIndex = 2;
            this._addToCart.UseVisualStyleBackColor = true;
            this._addToCart.Click += new System.EventHandler(this.AddToOrderClick);
            // 
            // _itemInfoGroup
            // 
            this._itemInfoGroup.Controls.Add(this._itemStock);
            this._itemInfoGroup.Controls.Add(this._itemPrice);
            this._itemInfoGroup.Controls.Add(this._descriptionBox);
            this._itemInfoGroup.Location = new System.Drawing.Point(9, 336);
            this._itemInfoGroup.Name = "_itemInfoGroup";
            this._itemInfoGroup.Size = new System.Drawing.Size(490, 126);
            this._itemInfoGroup.TabIndex = 1;
            this._itemInfoGroup.TabStop = false;
            this._itemInfoGroup.Text = "商品介紹";
            // 
            // _itemStock
            // 
            this._itemStock.AutoSize = true;
            this._itemStock.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._itemStock.Location = new System.Drawing.Point(311, 38);
            this._itemStock.Name = "_itemStock";
            this._itemStock.Size = new System.Drawing.Size(90, 24);
            this._itemStock.TabIndex = 3;
            this._itemStock.Text = "庫存數量:";
            // 
            // _itemPrice
            // 
            this._itemPrice.AutoSize = true;
            this._itemPrice.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._itemPrice.Location = new System.Drawing.Point(311, 91);
            this._itemPrice.Name = "_itemPrice";
            this._itemPrice.Size = new System.Drawing.Size(52, 24);
            this._itemPrice.TabIndex = 2;
            this._itemPrice.Text = "單價:";
            // 
            // _orderList
            // 
            this._orderList.AllowUserToAddRows = false;
            this._orderList.AllowUserToDeleteRows = false;
            this._orderList.AllowUserToResizeColumns = false;
            this._orderList.AllowUserToResizeRows = false;
            this._orderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._orderList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this._orderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._orderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._orderedItemDelete,
            this._orderedItemName,
            this._orderedItemType,
            this._orderedItemPrice,
            this._quantity,
            this._itemTotalPrice});
            this._orderList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this._orderList.Location = new System.Drawing.Point(539, 32);
            this._orderList.Name = "_orderList";
            this._orderList.RowHeadersVisible = false;
            this._orderList.RowTemplate.Height = 30;
            this._orderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._orderList.Size = new System.Drawing.Size(533, 442);
            this._orderList.TabIndex = 3;
            this._orderList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickCellContent);
            this._orderList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChangeQuantity);
            this._orderList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.SetDeleteImageGrid);
            // 
            // _orderedItemDelete
            // 
            this._orderedItemDelete.FillWeight = 40F;
            this._orderedItemDelete.HeaderText = "刪除";
            this._orderedItemDelete.Name = "_orderedItemDelete";
            this._orderedItemDelete.ReadOnly = true;
            this._orderedItemDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // _orderedItemName
            // 
            this._orderedItemName.HeaderText = "商品名稱";
            this._orderedItemName.Name = "_orderedItemName";
            this._orderedItemName.ReadOnly = true;
            this._orderedItemName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._orderedItemName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _orderedItemType
            // 
            this._orderedItemType.FillWeight = 80F;
            this._orderedItemType.HeaderText = "商品類別";
            this._orderedItemType.Name = "_orderedItemType";
            this._orderedItemType.ReadOnly = true;
            this._orderedItemType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._orderedItemType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _orderedItemPrice
            // 
            this._orderedItemPrice.FillWeight = 65F;
            this._orderedItemPrice.HeaderText = "單價";
            this._orderedItemPrice.Name = "_orderedItemPrice";
            this._orderedItemPrice.ReadOnly = true;
            this._orderedItemPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._orderedItemPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _quantity
            // 
            this._quantity.FillWeight = 50F;
            this._quantity.HeaderText = "數量";
            this._quantity.Name = "_quantity";
            this._quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // _itemTotalPrice
            // 
            this._itemTotalPrice.FillWeight = 65F;
            this._itemTotalPrice.HeaderText = "總價";
            this._itemTotalPrice.Name = "_itemTotalPrice";
            this._itemTotalPrice.ReadOnly = true;
            this._itemTotalPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._itemTotalPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _totalPrice
            // 
            this._totalPrice.AutoSize = true;
            this._totalPrice.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._totalPrice.Location = new System.Drawing.Point(536, 494);
            this._totalPrice.Name = "_totalPrice";
            this._totalPrice.Size = new System.Drawing.Size(87, 24);
            this._totalPrice.TabIndex = 3;
            this._totalPrice.Text = "總價: 0元";
            // 
            // _checkOut
            // 
            this._checkOut.Enabled = false;
            this._checkOut.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._checkOut.Location = new System.Drawing.Point(984, 490);
            this._checkOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._checkOut.Name = "_checkOut";
            this._checkOut.Size = new System.Drawing.Size(87, 39);
            this._checkOut.TabIndex = 4;
            this._checkOut.Text = "訂購";
            this._checkOut.UseVisualStyleBackColor = true;
            this._checkOut.Click += new System.EventHandler(this.ClickCheckOut);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 542);
            this.Controls.Add(this._checkOut);
            this.Controls.Add(this._totalPrice);
            this.Controls.Add(this._orderList);
            this.Controls.Add(this._itemGroup);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(1100, 581);
            this.MinimumSize = new System.Drawing.Size(1100, 581);
            this.Name = "MainWindow";
            this.Text = "mainWindow";
            this._itemGroup.ResumeLayout(false);
            this._itemGroup.PerformLayout();
            this._itemInfoGroup.ResumeLayout(false);
            this._itemInfoGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._orderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl _itemTab;
        private System.Windows.Forms.RichTextBox _descriptionBox;
        private System.Windows.Forms.GroupBox _itemGroup;
        private System.Windows.Forms.GroupBox _itemInfoGroup;
        private System.Windows.Forms.Button _addToCart;
        private System.Windows.Forms.Label _itemPrice;
        private System.Windows.Forms.DataGridView _orderList;
        private System.Windows.Forms.Label _totalPrice;
        private System.Windows.Forms.Label _pageLabel;
        private System.Windows.Forms.Label _pageIndicate;
        private System.Windows.Forms.Button _nextPage;
        private System.Windows.Forms.Button _previousPage;
        private System.Windows.Forms.Button _checkOut;
        private System.Windows.Forms.Label _itemStock;
        private System.Windows.Forms.DataGridViewButtonColumn _orderedItemDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn _orderedItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _orderedItemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn _orderedItemPrice;
        private DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn _quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn _itemTotalPrice;
    }
}
