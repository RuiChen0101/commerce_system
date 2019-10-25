namespace Commerce_system
{
    partial class PaymentDialog
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
            this._creditCardLabel = new System.Windows.Forms.Label();
            this._cardHolderNameLabel = new System.Windows.Forms.Label();
            this._cardHolderFirstName = new System.Windows.Forms.TextBox();
            this._cardHolderLastName = new System.Windows.Forms.TextBox();
            this._dash1 = new System.Windows.Forms.Label();
            this._dash2 = new System.Windows.Forms.Label();
            this._cardNumber2 = new System.Windows.Forms.TextBox();
            this._cardNumber1 = new System.Windows.Forms.TextBox();
            this._cardNumberLabel = new System.Windows.Forms.Label();
            this._dash4 = new System.Windows.Forms.Label();
            this._cardNumber4 = new System.Windows.Forms.TextBox();
            this._cardNumber3 = new System.Windows.Forms.TextBox();
            this._dash3 = new System.Windows.Forms.Label();
            this._expireDateLabel = new System.Windows.Forms.Label();
            this._expireMonth = new System.Windows.Forms.ComboBox();
            this._slash = new System.Windows.Forms.Label();
            this._expireYear = new System.Windows.Forms.ComboBox();
            this._verifyCodeLabel = new System.Windows.Forms.Label();
            this._verifyCode = new System.Windows.Forms.TextBox();
            this._mail = new System.Windows.Forms.TextBox();
            this._mailLabel = new System.Windows.Forms.Label();
            this._address = new System.Windows.Forms.TextBox();
            this._addressLabel = new System.Windows.Forms.Label();
            this._submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _creditCardLabel
            // 
            this._creditCardLabel.AutoSize = true;
            this._creditCardLabel.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._creditCardLabel.Location = new System.Drawing.Point(114, 12);
            this._creditCardLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._creditCardLabel.Name = "_creditCardLabel";
            this._creditCardLabel.Size = new System.Drawing.Size(150, 34);
            this._creditCardLabel.TabIndex = 0;
            this._creditCardLabel.Text = "信用卡支付";
            // 
            // _cardHolderNameLabel
            // 
            this._cardHolderNameLabel.AutoSize = true;
            this._cardHolderNameLabel.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._cardHolderNameLabel.Location = new System.Drawing.Point(34, 56);
            this._cardHolderNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._cardHolderNameLabel.Name = "_cardHolderNameLabel";
            this._cardHolderNameLabel.Size = new System.Drawing.Size(91, 19);
            this._cardHolderNameLabel.TabIndex = 1;
            this._cardHolderNameLabel.Text = "持卡人姓名*";
            // 
            // _cardHolderFirstName
            // 
            this._cardHolderFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this._cardHolderFirstName.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._cardHolderFirstName.ImeMode = System.Windows.Forms.ImeMode.Off;
            this._cardHolderFirstName.Location = new System.Drawing.Point(37, 78);
            this._cardHolderFirstName.Margin = new System.Windows.Forms.Padding(2);
            this._cardHolderFirstName.MaxLength = 12;
            this._cardHolderFirstName.Name = "_cardHolderFirstName";
            this._cardHolderFirstName.Size = new System.Drawing.Size(128, 26);
            this._cardHolderFirstName.TabIndex = 1;
            this._cardHolderFirstName.TextChanged += new System.EventHandler(this.CheckTextInput);
            this._cardHolderFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckStringInput);
            // 
            // _cardHolderLastName
            // 
            this._cardHolderLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this._cardHolderLastName.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._cardHolderLastName.ImeMode = System.Windows.Forms.ImeMode.Off;
            this._cardHolderLastName.Location = new System.Drawing.Point(186, 78);
            this._cardHolderLastName.Margin = new System.Windows.Forms.Padding(2);
            this._cardHolderLastName.MaxLength = 12;
            this._cardHolderLastName.Name = "_cardHolderLastName";
            this._cardHolderLastName.Size = new System.Drawing.Size(128, 26);
            this._cardHolderLastName.TabIndex = 2;
            this._cardHolderLastName.TextChanged += new System.EventHandler(this.CheckTextInput);
            this._cardHolderLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckStringInput);
            // 
            // _dash1
            // 
            this._dash1.AutoSize = true;
            this._dash1.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._dash1.Location = new System.Drawing.Point(168, 78);
            this._dash1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._dash1.Name = "_dash1";
            this._dash1.Size = new System.Drawing.Size(15, 19);
            this._dash1.TabIndex = 4;
            this._dash1.Text = "-";
            // 
            // _dash2
            // 
            this._dash2.AutoSize = true;
            this._dash2.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._dash2.Location = new System.Drawing.Point(97, 143);
            this._dash2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._dash2.Name = "_dash2";
            this._dash2.Size = new System.Drawing.Size(15, 19);
            this._dash2.TabIndex = 8;
            this._dash2.Text = "-";
            // 
            // _cardNumber2
            // 
            this._cardNumber2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._cardNumber2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this._cardNumber2.Location = new System.Drawing.Point(115, 142);
            this._cardNumber2.Margin = new System.Windows.Forms.Padding(2);
            this._cardNumber2.MaxLength = 4;
            this._cardNumber2.Name = "_cardNumber2";
            this._cardNumber2.Size = new System.Drawing.Size(50, 26);
            this._cardNumber2.TabIndex = 4;
            this._cardNumber2.TextChanged += new System.EventHandler(this.CheckCardNumberInput);
            this._cardNumber2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumberInput);
            // 
            // _cardNumber1
            // 
            this._cardNumber1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._cardNumber1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this._cardNumber1.Location = new System.Drawing.Point(37, 142);
            this._cardNumber1.Margin = new System.Windows.Forms.Padding(2);
            this._cardNumber1.MaxLength = 4;
            this._cardNumber1.Name = "_cardNumber1";
            this._cardNumber1.Size = new System.Drawing.Size(50, 26);
            this._cardNumber1.TabIndex = 3;
            this._cardNumber1.TextChanged += new System.EventHandler(this.CheckCardNumberInput);
            this._cardNumber1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumberInput);
            // 
            // _cardNumberLabel
            // 
            this._cardNumberLabel.AutoSize = true;
            this._cardNumberLabel.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._cardNumberLabel.Location = new System.Drawing.Point(34, 120);
            this._cardNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._cardNumberLabel.Name = "_cardNumberLabel";
            this._cardNumberLabel.Size = new System.Drawing.Size(91, 19);
            this._cardNumberLabel.TabIndex = 5;
            this._cardNumberLabel.Text = "信用卡卡號*";
            // 
            // _dash4
            // 
            this._dash4.AutoSize = true;
            this._dash4.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._dash4.Location = new System.Drawing.Point(246, 143);
            this._dash4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._dash4.Name = "_dash4";
            this._dash4.Size = new System.Drawing.Size(15, 19);
            this._dash4.TabIndex = 11;
            this._dash4.Text = "-";
            // 
            // _cardNumber4
            // 
            this._cardNumber4.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._cardNumber4.ImeMode = System.Windows.Forms.ImeMode.Off;
            this._cardNumber4.Location = new System.Drawing.Point(264, 142);
            this._cardNumber4.Margin = new System.Windows.Forms.Padding(2);
            this._cardNumber4.MaxLength = 4;
            this._cardNumber4.Name = "_cardNumber4";
            this._cardNumber4.Size = new System.Drawing.Size(50, 26);
            this._cardNumber4.TabIndex = 6;
            this._cardNumber4.TextChanged += new System.EventHandler(this.CheckCardNumberInput);
            this._cardNumber4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumberInput);
            // 
            // _cardNumber3
            // 
            this._cardNumber3.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._cardNumber3.ImeMode = System.Windows.Forms.ImeMode.Off;
            this._cardNumber3.Location = new System.Drawing.Point(187, 142);
            this._cardNumber3.Margin = new System.Windows.Forms.Padding(2);
            this._cardNumber3.MaxLength = 4;
            this._cardNumber3.Name = "_cardNumber3";
            this._cardNumber3.Size = new System.Drawing.Size(50, 26);
            this._cardNumber3.TabIndex = 5;
            this._cardNumber3.TextChanged += new System.EventHandler(this.CheckCardNumberInput);
            this._cardNumber3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumberInput);
            // 
            // _dash3
            // 
            this._dash3.AutoSize = true;
            this._dash3.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._dash3.Location = new System.Drawing.Point(169, 143);
            this._dash3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._dash3.Name = "_dash3";
            this._dash3.Size = new System.Drawing.Size(15, 19);
            this._dash3.TabIndex = 12;
            this._dash3.Text = "-";
            // 
            // _expireDateLabel
            // 
            this._expireDateLabel.AutoSize = true;
            this._expireDateLabel.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._expireDateLabel.Location = new System.Drawing.Point(34, 188);
            this._expireDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._expireDateLabel.Name = "_expireDateLabel";
            this._expireDateLabel.Size = new System.Drawing.Size(122, 19);
            this._expireDateLabel.TabIndex = 13;
            this._expireDateLabel.Text = "有效日期*(月/年)";
            // 
            // _expireMonth
            // 
            this._expireMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._expireMonth.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._expireMonth.FormattingEnabled = true;
            this._expireMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this._expireMonth.Location = new System.Drawing.Point(37, 210);
            this._expireMonth.Margin = new System.Windows.Forms.Padding(2);
            this._expireMonth.Name = "_expireMonth";
            this._expireMonth.Size = new System.Drawing.Size(128, 28);
            this._expireMonth.TabIndex = 7;
            // 
            // _slash
            // 
            this._slash.AutoSize = true;
            this._slash.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._slash.Location = new System.Drawing.Point(168, 214);
            this._slash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._slash.Name = "_slash";
            this._slash.Size = new System.Drawing.Size(15, 19);
            this._slash.TabIndex = 15;
            this._slash.Text = "/";
            // 
            // _expireYear
            // 
            this._expireYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._expireYear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._expireYear.FormattingEnabled = true;
            this._expireYear.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028"});
            this._expireYear.Location = new System.Drawing.Point(186, 213);
            this._expireYear.Margin = new System.Windows.Forms.Padding(2);
            this._expireYear.Name = "_expireYear";
            this._expireYear.Size = new System.Drawing.Size(128, 28);
            this._expireYear.TabIndex = 8;
            // 
            // _verifyCodeLabel
            // 
            this._verifyCodeLabel.AutoSize = true;
            this._verifyCodeLabel.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._verifyCodeLabel.Location = new System.Drawing.Point(34, 255);
            this._verifyCodeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._verifyCodeLabel.Name = "_verifyCodeLabel";
            this._verifyCodeLabel.Size = new System.Drawing.Size(91, 19);
            this._verifyCodeLabel.TabIndex = 17;
            this._verifyCodeLabel.Text = "背後末三碼*";
            // 
            // _verifyCode
            // 
            this._verifyCode.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._verifyCode.ImeMode = System.Windows.Forms.ImeMode.Off;
            this._verifyCode.Location = new System.Drawing.Point(37, 277);
            this._verifyCode.Margin = new System.Windows.Forms.Padding(2);
            this._verifyCode.MaxLength = 3;
            this._verifyCode.Name = "_verifyCode";
            this._verifyCode.Size = new System.Drawing.Size(277, 26);
            this._verifyCode.TabIndex = 9;
            this._verifyCode.TextChanged += new System.EventHandler(this.CheckVerifyCodeInput);
            this._verifyCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumberInput);
            // 
            // _mail
            // 
            this._mail.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._mail.ImeMode = System.Windows.Forms.ImeMode.Off;
            this._mail.Location = new System.Drawing.Point(37, 338);
            this._mail.Margin = new System.Windows.Forms.Padding(2);
            this._mail.Name = "_mail";
            this._mail.Size = new System.Drawing.Size(277, 26);
            this._mail.TabIndex = 10;
            this._mail.TextChanged += new System.EventHandler(this.CheckMailInput);
            // 
            // _mailLabel
            // 
            this._mailLabel.AutoSize = true;
            this._mailLabel.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._mailLabel.Location = new System.Drawing.Point(34, 316);
            this._mailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._mailLabel.Name = "_mailLabel";
            this._mailLabel.Size = new System.Drawing.Size(54, 19);
            this._mailLabel.TabIndex = 19;
            this._mailLabel.Text = "Email*";
            // 
            // _address
            // 
            this._address.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._address.ImeMode = System.Windows.Forms.ImeMode.Off;
            this._address.Location = new System.Drawing.Point(37, 397);
            this._address.Margin = new System.Windows.Forms.Padding(2);
            this._address.Name = "_address";
            this._address.Size = new System.Drawing.Size(277, 26);
            this._address.TabIndex = 11;
            this._address.TextChanged += new System.EventHandler(this.CheckTextInput);
            // 
            // _addressLabel
            // 
            this._addressLabel.AutoSize = true;
            this._addressLabel.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._addressLabel.Location = new System.Drawing.Point(34, 375);
            this._addressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._addressLabel.Name = "_addressLabel";
            this._addressLabel.Size = new System.Drawing.Size(76, 19);
            this._addressLabel.TabIndex = 21;
            this._addressLabel.Text = "帳單地址*";
            // 
            // _submit
            // 
            this._submit.BackColor = System.Drawing.Color.Red;
            this._submit.Enabled = false;
            this._submit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._submit.ForeColor = System.Drawing.Color.White;
            this._submit.Location = new System.Drawing.Point(37, 434);
            this._submit.Margin = new System.Windows.Forms.Padding(2);
            this._submit.Name = "_submit";
            this._submit.Size = new System.Drawing.Size(276, 34);
            this._submit.TabIndex = 22;
            this._submit.Text = "確認";
            this._submit.UseVisualStyleBackColor = false;
            this._submit.Click += new System.EventHandler(this.ClickSubmit);
            // 
            // PaymentDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 489);
            this.Controls.Add(this._submit);
            this.Controls.Add(this._address);
            this.Controls.Add(this._addressLabel);
            this.Controls.Add(this._mail);
            this.Controls.Add(this._mailLabel);
            this.Controls.Add(this._verifyCode);
            this.Controls.Add(this._verifyCodeLabel);
            this.Controls.Add(this._expireYear);
            this.Controls.Add(this._slash);
            this.Controls.Add(this._expireMonth);
            this.Controls.Add(this._expireDateLabel);
            this.Controls.Add(this._dash3);
            this.Controls.Add(this._dash4);
            this.Controls.Add(this._cardNumber4);
            this.Controls.Add(this._cardNumber3);
            this.Controls.Add(this._dash2);
            this.Controls.Add(this._cardNumber2);
            this.Controls.Add(this._cardNumber1);
            this.Controls.Add(this._cardNumberLabel);
            this.Controls.Add(this._dash1);
            this.Controls.Add(this._cardHolderLastName);
            this.Controls.Add(this._cardHolderFirstName);
            this.Controls.Add(this._cardHolderNameLabel);
            this.Controls.Add(this._creditCardLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(379, 528);
            this.MinimumSize = new System.Drawing.Size(379, 528);
            this.Name = "PaymentDialog";
            this.Text = "CreditCardPayment";
            this.Shown += new System.EventHandler(this.ShowForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _creditCardLabel;
        private System.Windows.Forms.Label _cardHolderNameLabel;
        private System.Windows.Forms.TextBox _cardHolderFirstName;
        private System.Windows.Forms.TextBox _cardHolderLastName;
        private System.Windows.Forms.Label _dash1;
        private System.Windows.Forms.Label _dash2;
        private System.Windows.Forms.TextBox _cardNumber2;
        private System.Windows.Forms.TextBox _cardNumber1;
        private System.Windows.Forms.Label _cardNumberLabel;
        private System.Windows.Forms.Label _dash4;
        private System.Windows.Forms.TextBox _cardNumber4;
        private System.Windows.Forms.TextBox _cardNumber3;
        private System.Windows.Forms.Label _dash3;
        private System.Windows.Forms.Label _expireDateLabel;
        private System.Windows.Forms.ComboBox _expireMonth;
        private System.Windows.Forms.Label _slash;
        private System.Windows.Forms.ComboBox _expireYear;
        private System.Windows.Forms.Label _verifyCodeLabel;
        private System.Windows.Forms.TextBox _verifyCode;
        private System.Windows.Forms.TextBox _mail;
        private System.Windows.Forms.Label _mailLabel;
        private System.Windows.Forms.TextBox _address;
        private System.Windows.Forms.Label _addressLabel;
        private System.Windows.Forms.Button _submit;
    }
}