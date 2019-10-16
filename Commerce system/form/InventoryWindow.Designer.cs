namespace Commerce_system
{
    partial class InventoryWindow
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
            this._inventorySystemLabel = new System.Windows.Forms.Label();
            this._inventoryList = new System.Windows.Forms.DataGridView();
            this._orderedItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderedItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderedItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._inventoryStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._inventorySupply = new System.Windows.Forms.DataGridViewButtonColumn();
            this._itemPictureLabel = new System.Windows.Forms.Label();
            this._itemDescription = new System.Windows.Forms.Label();
            this._descriptionBox = new System.Windows.Forms.RichTextBox();
            this._itemPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._inventoryList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._itemPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // _inventorySystemLabel
            // 
            this._inventorySystemLabel.AutoSize = true;
            this._inventorySystemLabel.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._inventorySystemLabel.Location = new System.Drawing.Point(303, 9);
            this._inventorySystemLabel.Name = "_inventorySystemLabel";
            this._inventorySystemLabel.Size = new System.Drawing.Size(315, 61);
            this._inventorySystemLabel.TabIndex = 0;
            this._inventorySystemLabel.Text = "庫存管理系統";
            // 
            // _inventoryList
            // 
            this._inventoryList.AllowUserToAddRows = false;
            this._inventoryList.AllowUserToDeleteRows = false;
            this._inventoryList.AllowUserToResizeColumns = false;
            this._inventoryList.AllowUserToResizeRows = false;
            this._inventoryList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._inventoryList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this._inventoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._inventoryList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._orderedItemName,
            this._orderedItemType,
            this._orderedItemPrice,
            this._inventoryStock,
            this._inventorySupply});
            this._inventoryList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this._inventoryList.ImeMode = System.Windows.Forms.ImeMode.Off;
            this._inventoryList.Location = new System.Drawing.Point(12, 73);
            this._inventoryList.MultiSelect = false;
            this._inventoryList.Name = "_inventoryList";
            this._inventoryList.RowHeadersVisible = false;
            this._inventoryList.RowTemplate.Height = 30;
            this._inventoryList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._inventoryList.Size = new System.Drawing.Size(606, 576);
            this._inventoryList.TabIndex = 4;
            this._inventoryList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickCellContent);
            this._inventoryList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.SetSupplyImageGrid);
            this._inventoryList.SelectionChanged += new System.EventHandler(this.ChangeSelection);
            // 
            // _orderedItemName
            // 
            this._orderedItemName.FillWeight = 120F;
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
            this._orderedItemPrice.FillWeight = 75F;
            this._orderedItemPrice.HeaderText = "單價";
            this._orderedItemPrice.Name = "_orderedItemPrice";
            this._orderedItemPrice.ReadOnly = true;
            this._orderedItemPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._orderedItemPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _inventoryStock
            // 
            this._inventoryStock.FillWeight = 75F;
            this._inventoryStock.HeaderText = "數量";
            this._inventoryStock.Name = "_inventoryStock";
            this._inventoryStock.ReadOnly = true;
            this._inventoryStock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _inventorySupply
            // 
            this._inventorySupply.FillWeight = 50F;
            this._inventorySupply.HeaderText = "補貨";
            this._inventorySupply.Name = "_inventorySupply";
            this._inventorySupply.ReadOnly = true;
            this._inventorySupply.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // _itemPictureLabel
            // 
            this._itemPictureLabel.AutoSize = true;
            this._itemPictureLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._itemPictureLabel.Location = new System.Drawing.Point(624, 73);
            this._itemPictureLabel.Name = "_itemPictureLabel";
            this._itemPictureLabel.Size = new System.Drawing.Size(73, 20);
            this._itemPictureLabel.TabIndex = 5;
            this._itemPictureLabel.Text = "商品圖片";
            // 
            // _itemDescription
            // 
            this._itemDescription.AutoSize = true;
            this._itemDescription.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._itemDescription.Location = new System.Drawing.Point(624, 344);
            this._itemDescription.Name = "_itemDescription";
            this._itemDescription.Size = new System.Drawing.Size(73, 20);
            this._itemDescription.TabIndex = 6;
            this._itemDescription.Text = "商品描述";
            // 
            // _descriptionBox
            // 
            this._descriptionBox.DetectUrls = false;
            this._descriptionBox.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._descriptionBox.Location = new System.Drawing.Point(628, 367);
            this._descriptionBox.Name = "_descriptionBox";
            this._descriptionBox.ReadOnly = true;
            this._descriptionBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this._descriptionBox.Size = new System.Drawing.Size(299, 282);
            this._descriptionBox.TabIndex = 7;
            this._descriptionBox.Text = "";
            // 
            // _itemPicture
            // 
            this._itemPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._itemPicture.Location = new System.Drawing.Point(657, 96);
            this._itemPicture.Name = "_itemPicture";
            this._itemPicture.Size = new System.Drawing.Size(245, 245);
            this._itemPicture.TabIndex = 8;
            this._itemPicture.TabStop = false;
            // 
            // InventoryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 661);
            this.Controls.Add(this._itemPicture);
            this.Controls.Add(this._descriptionBox);
            this.Controls.Add(this._itemDescription);
            this.Controls.Add(this._itemPictureLabel);
            this.Controls.Add(this._inventoryList);
            this.Controls.Add(this._inventorySystemLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(964, 700);
            this.MinimumSize = new System.Drawing.Size(964, 700);
            this.Name = "InventoryWindow";
            this.Text = "InventoryWindow";
            ((System.ComponentModel.ISupportInitialize)(this._inventoryList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._itemPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _inventorySystemLabel;
        private System.Windows.Forms.DataGridView _inventoryList;
        private System.Windows.Forms.Label _itemPictureLabel;
        private System.Windows.Forms.Label _itemDescription;
        private System.Windows.Forms.RichTextBox _descriptionBox;
        private System.Windows.Forms.PictureBox _itemPicture;
        private System.Windows.Forms.DataGridViewTextBoxColumn _orderedItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _orderedItemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn _orderedItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn _inventoryStock;
        private System.Windows.Forms.DataGridViewButtonColumn _inventorySupply;
    }
}