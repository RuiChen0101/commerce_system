namespace Commerce_system
{
    partial class SupplyDialog
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
            this._supplyLabel = new System.Windows.Forms.Label();
            this._itemNameLabel = new System.Windows.Forms.Label();
            this._itemTypeLabel = new System.Windows.Forms.Label();
            this._itemPriceLabel = new System.Windows.Forms.Label();
            this._itemStockLabel = new System.Windows.Forms.Label();
            this._itemSupplyLabel = new System.Windows.Forms.Label();
            this._ok = new System.Windows.Forms.Button();
            this._cancel = new System.Windows.Forms.Button();
            this._itemStock = new System.Windows.Forms.Label();
            this._itemPrice = new System.Windows.Forms.Label();
            this._itemType = new System.Windows.Forms.Label();
            this._itemName = new System.Windows.Forms.Label();
            this._itemSupply = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _supplyLabel
            // 
            this._supplyLabel.AutoSize = true;
            this._supplyLabel.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._supplyLabel.Location = new System.Drawing.Point(121, 9);
            this._supplyLabel.Name = "_supplyLabel";
            this._supplyLabel.Size = new System.Drawing.Size(131, 47);
            this._supplyLabel.TabIndex = 0;
            this._supplyLabel.Text = "補貨單";
            // 
            // _itemNameLabel
            // 
            this._itemNameLabel.AutoSize = true;
            this._itemNameLabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._itemNameLabel.Location = new System.Drawing.Point(22, 67);
            this._itemNameLabel.Name = "_itemNameLabel";
            this._itemNameLabel.Size = new System.Drawing.Size(106, 27);
            this._itemNameLabel.TabIndex = 1;
            this._itemNameLabel.Text = "商品名稱: ";
            // 
            // _itemTypeLabel
            // 
            this._itemTypeLabel.AutoSize = true;
            this._itemTypeLabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._itemTypeLabel.Location = new System.Drawing.Point(22, 103);
            this._itemTypeLabel.Name = "_itemTypeLabel";
            this._itemTypeLabel.Size = new System.Drawing.Size(101, 27);
            this._itemTypeLabel.TabIndex = 2;
            this._itemTypeLabel.Text = "商品類別:";
            // 
            // _itemPriceLabel
            // 
            this._itemPriceLabel.AutoSize = true;
            this._itemPriceLabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._itemPriceLabel.Location = new System.Drawing.Point(22, 140);
            this._itemPriceLabel.Name = "_itemPriceLabel";
            this._itemPriceLabel.Size = new System.Drawing.Size(59, 27);
            this._itemPriceLabel.TabIndex = 3;
            this._itemPriceLabel.Text = "單價:";
            // 
            // _itemStockLabel
            // 
            this._itemStockLabel.AutoSize = true;
            this._itemStockLabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._itemStockLabel.Location = new System.Drawing.Point(22, 178);
            this._itemStockLabel.Name = "_itemStockLabel";
            this._itemStockLabel.Size = new System.Drawing.Size(101, 27);
            this._itemStockLabel.TabIndex = 4;
            this._itemStockLabel.Text = "庫存數量:";
            // 
            // _itemSupplyLabel
            // 
            this._itemSupplyLabel.AutoSize = true;
            this._itemSupplyLabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._itemSupplyLabel.Location = new System.Drawing.Point(22, 218);
            this._itemSupplyLabel.Name = "_itemSupplyLabel";
            this._itemSupplyLabel.Size = new System.Drawing.Size(101, 27);
            this._itemSupplyLabel.TabIndex = 5;
            this._itemSupplyLabel.Text = "補貨數量:";
            // 
            // _ok
            // 
            this._ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this._ok.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._ok.Location = new System.Drawing.Point(24, 262);
            this._ok.Name = "_ok";
            this._ok.Size = new System.Drawing.Size(156, 37);
            this._ok.TabIndex = 6;
            this._ok.Text = "確認";
            this._ok.UseVisualStyleBackColor = false;
            this._ok.Click += new System.EventHandler(this.ClickOk);
            // 
            // _cancel
            // 
            this._cancel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._cancel.Location = new System.Drawing.Point(186, 262);
            this._cancel.Name = "_cancel";
            this._cancel.Size = new System.Drawing.Size(156, 37);
            this._cancel.TabIndex = 7;
            this._cancel.Text = "取消";
            this._cancel.UseVisualStyleBackColor = true;
            this._cancel.Click += new System.EventHandler(this.ClickCancel);
            // 
            // _itemStock
            // 
            this._itemStock.AutoSize = true;
            this._itemStock.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._itemStock.Location = new System.Drawing.Point(129, 178);
            this._itemStock.Name = "_itemStock";
            this._itemStock.Size = new System.Drawing.Size(64, 27);
            this._itemStock.TabIndex = 11;
            this._itemStock.Text = "stock";
            // 
            // _itemPrice
            // 
            this._itemPrice.AutoSize = true;
            this._itemPrice.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._itemPrice.Location = new System.Drawing.Point(129, 140);
            this._itemPrice.Name = "_itemPrice";
            this._itemPrice.Size = new System.Drawing.Size(60, 27);
            this._itemPrice.TabIndex = 10;
            this._itemPrice.Text = "price";
            // 
            // _itemType
            // 
            this._itemType.AutoSize = true;
            this._itemType.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._itemType.Location = new System.Drawing.Point(129, 103);
            this._itemType.Name = "_itemType";
            this._itemType.Size = new System.Drawing.Size(56, 27);
            this._itemType.TabIndex = 9;
            this._itemType.Text = "type";
            // 
            // _itemName
            // 
            this._itemName.AutoSize = true;
            this._itemName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._itemName.Location = new System.Drawing.Point(129, 67);
            this._itemName.Name = "_itemName";
            this._itemName.Size = new System.Drawing.Size(68, 27);
            this._itemName.TabIndex = 8;
            this._itemName.Text = "name";
            // 
            // _itemSupply
            // 
            this._itemSupply.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._itemSupply.ImeMode = System.Windows.Forms.ImeMode.Off;
            this._itemSupply.Location = new System.Drawing.Point(129, 215);
            this._itemSupply.Name = "_itemSupply";
            this._itemSupply.Size = new System.Drawing.Size(100, 35);
            this._itemSupply.TabIndex = 12;
            this._itemSupply.Text = "0";
            this._itemSupply.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumberInput);
            // 
            // SupplyDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 321);
            this.Controls.Add(this._itemSupply);
            this.Controls.Add(this._itemStock);
            this.Controls.Add(this._itemPrice);
            this.Controls.Add(this._itemType);
            this.Controls.Add(this._itemName);
            this.Controls.Add(this._cancel);
            this.Controls.Add(this._ok);
            this.Controls.Add(this._itemSupplyLabel);
            this.Controls.Add(this._itemStockLabel);
            this.Controls.Add(this._itemPriceLabel);
            this.Controls.Add(this._itemTypeLabel);
            this.Controls.Add(this._itemNameLabel);
            this.Controls.Add(this._supplyLabel);
            this.MaximumSize = new System.Drawing.Size(390, 360);
            this.MinimumSize = new System.Drawing.Size(390, 360);
            this.Name = "SupplyDialog";
            this.Text = "補貨單";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _supplyLabel;
        private System.Windows.Forms.Label _itemNameLabel;
        private System.Windows.Forms.Label _itemTypeLabel;
        private System.Windows.Forms.Label _itemPriceLabel;
        private System.Windows.Forms.Label _itemStockLabel;
        private System.Windows.Forms.Label _itemSupplyLabel;
        private System.Windows.Forms.Button _ok;
        private System.Windows.Forms.Button _cancel;
        private System.Windows.Forms.Label _itemStock;
        private System.Windows.Forms.Label _itemPrice;
        private System.Windows.Forms.Label _itemType;
        private System.Windows.Forms.Label _itemName;
        private System.Windows.Forms.TextBox _itemSupply;
    }
}