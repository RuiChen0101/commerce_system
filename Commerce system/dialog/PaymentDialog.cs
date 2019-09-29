using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commerce_system
{
    public partial class PaymentDialog : Form
    {
        private const string VERIFY_CODE_LENGTH_ERROR_MESSAGE = "長度不足(3碼)";
        private const string CARD_NUMBER_LENGTH_ERROR_MESSAGE = "長度不足(4碼)";
        private const string EMPTY_ERROR_MESSAGE = "此欄不能為空";
        private const string MAIL_ERROR_MESSAGE = "非電子郵件";
        private PaymentViewModel _viewModel;
        private ErrorProvider _errorProvider;

        public PaymentDialog()
        {
            InitializeComponent();
            _viewModel = new PaymentViewModel();
            _errorProvider = new ErrorProvider();
            this._expireMonth.SelectedIndex = 0;
            this._expireYear.SelectedIndex = 0;
        }

        //on form show
        private void ShowForm(object sender, EventArgs e)
        {
            this._viewModel.ResetField(this._verifyCode.Name);
            this._submit.Enabled = false;
            this._verifyCode.Text = "";
        }

        //check input text
        private void CheckTextInput(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            if (_viewModel.CheckInputEmpty(box.Name, box.Text))
            {
                _errorProvider.SetError(box, EMPTY_ERROR_MESSAGE);
            }
            else
            {
                _errorProvider.Clear();
            }
            this._submit.Enabled = _viewModel.IsSubmitEnable();
        }

        //check card number length
        private void CheckCardNumberInput(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            if (_viewModel.CheckCardNumberLengthMatch(box.Name, box.Text))
            {
                _errorProvider.Clear();
            }
            else
            {
                _errorProvider.SetError(box, CARD_NUMBER_LENGTH_ERROR_MESSAGE);
            }
            this._submit.Enabled = _viewModel.IsSubmitEnable();
        }

        //vareify Mail format
        private void CheckMailInput(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            if (_viewModel.CheckMailFormat(box.Name, box.Text))
            {
                _errorProvider.Clear();
            }
            else
            {
                _errorProvider.SetError(box, MAIL_ERROR_MESSAGE);
            }
            this._submit.Enabled = _viewModel.IsSubmitEnable();
        }

        //check verify code length
        private void CheckVerifyCodeInput(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            if (_viewModel.CheckVerifyCodeLengthMatch(box.Name, box.Text))
            {
                _errorProvider.Clear();
            }
            else
            {
                _errorProvider.SetError(box, VERIFY_CODE_LENGTH_ERROR_MESSAGE);
            }
            this._submit.Enabled = _viewModel.IsSubmitEnable();
        }

        //varify number only input
        private void CheckNumberInput(object sender, KeyPressEventArgs e)
        {
            e.Handled = !_viewModel.IsNumberInput(e);
        }

        //varify string only input
        private void CheckStringInput(object sender, KeyPressEventArgs e)
        {
            e.Handled = !_viewModel.IsStringInput(e);
        }

        //submimt click
        private void ClickSubmit(object sender, EventArgs e)
        {
            const string FINISH = "訂購完成";
            MessageBox.Show(FINISH);
            this.DialogResult = DialogResult.Yes;
        }
    }
}
