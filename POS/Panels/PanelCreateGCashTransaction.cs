using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using POS.Classes;
using POS.Enumerators;
using POS.Helpers;

namespace POS.Panels
{
    public partial class PanelCreateGCashTransaction : MetroForm
    {
        private readonly GCashTransactionHelper _gcashTransactionHelper;
        private readonly GCashTransactionType _transactionType;
        private readonly User _currentUser;
        private readonly bool _isCashIn;

        decimal fee = 0;
        decimal amt = 0;
        decimal total = 0;
        decimal change = 0;
        decimal amtTendered = 0;
        
        public EmployeeShift EmployeeShift { get; set; }
        
        public PanelCreateGCashTransaction(User currentUser, GCashTransactionType transactionType)
        {
            InitializeComponent();
            
            _currentUser = currentUser;
            _transactionType = transactionType;
            _isCashIn = transactionType == GCashTransactionType.CashIn;

            _gcashTransactionHelper = new GCashTransactionHelper();
        }

        private void PanelCreateGCashTransaction_Load(object sender, EventArgs e)
        {
            Init();

            lblGCashBalance.Text = EmployeeShift.TotalGcashSalesShift.ToString("#,##0.00");
        }

        private void txtAmt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAmt.Text))
            {
                Init();
                txtAmtTendered.Clear();
                txtAmtTendered.Enabled = !string.IsNullOrEmpty(txtAmt.Text) && _isCashIn;

                return;
            }

            amt = Convert.ToDecimal(txtAmt.Text);

            fee = GetTransactionCashInFee(amt);
            txtFee.Text = string.Format("{0:C2}", fee);

            total = amt + fee;
            lblTotal.Text = string.Format("{0:C2}", total);

            txtAmtTendered.Enabled = !string.IsNullOrEmpty(txtAmt.Text) && _isCashIn;
        }

        private void txtAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void PanelCreateGCashTransaction_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void txtAmtTendered_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtAmtTendered_TextChanged(object sender, EventArgs e)
        {
            string _amtTendered = txtAmtTendered.Text;

            if (!string.IsNullOrEmpty(txtAmtTendered.Text) && !_amtTendered.Substring(0, 1).Equals("."))
            {
                change = Convert.ToDecimal(txtAmtTendered.Text) - total;
            }
            else if (string.IsNullOrEmpty(txtAmtTendered.Text))
            {
                change = 0.00M;
            }

            lblChange.Text = String.Format("{0:C2}", change);

            amtTendered = !string.IsNullOrEmpty(txtAmtTendered.Text) ? Convert.ToDecimal(txtAmtTendered.Text) : 0.00M;
        }

        private async void btnProcess_Click(object sender, EventArgs e)
        {
            var validations = ValidateTransaction();
            if (validations.Any())
            {
                MessageBox.Show(string.Join("\n", validations),"Validation Errors...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var transactionNbr = await _gcashTransactionHelper.GetNextTransactionNbrAsync();

            var gCashTransaction = new GCashTransaction
            {
                TransactionNbr = transactionNbr,
                Amt = amt,
                TransactionFee = fee,
                RefNbr = txtRefNbr.Text,
                TotalAmt = total,
                ChangeAmt = change,
                TenderedAmt = amtTendered,
                ShiftID = EmployeeShift.ID,
                TransactionType = (int)_transactionType,
                CreatedByID = _currentUser.UserID,
                CreatedDateTime = DateTime.Now,
            };

            var isSuccessfullySaved = await _gcashTransactionHelper.SaveGCashTransactionAsync(gCashTransaction);
            if (isSuccessfullySaved)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
                
        }

        private void Init()
        {
            fee = 0;
            amt = 0;
            total = 0;
            change = 0;

            txtAmt.Select();
            lblTotal.Text = string.Format("{0:C2}", total);
            txtFee.Text = string.Format("{0:C2}", fee);
            lblChange.Text = string.Format("{0:C2}", change);
        }

        private IList<string> ValidateTransaction()
        {
            IList<string> validations = new List<string>();

            if (string.IsNullOrEmpty(txtAmt.Text))
            {
                validations.Add("• Please input an amount.");
            }

            if (string.IsNullOrEmpty(txtRefNbr.Text))
            {
                validations.Add("• Please the input GCash reference number.");
            }

            if (string.IsNullOrEmpty(txtAmtTendered.Text))
            {
                validations.Add("• Please input the tendered amount.");
            }

            return validations;
        }

        private decimal GetTransactionCashInFee(decimal amount)
        {
            decimal fee = 0;

            if (_isCashIn)
            {
                if (amount >= 10 && amount <= 1000)
                {
                    fee = 10;
                }
                else if (amount >= 1001 && amount <= 1999)
                {
                    fee = 15;
                }
                else if (amount >= 2000 && amount <= 2499)
                {
                    fee = 20;
                }
                else if (amount >= 2500 && amount <= 2999)
                {
                    fee = 25;
                }
                else if (amount >= 3000 && amount <= 3499)
                {
                    fee = 30;
                }
                else if (amount >= 3500 && amount <= 3999)
                {
                    fee = 35;
                }
                else if (amount >= 4000 && amount <= 4499)
                {
                    fee = 40;
                }
                else if (amount >= 4500 && amount <= 4999)
                {
                    fee = 45;
                }
                else if (amount >= 5000 && amount <= 5499)
                {
                    fee = 50;
                }
                else if (amount >= 5500 && amount <= 5999)
                {
                    fee = 55;
                }
                else if (amount >= 6000 && amount <= 6499)
                {
                    fee = 60;
                }
                else if (amount >= 6500 && amount <= 6999)
                {
                    fee = 65;
                }
                else if (amount >= 7000 && amount <= 7499)
                {
                    fee = 70;
                }
                else if (amount >= 7500 && amount <= 7999)
                {
                    fee = 75;
                }
                else if (amount >= 8000 && amount <= 8499)
                {
                    fee = 80;
                }
                else if (amount >= 8500 && amount <= 8999)
                {
                    fee = 85;
                }
                else if (amount >= 9000 && amount <= 9499)
                {
                    fee = 90;
                }
                else if (amount >= 9500 && amount <= 9999)
                {
                    fee = 95;
                }
                else if (amount >= 10000 && amount <= 19999)
                {
                    fee = (amount * 0.015M);
                }
                else if (amount >= 20000 && amount <= 39999)
                {
                    fee = (amount * 0.02M);
                }
                else if (amount >= 40000 && amount <= 50000)
                {
                    fee = (amount * 0.025M);
                }
                else
                {
                    fee = 0;
                }
            }
            else
            {
                if (amount >= 1 && amount <= 1000)
                {
                    fee = 10;
                }
                else if (amount >= 1001 && amount <= 9999)
                {
                    fee = (amount * 0.015M);
                }
                else
                {
                    fee = (amount * 0.025M);
                }
            }
            fee = decimal.Round(fee, 2);

            return fee;
        }        
    }
}
