using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commerce_system
{
    class PaymentViewModel
    {
        private readonly string[] _fieldList = { "_cardHolderFirstName", "_cardHolderLastName", "_cardNumber1", "_cardNumber2", "_cardNumber3", "_cardNumber4", "_verifyCode", "_mail", "_address" };
        private const string MAIL_CHECK_WORD = "@";
        private Dictionary<string, bool> _inputData = new Dictionary<string, bool>();

        public PaymentViewModel()
        {
            this.InitialData();
        }

        //save input data to dict
        public void MarkInputField(string field)
        {
            _inputData[field] = true;
        }

        ////check is empty string
        public bool CheckInputEmpty(string field, string text)
        {
            if (text.Equals(""))
            {
                this.ResetField(field);
                return true;
            }
            else
            {
                this.MarkInputField(field);
                return false;
            }
        }

        //check is mail address format
        public bool CheckMailFormat(string field, string text)
        {
            if (text.Contains(MAIL_CHECK_WORD))
            {
                this.MarkInputField(field);
                return true;
            }
            else
            {
                this.ResetField(field);
                return false;
            }
        }

        //check card number length match
        public bool CheckCardNumberLengthMatch(string field, string text)
        {
            const int LENGTH = 4;
            if (text.Length == LENGTH)
            {
                this.MarkInputField(field);
                return true;
            }
            else
            {
                this.ResetField(field);
                return false;
            }
        }

        //check verify code length match
        public bool CheckVerifyCodeLengthMatch(string field, string text)
        {
            const int LENGTH = 3;
            if (text.Length == LENGTH)
            {
                this.MarkInputField(field);
                return true;
            }
            else
            {
                this.ResetField(field);
                return false;
            }
        }

        //is number only input
        public bool IsNumberInput(KeyPressEventArgs e)
        {
            return Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar);
        }

        //is string only input
        public bool IsStringInput(KeyPressEventArgs e)
        {
            return Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar);
        }

        //is submit enable
        public bool IsSubmitEnable()
        {
            foreach (string field in _fieldList)
            {
                if (_inputData[field] == false)
                {
                    return false;
                }
            }
            return true;
        }

        //reset data
        public void ResetField(string field)
        {
            _inputData[field] = false;
        }

        //init data
        private void InitialData()
        {
            foreach (string field in _fieldList)
            {
                _inputData.Add(field, false);
            }
        }
    }
}
