namespace Commerce_system
{
    partial class EntryWindow
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
            this._openOrderSystem = new System.Windows.Forms.Button();
            this._openInventorySystem = new System.Windows.Forms.Button();
            this._exit = new System.Windows.Forms.Button();
            this._openProductManageSystem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _openOrderSystem
            // 
            this._openOrderSystem.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._openOrderSystem.Location = new System.Drawing.Point(9, 10);
            this._openOrderSystem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._openOrderSystem.Name = "_openOrderSystem";
            this._openOrderSystem.Size = new System.Drawing.Size(568, 88);
            this._openOrderSystem.TabIndex = 0;
            this._openOrderSystem.Text = "Order System";
            this._openOrderSystem.UseVisualStyleBackColor = true;
            this._openOrderSystem.Click += new System.EventHandler(this.OpenOrderSystem);
            // 
            // _openInventorySystem
            // 
            this._openInventorySystem.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._openInventorySystem.Location = new System.Drawing.Point(9, 102);
            this._openInventorySystem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._openInventorySystem.Name = "_openInventorySystem";
            this._openInventorySystem.Size = new System.Drawing.Size(568, 88);
            this._openInventorySystem.TabIndex = 1;
            this._openInventorySystem.Text = "Inventory System";
            this._openInventorySystem.UseVisualStyleBackColor = true;
            this._openInventorySystem.Click += new System.EventHandler(this.OpenInventorySystem);
            // 
            // _exit
            // 
            this._exit.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._exit.Location = new System.Drawing.Point(484, 318);
            this._exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._exit.Name = "_exit";
            this._exit.Size = new System.Drawing.Size(94, 34);
            this._exit.TabIndex = 2;
            this._exit.Text = "Exit";
            this._exit.UseVisualStyleBackColor = true;
            this._exit.Click += new System.EventHandler(this.Exit);
            // 
            // _openProductManageSystem
            // 
            this._openProductManageSystem.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._openProductManageSystem.Location = new System.Drawing.Point(11, 194);
            this._openProductManageSystem.Margin = new System.Windows.Forms.Padding(2);
            this._openProductManageSystem.Name = "_openProductManageSystem";
            this._openProductManageSystem.Size = new System.Drawing.Size(568, 88);
            this._openProductManageSystem.TabIndex = 3;
            this._openProductManageSystem.Text = "Product Manage System";
            this._openProductManageSystem.UseVisualStyleBackColor = true;
            this._openProductManageSystem.Click += new System.EventHandler(this.OpenProductSystem);
            // 
            // EntryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 369);
            this.Controls.Add(this._openProductManageSystem);
            this.Controls.Add(this._exit);
            this.Controls.Add(this._openInventorySystem);
            this.Controls.Add(this._openOrderSystem);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(604, 408);
            this.MinimumSize = new System.Drawing.Size(604, 408);
            this.Name = "EntryWindow";
            this.Text = "EntryWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _openOrderSystem;
        private System.Windows.Forms.Button _openInventorySystem;
        private System.Windows.Forms.Button _exit;
        private System.Windows.Forms.Button _openProductManageSystem;
    }
}