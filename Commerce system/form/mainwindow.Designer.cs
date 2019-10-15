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
            this._boardTabPage = new System.Windows.Forms.TabPage();
            this._boardItem6 = new System.Windows.Forms.Button();
            this._boardItem3 = new System.Windows.Forms.Button();
            this._boardItem5 = new System.Windows.Forms.Button();
            this._boardItem2 = new System.Windows.Forms.Button();
            this._boardItem4 = new System.Windows.Forms.Button();
            this._boardItem1 = new System.Windows.Forms.Button();
            this._processorTabPage = new System.Windows.Forms.TabPage();
            this._processorItem6 = new System.Windows.Forms.Button();
            this._processorItem3 = new System.Windows.Forms.Button();
            this._processorItem5 = new System.Windows.Forms.Button();
            this._processorItem2 = new System.Windows.Forms.Button();
            this._processorItem4 = new System.Windows.Forms.Button();
            this._processorItem1 = new System.Windows.Forms.Button();
            this._memoryTabPage = new System.Windows.Forms.TabPage();
            this._memoryItem6 = new System.Windows.Forms.Button();
            this._memoryItem3 = new System.Windows.Forms.Button();
            this._memoryItem5 = new System.Windows.Forms.Button();
            this._memoryItem2 = new System.Windows.Forms.Button();
            this._memoryItem4 = new System.Windows.Forms.Button();
            this._memoryItem1 = new System.Windows.Forms.Button();
            this._driveTabPage = new System.Windows.Forms.TabPage();
            this._driveItem6 = new System.Windows.Forms.Button();
            this._driveItem3 = new System.Windows.Forms.Button();
            this._driveItem5 = new System.Windows.Forms.Button();
            this._driveItem2 = new System.Windows.Forms.Button();
            this._driveItem4 = new System.Windows.Forms.Button();
            this._driveItem1 = new System.Windows.Forms.Button();
            this._cardTabPage = new System.Windows.Forms.TabPage();
            this._cardItem6 = new System.Windows.Forms.Button();
            this._cardItem3 = new System.Windows.Forms.Button();
            this._cardItem5 = new System.Windows.Forms.Button();
            this._cardItem2 = new System.Windows.Forms.Button();
            this._cardItem4 = new System.Windows.Forms.Button();
            this._cardItem1 = new System.Windows.Forms.Button();
            this._setTabPage = new System.Windows.Forms.TabPage();
            this._setItem6 = new System.Windows.Forms.Button();
            this._setItem3 = new System.Windows.Forms.Button();
            this._setItem5 = new System.Windows.Forms.Button();
            this._setItem2 = new System.Windows.Forms.Button();
            this._setItem4 = new System.Windows.Forms.Button();
            this._setItem1 = new System.Windows.Forms.Button();
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
            this._totalPrice = new System.Windows.Forms.Label();
            this._checkOut = new System.Windows.Forms.Button();
            this._orderedItemDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this._orderedItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderedItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderedItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._quantity = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
            this._itemTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._itemTab.SuspendLayout();
            this._boardTabPage.SuspendLayout();
            this._processorTabPage.SuspendLayout();
            this._memoryTabPage.SuspendLayout();
            this._driveTabPage.SuspendLayout();
            this._cardTabPage.SuspendLayout();
            this._setTabPage.SuspendLayout();
            this._itemGroup.SuspendLayout();
            this._itemInfoGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._orderList)).BeginInit();
            this.SuspendLayout();
            // 
            // _itemTab
            // 
            this._itemTab.Controls.Add(this._boardTabPage);
            this._itemTab.Controls.Add(this._processorTabPage);
            this._itemTab.Controls.Add(this._memoryTabPage);
            this._itemTab.Controls.Add(this._driveTabPage);
            this._itemTab.Controls.Add(this._cardTabPage);
            this._itemTab.Controls.Add(this._setTabPage);
            this._itemTab.Location = new System.Drawing.Point(4, 20);
            this._itemTab.Margin = new System.Windows.Forms.Padding(2);
            this._itemTab.Name = "_itemTab";
            this._itemTab.SelectedIndex = 0;
            this._itemTab.Size = new System.Drawing.Size(494, 298);
            this._itemTab.TabIndex = 0;
            this._itemTab.Selected += new System.Windows.Forms.TabControlEventHandler(this.HandleTabIndexChanged);
            // 
            // _boardTabPage
            // 
            this._boardTabPage.Controls.Add(this._boardItem6);
            this._boardTabPage.Controls.Add(this._boardItem3);
            this._boardTabPage.Controls.Add(this._boardItem5);
            this._boardTabPage.Controls.Add(this._boardItem2);
            this._boardTabPage.Controls.Add(this._boardItem4);
            this._boardTabPage.Controls.Add(this._boardItem1);
            this._boardTabPage.Location = new System.Drawing.Point(4, 22);
            this._boardTabPage.Margin = new System.Windows.Forms.Padding(2);
            this._boardTabPage.Name = "_boardTabPage";
            this._boardTabPage.Padding = new System.Windows.Forms.Padding(2);
            this._boardTabPage.Size = new System.Drawing.Size(486, 272);
            this._boardTabPage.TabIndex = 1;
            this._boardTabPage.Text = "主機板";
            this._boardTabPage.UseVisualStyleBackColor = true;
            // 
            // _boardItem6
            // 
            this._boardItem6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._boardItem6.Location = new System.Drawing.Point(340, 145);
            this._boardItem6.Margin = new System.Windows.Forms.Padding(2);
            this._boardItem6.Name = "_boardItem6";
            this._boardItem6.Size = new System.Drawing.Size(142, 126);
            this._boardItem6.TabIndex = 11;
            this._boardItem6.Tag = "mb_6";
            this._boardItem6.UseVisualStyleBackColor = true;
            this._boardItem6.Click += new System.EventHandler(this.ClickItem);
            // 
            // _boardItem3
            // 
            this._boardItem3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._boardItem3.Location = new System.Drawing.Point(340, 4);
            this._boardItem3.Margin = new System.Windows.Forms.Padding(2);
            this._boardItem3.Name = "_boardItem3";
            this._boardItem3.Size = new System.Drawing.Size(142, 127);
            this._boardItem3.TabIndex = 10;
            this._boardItem3.Tag = "mb_3";
            this._boardItem3.UseVisualStyleBackColor = true;
            this._boardItem3.Click += new System.EventHandler(this.ClickItem);
            // 
            // _boardItem5
            // 
            this._boardItem5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._boardItem5.Location = new System.Drawing.Point(172, 145);
            this._boardItem5.Margin = new System.Windows.Forms.Padding(2);
            this._boardItem5.Name = "_boardItem5";
            this._boardItem5.Size = new System.Drawing.Size(142, 126);
            this._boardItem5.TabIndex = 9;
            this._boardItem5.Tag = "mb_5";
            this._boardItem5.UseVisualStyleBackColor = true;
            this._boardItem5.Click += new System.EventHandler(this.ClickItem);
            // 
            // _boardItem2
            // 
            this._boardItem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._boardItem2.Location = new System.Drawing.Point(172, 4);
            this._boardItem2.Margin = new System.Windows.Forms.Padding(2);
            this._boardItem2.Name = "_boardItem2";
            this._boardItem2.Size = new System.Drawing.Size(142, 127);
            this._boardItem2.TabIndex = 8;
            this._boardItem2.Tag = "mb_2";
            this._boardItem2.UseVisualStyleBackColor = true;
            this._boardItem2.Click += new System.EventHandler(this.ClickItem);
            // 
            // _boardItem4
            // 
            this._boardItem4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._boardItem4.Location = new System.Drawing.Point(5, 145);
            this._boardItem4.Margin = new System.Windows.Forms.Padding(2);
            this._boardItem4.Name = "_boardItem4";
            this._boardItem4.Size = new System.Drawing.Size(142, 126);
            this._boardItem4.TabIndex = 7;
            this._boardItem4.Tag = "mb_4";
            this._boardItem4.UseVisualStyleBackColor = true;
            this._boardItem4.Click += new System.EventHandler(this.ClickItem);
            // 
            // _boardItem1
            // 
            this._boardItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._boardItem1.Location = new System.Drawing.Point(5, 4);
            this._boardItem1.Margin = new System.Windows.Forms.Padding(2);
            this._boardItem1.Name = "_boardItem1";
            this._boardItem1.Size = new System.Drawing.Size(142, 127);
            this._boardItem1.TabIndex = 6;
            this._boardItem1.Tag = "mb_1";
            this._boardItem1.UseVisualStyleBackColor = true;
            this._boardItem1.Click += new System.EventHandler(this.ClickItem);
            // 
            // _processorTabPage
            // 
            this._processorTabPage.Controls.Add(this._processorItem6);
            this._processorTabPage.Controls.Add(this._processorItem3);
            this._processorTabPage.Controls.Add(this._processorItem5);
            this._processorTabPage.Controls.Add(this._processorItem2);
            this._processorTabPage.Controls.Add(this._processorItem4);
            this._processorTabPage.Controls.Add(this._processorItem1);
            this._processorTabPage.Location = new System.Drawing.Point(4, 22);
            this._processorTabPage.Margin = new System.Windows.Forms.Padding(2);
            this._processorTabPage.Name = "_processorTabPage";
            this._processorTabPage.Padding = new System.Windows.Forms.Padding(2);
            this._processorTabPage.Size = new System.Drawing.Size(486, 272);
            this._processorTabPage.TabIndex = 0;
            this._processorTabPage.Text = "CPU";
            this._processorTabPage.UseVisualStyleBackColor = true;
            // 
            // _processorItem6
            // 
            this._processorItem6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._processorItem6.Location = new System.Drawing.Point(340, 145);
            this._processorItem6.Margin = new System.Windows.Forms.Padding(2);
            this._processorItem6.Name = "_processorItem6";
            this._processorItem6.Size = new System.Drawing.Size(142, 126);
            this._processorItem6.TabIndex = 5;
            this._processorItem6.Tag = "cpu_6";
            this._processorItem6.UseVisualStyleBackColor = true;
            this._processorItem6.Click += new System.EventHandler(this.ClickItem);
            // 
            // _processorItem3
            // 
            this._processorItem3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._processorItem3.Location = new System.Drawing.Point(340, 4);
            this._processorItem3.Margin = new System.Windows.Forms.Padding(2);
            this._processorItem3.Name = "_processorItem3";
            this._processorItem3.Size = new System.Drawing.Size(142, 127);
            this._processorItem3.TabIndex = 4;
            this._processorItem3.Tag = "cpu_3";
            this._processorItem3.UseVisualStyleBackColor = true;
            this._processorItem3.Click += new System.EventHandler(this.ClickItem);
            // 
            // _processorItem5
            // 
            this._processorItem5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._processorItem5.Location = new System.Drawing.Point(172, 145);
            this._processorItem5.Margin = new System.Windows.Forms.Padding(2);
            this._processorItem5.Name = "_processorItem5";
            this._processorItem5.Size = new System.Drawing.Size(142, 126);
            this._processorItem5.TabIndex = 3;
            this._processorItem5.Tag = "cpu_5";
            this._processorItem5.UseVisualStyleBackColor = true;
            this._processorItem5.Click += new System.EventHandler(this.ClickItem);
            // 
            // _processorItem2
            // 
            this._processorItem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._processorItem2.Location = new System.Drawing.Point(172, 4);
            this._processorItem2.Margin = new System.Windows.Forms.Padding(2);
            this._processorItem2.Name = "_processorItem2";
            this._processorItem2.Size = new System.Drawing.Size(142, 127);
            this._processorItem2.TabIndex = 2;
            this._processorItem2.Tag = "cpu_2";
            this._processorItem2.UseVisualStyleBackColor = true;
            this._processorItem2.Click += new System.EventHandler(this.ClickItem);
            // 
            // _processorItem4
            // 
            this._processorItem4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._processorItem4.Location = new System.Drawing.Point(5, 145);
            this._processorItem4.Margin = new System.Windows.Forms.Padding(2);
            this._processorItem4.Name = "_processorItem4";
            this._processorItem4.Size = new System.Drawing.Size(142, 126);
            this._processorItem4.TabIndex = 1;
            this._processorItem4.Tag = "cpu_4";
            this._processorItem4.UseVisualStyleBackColor = true;
            this._processorItem4.Click += new System.EventHandler(this.ClickItem);
            // 
            // _processorItem1
            // 
            this._processorItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._processorItem1.Location = new System.Drawing.Point(5, 4);
            this._processorItem1.Margin = new System.Windows.Forms.Padding(2);
            this._processorItem1.Name = "_processorItem1";
            this._processorItem1.Size = new System.Drawing.Size(142, 127);
            this._processorItem1.TabIndex = 0;
            this._processorItem1.Tag = "cpu_1";
            this._processorItem1.UseVisualStyleBackColor = true;
            this._processorItem1.Click += new System.EventHandler(this.ClickItem);
            // 
            // _memoryTabPage
            // 
            this._memoryTabPage.Controls.Add(this._memoryItem6);
            this._memoryTabPage.Controls.Add(this._memoryItem3);
            this._memoryTabPage.Controls.Add(this._memoryItem5);
            this._memoryTabPage.Controls.Add(this._memoryItem2);
            this._memoryTabPage.Controls.Add(this._memoryItem4);
            this._memoryTabPage.Controls.Add(this._memoryItem1);
            this._memoryTabPage.Location = new System.Drawing.Point(4, 22);
            this._memoryTabPage.Margin = new System.Windows.Forms.Padding(2);
            this._memoryTabPage.Name = "_memoryTabPage";
            this._memoryTabPage.Size = new System.Drawing.Size(486, 272);
            this._memoryTabPage.TabIndex = 2;
            this._memoryTabPage.Text = "記憶體";
            this._memoryTabPage.UseVisualStyleBackColor = true;
            // 
            // _memoryItem6
            // 
            this._memoryItem6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._memoryItem6.Location = new System.Drawing.Point(340, 145);
            this._memoryItem6.Margin = new System.Windows.Forms.Padding(2);
            this._memoryItem6.Name = "_memoryItem6";
            this._memoryItem6.Size = new System.Drawing.Size(142, 126);
            this._memoryItem6.TabIndex = 17;
            this._memoryItem6.Tag = "mem_6";
            this._memoryItem6.UseVisualStyleBackColor = true;
            this._memoryItem6.Click += new System.EventHandler(this.ClickItem);
            // 
            // _memoryItem3
            // 
            this._memoryItem3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._memoryItem3.Location = new System.Drawing.Point(340, 4);
            this._memoryItem3.Margin = new System.Windows.Forms.Padding(2);
            this._memoryItem3.Name = "_memoryItem3";
            this._memoryItem3.Size = new System.Drawing.Size(142, 127);
            this._memoryItem3.TabIndex = 16;
            this._memoryItem3.Tag = "mem_3";
            this._memoryItem3.UseVisualStyleBackColor = true;
            this._memoryItem3.Click += new System.EventHandler(this.ClickItem);
            // 
            // _memoryItem5
            // 
            this._memoryItem5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._memoryItem5.Location = new System.Drawing.Point(172, 145);
            this._memoryItem5.Margin = new System.Windows.Forms.Padding(2);
            this._memoryItem5.Name = "_memoryItem5";
            this._memoryItem5.Size = new System.Drawing.Size(142, 126);
            this._memoryItem5.TabIndex = 15;
            this._memoryItem5.Tag = "mem_5";
            this._memoryItem5.UseVisualStyleBackColor = true;
            this._memoryItem5.Click += new System.EventHandler(this.ClickItem);
            // 
            // _memoryItem2
            // 
            this._memoryItem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._memoryItem2.Location = new System.Drawing.Point(172, 4);
            this._memoryItem2.Margin = new System.Windows.Forms.Padding(2);
            this._memoryItem2.Name = "_memoryItem2";
            this._memoryItem2.Size = new System.Drawing.Size(142, 127);
            this._memoryItem2.TabIndex = 14;
            this._memoryItem2.Tag = "mem_2";
            this._memoryItem2.UseVisualStyleBackColor = true;
            this._memoryItem2.Click += new System.EventHandler(this.ClickItem);
            // 
            // _memoryItem4
            // 
            this._memoryItem4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._memoryItem4.Location = new System.Drawing.Point(5, 145);
            this._memoryItem4.Margin = new System.Windows.Forms.Padding(2);
            this._memoryItem4.Name = "_memoryItem4";
            this._memoryItem4.Size = new System.Drawing.Size(142, 126);
            this._memoryItem4.TabIndex = 13;
            this._memoryItem4.Tag = "mem_4";
            this._memoryItem4.UseVisualStyleBackColor = true;
            this._memoryItem4.Click += new System.EventHandler(this.ClickItem);
            // 
            // _memoryItem1
            // 
            this._memoryItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._memoryItem1.Location = new System.Drawing.Point(5, 4);
            this._memoryItem1.Margin = new System.Windows.Forms.Padding(2);
            this._memoryItem1.Name = "_memoryItem1";
            this._memoryItem1.Size = new System.Drawing.Size(142, 127);
            this._memoryItem1.TabIndex = 12;
            this._memoryItem1.Tag = "mem_1";
            this._memoryItem1.UseVisualStyleBackColor = true;
            this._memoryItem1.Click += new System.EventHandler(this.ClickItem);
            // 
            // _driveTabPage
            // 
            this._driveTabPage.Controls.Add(this._driveItem6);
            this._driveTabPage.Controls.Add(this._driveItem3);
            this._driveTabPage.Controls.Add(this._driveItem5);
            this._driveTabPage.Controls.Add(this._driveItem2);
            this._driveTabPage.Controls.Add(this._driveItem4);
            this._driveTabPage.Controls.Add(this._driveItem1);
            this._driveTabPage.Location = new System.Drawing.Point(4, 22);
            this._driveTabPage.Margin = new System.Windows.Forms.Padding(2);
            this._driveTabPage.Name = "_driveTabPage";
            this._driveTabPage.Size = new System.Drawing.Size(486, 272);
            this._driveTabPage.TabIndex = 3;
            this._driveTabPage.Text = "硬碟";
            this._driveTabPage.UseVisualStyleBackColor = true;
            // 
            // _driveItem6
            // 
            this._driveItem6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._driveItem6.Location = new System.Drawing.Point(340, 145);
            this._driveItem6.Margin = new System.Windows.Forms.Padding(2);
            this._driveItem6.Name = "_driveItem6";
            this._driveItem6.Size = new System.Drawing.Size(142, 126);
            this._driveItem6.TabIndex = 17;
            this._driveItem6.Tag = "hdd_6";
            this._driveItem6.UseVisualStyleBackColor = true;
            this._driveItem6.Click += new System.EventHandler(this.ClickItem);
            // 
            // _driveItem3
            // 
            this._driveItem3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._driveItem3.Location = new System.Drawing.Point(340, 4);
            this._driveItem3.Margin = new System.Windows.Forms.Padding(2);
            this._driveItem3.Name = "_driveItem3";
            this._driveItem3.Size = new System.Drawing.Size(142, 127);
            this._driveItem3.TabIndex = 16;
            this._driveItem3.Tag = "hdd_3";
            this._driveItem3.UseVisualStyleBackColor = true;
            this._driveItem3.Click += new System.EventHandler(this.ClickItem);
            // 
            // _driveItem5
            // 
            this._driveItem5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._driveItem5.Location = new System.Drawing.Point(172, 145);
            this._driveItem5.Margin = new System.Windows.Forms.Padding(2);
            this._driveItem5.Name = "_driveItem5";
            this._driveItem5.Size = new System.Drawing.Size(142, 126);
            this._driveItem5.TabIndex = 15;
            this._driveItem5.Tag = "hdd_5";
            this._driveItem5.UseVisualStyleBackColor = true;
            this._driveItem5.Click += new System.EventHandler(this.ClickItem);
            // 
            // _driveItem2
            // 
            this._driveItem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._driveItem2.Location = new System.Drawing.Point(172, 4);
            this._driveItem2.Margin = new System.Windows.Forms.Padding(2);
            this._driveItem2.Name = "_driveItem2";
            this._driveItem2.Size = new System.Drawing.Size(142, 127);
            this._driveItem2.TabIndex = 14;
            this._driveItem2.Tag = "hdd_2";
            this._driveItem2.UseVisualStyleBackColor = true;
            this._driveItem2.Click += new System.EventHandler(this.ClickItem);
            // 
            // _driveItem4
            // 
            this._driveItem4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._driveItem4.Location = new System.Drawing.Point(5, 145);
            this._driveItem4.Margin = new System.Windows.Forms.Padding(2);
            this._driveItem4.Name = "_driveItem4";
            this._driveItem4.Size = new System.Drawing.Size(142, 126);
            this._driveItem4.TabIndex = 13;
            this._driveItem4.Tag = "hdd_4";
            this._driveItem4.UseVisualStyleBackColor = true;
            this._driveItem4.Click += new System.EventHandler(this.ClickItem);
            // 
            // _driveItem1
            // 
            this._driveItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._driveItem1.Location = new System.Drawing.Point(5, 4);
            this._driveItem1.Margin = new System.Windows.Forms.Padding(2);
            this._driveItem1.Name = "_driveItem1";
            this._driveItem1.Size = new System.Drawing.Size(142, 127);
            this._driveItem1.TabIndex = 12;
            this._driveItem1.Tag = "hdd_1";
            this._driveItem1.UseVisualStyleBackColor = true;
            this._driveItem1.Click += new System.EventHandler(this.ClickItem);
            // 
            // _cardTabPage
            // 
            this._cardTabPage.Controls.Add(this._cardItem6);
            this._cardTabPage.Controls.Add(this._cardItem3);
            this._cardTabPage.Controls.Add(this._cardItem5);
            this._cardTabPage.Controls.Add(this._cardItem2);
            this._cardTabPage.Controls.Add(this._cardItem4);
            this._cardTabPage.Controls.Add(this._cardItem1);
            this._cardTabPage.Location = new System.Drawing.Point(4, 22);
            this._cardTabPage.Margin = new System.Windows.Forms.Padding(2);
            this._cardTabPage.Name = "_cardTabPage";
            this._cardTabPage.Size = new System.Drawing.Size(486, 272);
            this._cardTabPage.TabIndex = 4;
            this._cardTabPage.Text = "顯示卡";
            this._cardTabPage.UseVisualStyleBackColor = true;
            // 
            // _cardItem6
            // 
            this._cardItem6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._cardItem6.Location = new System.Drawing.Point(340, 145);
            this._cardItem6.Margin = new System.Windows.Forms.Padding(2);
            this._cardItem6.Name = "_cardItem6";
            this._cardItem6.Size = new System.Drawing.Size(142, 126);
            this._cardItem6.TabIndex = 17;
            this._cardItem6.Tag = "gpu_6";
            this._cardItem6.UseVisualStyleBackColor = true;
            this._cardItem6.Click += new System.EventHandler(this.ClickItem);
            // 
            // _cardItem3
            // 
            this._cardItem3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._cardItem3.Location = new System.Drawing.Point(340, 4);
            this._cardItem3.Margin = new System.Windows.Forms.Padding(2);
            this._cardItem3.Name = "_cardItem3";
            this._cardItem3.Size = new System.Drawing.Size(142, 127);
            this._cardItem3.TabIndex = 16;
            this._cardItem3.Tag = "gpu_3";
            this._cardItem3.UseVisualStyleBackColor = true;
            this._cardItem3.Click += new System.EventHandler(this.ClickItem);
            // 
            // _cardItem5
            // 
            this._cardItem5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._cardItem5.Location = new System.Drawing.Point(172, 145);
            this._cardItem5.Margin = new System.Windows.Forms.Padding(2);
            this._cardItem5.Name = "_cardItem5";
            this._cardItem5.Size = new System.Drawing.Size(142, 126);
            this._cardItem5.TabIndex = 15;
            this._cardItem5.Tag = "gpu_5";
            this._cardItem5.UseVisualStyleBackColor = true;
            this._cardItem5.Click += new System.EventHandler(this.ClickItem);
            // 
            // _cardItem2
            // 
            this._cardItem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._cardItem2.Location = new System.Drawing.Point(172, 4);
            this._cardItem2.Margin = new System.Windows.Forms.Padding(2);
            this._cardItem2.Name = "_cardItem2";
            this._cardItem2.Size = new System.Drawing.Size(142, 127);
            this._cardItem2.TabIndex = 14;
            this._cardItem2.Tag = "gpu_2";
            this._cardItem2.UseVisualStyleBackColor = true;
            this._cardItem2.Click += new System.EventHandler(this.ClickItem);
            // 
            // _cardItem4
            // 
            this._cardItem4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._cardItem4.Location = new System.Drawing.Point(5, 145);
            this._cardItem4.Margin = new System.Windows.Forms.Padding(2);
            this._cardItem4.Name = "_cardItem4";
            this._cardItem4.Size = new System.Drawing.Size(142, 126);
            this._cardItem4.TabIndex = 13;
            this._cardItem4.Tag = "gpu_4";
            this._cardItem4.UseVisualStyleBackColor = true;
            this._cardItem4.Click += new System.EventHandler(this.ClickItem);
            // 
            // _cardItem1
            // 
            this._cardItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._cardItem1.Location = new System.Drawing.Point(5, 4);
            this._cardItem1.Margin = new System.Windows.Forms.Padding(2);
            this._cardItem1.Name = "_cardItem1";
            this._cardItem1.Size = new System.Drawing.Size(142, 127);
            this._cardItem1.TabIndex = 12;
            this._cardItem1.Tag = "gpu_1";
            this._cardItem1.UseVisualStyleBackColor = true;
            this._cardItem1.Click += new System.EventHandler(this.ClickItem);
            // 
            // _setTabPage
            // 
            this._setTabPage.Controls.Add(this._setItem6);
            this._setTabPage.Controls.Add(this._setItem3);
            this._setTabPage.Controls.Add(this._setItem5);
            this._setTabPage.Controls.Add(this._setItem2);
            this._setTabPage.Controls.Add(this._setItem4);
            this._setTabPage.Controls.Add(this._setItem1);
            this._setTabPage.Location = new System.Drawing.Point(4, 22);
            this._setTabPage.Margin = new System.Windows.Forms.Padding(2);
            this._setTabPage.Name = "_setTabPage";
            this._setTabPage.Size = new System.Drawing.Size(486, 272);
            this._setTabPage.TabIndex = 5;
            this._setTabPage.Text = "套裝電腦";
            this._setTabPage.UseVisualStyleBackColor = true;
            // 
            // _setItem6
            // 
            this._setItem6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._setItem6.Location = new System.Drawing.Point(340, 145);
            this._setItem6.Margin = new System.Windows.Forms.Padding(2);
            this._setItem6.Name = "_setItem6";
            this._setItem6.Size = new System.Drawing.Size(142, 126);
            this._setItem6.TabIndex = 17;
            this._setItem6.Tag = "set_6";
            this._setItem6.UseVisualStyleBackColor = true;
            this._setItem6.Click += new System.EventHandler(this.ClickItem);
            // 
            // _setItem3
            // 
            this._setItem3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._setItem3.Location = new System.Drawing.Point(340, 4);
            this._setItem3.Margin = new System.Windows.Forms.Padding(2);
            this._setItem3.Name = "_setItem3";
            this._setItem3.Size = new System.Drawing.Size(142, 127);
            this._setItem3.TabIndex = 16;
            this._setItem3.Tag = "set_3";
            this._setItem3.UseVisualStyleBackColor = true;
            this._setItem3.Click += new System.EventHandler(this.ClickItem);
            // 
            // _setItem5
            // 
            this._setItem5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._setItem5.Location = new System.Drawing.Point(172, 145);
            this._setItem5.Margin = new System.Windows.Forms.Padding(2);
            this._setItem5.Name = "_setItem5";
            this._setItem5.Size = new System.Drawing.Size(142, 126);
            this._setItem5.TabIndex = 15;
            this._setItem5.Tag = "set_5";
            this._setItem5.UseVisualStyleBackColor = true;
            this._setItem5.Click += new System.EventHandler(this.ClickItem);
            // 
            // _setItem2
            // 
            this._setItem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._setItem2.Location = new System.Drawing.Point(172, 4);
            this._setItem2.Margin = new System.Windows.Forms.Padding(2);
            this._setItem2.Name = "_setItem2";
            this._setItem2.Size = new System.Drawing.Size(142, 127);
            this._setItem2.TabIndex = 14;
            this._setItem2.Tag = "set_2";
            this._setItem2.UseVisualStyleBackColor = true;
            this._setItem2.Click += new System.EventHandler(this.ClickItem);
            // 
            // _setItem4
            // 
            this._setItem4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._setItem4.Location = new System.Drawing.Point(5, 145);
            this._setItem4.Margin = new System.Windows.Forms.Padding(2);
            this._setItem4.Name = "_setItem4";
            this._setItem4.Size = new System.Drawing.Size(142, 126);
            this._setItem4.TabIndex = 13;
            this._setItem4.Tag = "set_4";
            this._setItem4.UseVisualStyleBackColor = true;
            this._setItem4.Click += new System.EventHandler(this.ClickItem);
            // 
            // _setItem1
            // 
            this._setItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._setItem1.Location = new System.Drawing.Point(5, 4);
            this._setItem1.Margin = new System.Windows.Forms.Padding(2);
            this._setItem1.Name = "_setItem1";
            this._setItem1.Size = new System.Drawing.Size(142, 127);
            this._setItem1.TabIndex = 12;
            this._setItem1.Tag = "set_1";
            this._setItem1.UseVisualStyleBackColor = true;
            this._setItem1.Click += new System.EventHandler(this.ClickItem);
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
            this._nextPage.Margin = new System.Windows.Forms.Padding(2);
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
            this._previousPage.Margin = new System.Windows.Forms.Padding(2);
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
            this._orderList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.SetDeleteImageGrid);
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
            this._checkOut.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._checkOut.Location = new System.Drawing.Point(985, 481);
            this._checkOut.Margin = new System.Windows.Forms.Padding(2);
            this._checkOut.Name = "_checkOut";
            this._checkOut.Size = new System.Drawing.Size(87, 39);
            this._checkOut.TabIndex = 4;
            this._checkOut.Text = "訂購";
            this._checkOut.UseVisualStyleBackColor = true;
            this._checkOut.Click += new System.EventHandler(this.ClickCheckOut);
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 543);
            this.Controls.Add(this._checkOut);
            this.Controls.Add(this._totalPrice);
            this.Controls.Add(this._orderList);
            this.Controls.Add(this._itemGroup);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1100, 582);
            this.MinimumSize = new System.Drawing.Size(1100, 582);
            this.Name = "MainWindow";
            this.Text = "mainWindow";
            this._itemTab.ResumeLayout(false);
            this._boardTabPage.ResumeLayout(false);
            this._processorTabPage.ResumeLayout(false);
            this._memoryTabPage.ResumeLayout(false);
            this._driveTabPage.ResumeLayout(false);
            this._cardTabPage.ResumeLayout(false);
            this._setTabPage.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage _processorTabPage;
        private System.Windows.Forms.TabPage _boardTabPage;
        private System.Windows.Forms.RichTextBox _descriptionBox;
        private System.Windows.Forms.GroupBox _itemGroup;
        private System.Windows.Forms.GroupBox _itemInfoGroup;
        private System.Windows.Forms.Button _addToCart;
        private System.Windows.Forms.Label _itemPrice;
        private System.Windows.Forms.DataGridView _orderList;
        private System.Windows.Forms.Label _totalPrice;
        private System.Windows.Forms.TabPage _memoryTabPage;
        private System.Windows.Forms.TabPage _driveTabPage;
        private System.Windows.Forms.TabPage _cardTabPage;
        private System.Windows.Forms.TabPage _setTabPage;
        private System.Windows.Forms.Button _boardItem6;
        private System.Windows.Forms.Button _boardItem3;
        private System.Windows.Forms.Button _boardItem5;
        private System.Windows.Forms.Button _boardItem2;
        private System.Windows.Forms.Button _boardItem4;
        private System.Windows.Forms.Button _boardItem1;
        private System.Windows.Forms.Button _processorItem6;
        private System.Windows.Forms.Button _processorItem3;
        private System.Windows.Forms.Button _processorItem5;
        private System.Windows.Forms.Button _processorItem2;
        private System.Windows.Forms.Button _processorItem4;
        private System.Windows.Forms.Button _processorItem1;
        private System.Windows.Forms.Button _memoryItem6;
        private System.Windows.Forms.Button _memoryItem3;
        private System.Windows.Forms.Button _memoryItem5;
        private System.Windows.Forms.Button _memoryItem2;
        private System.Windows.Forms.Button _memoryItem4;
        private System.Windows.Forms.Button _memoryItem1;
        private System.Windows.Forms.Button _driveItem6;
        private System.Windows.Forms.Button _driveItem3;
        private System.Windows.Forms.Button _driveItem5;
        private System.Windows.Forms.Button _driveItem2;
        private System.Windows.Forms.Button _driveItem4;
        private System.Windows.Forms.Button _driveItem1;
        private System.Windows.Forms.Button _cardItem6;
        private System.Windows.Forms.Button _cardItem3;
        private System.Windows.Forms.Button _cardItem5;
        private System.Windows.Forms.Button _cardItem2;
        private System.Windows.Forms.Button _cardItem4;
        private System.Windows.Forms.Button _cardItem1;
        private System.Windows.Forms.Button _setItem6;
        private System.Windows.Forms.Button _setItem3;
        private System.Windows.Forms.Button _setItem5;
        private System.Windows.Forms.Button _setItem2;
        private System.Windows.Forms.Button _setItem4;
        private System.Windows.Forms.Button _setItem1;
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
