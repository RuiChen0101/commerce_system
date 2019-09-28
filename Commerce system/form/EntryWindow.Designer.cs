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
            this.SuspendLayout();
            // 
            // _openOrderSystem
            // 
            this._openOrderSystem.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._openOrderSystem.Location = new System.Drawing.Point(12, 12);
            this._openOrderSystem.Name = "_openOrderSystem";
            this._openOrderSystem.Size = new System.Drawing.Size(758, 110);
            this._openOrderSystem.TabIndex = 0;
            this._openOrderSystem.Text = "Order System";
            this._openOrderSystem.UseVisualStyleBackColor = true;
            this._openOrderSystem.Click += new System.EventHandler(this.OpenOrderSystem);
            // 
            // _openInventorySystem
            // 
            this._openInventorySystem.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._openInventorySystem.Location = new System.Drawing.Point(12, 128);
            this._openInventorySystem.Name = "_openInventorySystem";
            this._openInventorySystem.Size = new System.Drawing.Size(758, 110);
            this._openInventorySystem.TabIndex = 1;
            this._openInventorySystem.Text = "Inventory System";
            this._openInventorySystem.UseVisualStyleBackColor = true;
            this._openInventorySystem.Click += new System.EventHandler(this.OpenInventorySystem);
            // 
            // _exit
            // 
            this._exit.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._exit.Location = new System.Drawing.Point(645, 398);
            this._exit.Name = "_exit";
            this._exit.Size = new System.Drawing.Size(125, 43);
            this._exit.TabIndex = 2;
            this._exit.Text = "Exit";
            this._exit.UseVisualStyleBackColor = true;
            this._exit.Click += new System.EventHandler(this.Exit);
            // 
            // EntryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this._exit);
            this.Controls.Add(this._openInventorySystem);
            this.Controls.Add(this._openOrderSystem);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "EntryWindow";
            this.Text = "EntryWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _openOrderSystem;
        private System.Windows.Forms.Button _openInventorySystem;
        private System.Windows.Forms.Button _exit;
    }
}