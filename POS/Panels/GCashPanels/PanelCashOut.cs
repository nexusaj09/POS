using MetroFramework.Controls;
using MetroFramework.Forms;
using POS.Classes;
using POS.Entities;
using POS.Enumerators;
using POS.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace POS.Panels.GCashPanels
{
    public partial class PanelCashOut : MetroForm
    {
        public EmployeeShift EmployeeShift { get; set; }

        private readonly GCashTransactionHelper _gcashTransactionHelper;
        private readonly User _currentUser;

        private protected decimal _availableBalance = 0;
        private protected decimal _amount = 0;
        private protected decimal _fee = 0;
        private protected decimal _totalCashOutAmount = 0;

        public PanelCashOut(User currentUser)
        {
            InitializeComponent();

            _currentUser = currentUser;
            _gcashTransactionHelper = new GCashTransactionHelper();
        }

        private async void PanelCashOut_Load(object sender, EventArgs e)
        {
            Init();

            var gcashBalance = await _gcashTransactionHelper.GetGCashAvailableBalanceAsync(EmployeeShift.ID);
            _availableBalance = EmployeeShift.TotalGcashSalesShift + gcashBalance;

            lblGCashBalance.Text = _availableBalance.ToString("#,##0.00");
        }

        private void PanelCashOut_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    DialogResult = DialogResult.Cancel;
                    break;
                default:
                    break;
            }
        }

        private void chkSeparateFee_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender as MetroRadioButton).Checked)
                return;
     
            txtAmt.Text = string.Format("{0:#,##0.00}", _amount);
            txtFee.Text = string.Format("{0:#,##0.00}", _fee);
            lblTotalCashOutAmount.Text = string.Format("{0:#,##0.00}", _totalCashOutAmount);
        }

        private void chkAmountIncludeFee_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender as MetroRadioButton).Checked)
                return;

            txtAmt.Text = string.Format("{0:#,##0.00}", (_amount + _fee));
            txtFee.Text = string.Format("{0:#,##0.00}", 0);
            lblTotalCashOutAmount.Text = string.Format("{0:#,##0.00}", _totalCashOutAmount);
        }

        private void chkDeductFeeOnAmount_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender as MetroRadioButton).Checked)
                return;

            txtAmt.Text = string.Format("{0:#,##0.00}", _amount);
            txtFee.Text = string.Format("{0:#,##0.00}", _fee);
            lblTotalCashOutAmount.Text = string.Format("{0:#,##0.00}", (_amount - _fee));
        }
       
        private async void btnProcess_Click(object sender, EventArgs e)
        {
            var validations = ValidateTransaction();
            if (validations.Any())
            {
                MessageBox.Show(string.Join("\n", validations), "Validation Errors...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }            

            var cahOut = new GCashCashOut
            {
                ReferenceNumber = txtRefNbr.Text,
                Amount = _amount,
                Fee = _fee,
                IsFeePaySeparately = chkSeparateFee.Checked,
                IsAmountIncludesFee = chkAmountIncludeFee.Checked,
                IsFeeDeductedOnCashOutAmount = chkDeductFeeOnAmount.Checked,
                ShiftID = EmployeeShift.ID,
                CreatedByID = _currentUser.UserID,
                CreatedDateTime = DateTime.Now
            };

            var isSuccessfullySaved = await _gcashTransactionHelper.SaveCashOutAsync(cahOut);
            if (isSuccessfullySaved)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void txtAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtAmt_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAmt.Text))
            {
                _amount = Convert.ToDecimal(txtAmt.Text);
                txtAmt.Text = string.Format("{0:#,##0.00}", _amount);
                
                _fee = GetCashOutFee(_amount);
                _totalCashOutAmount = _amount;

                txtFee.Text = string.Format("{0:#,##0.00}", _fee);
                lblTotalCashOutAmount.Text = string.Format("{0:#,##0.00}", _totalCashOutAmount);

                return;
            }

            txtAmt.Text = "0.00";
        }

        private void Init()
        {
            _amount = 0;
            _fee = 0;
            _totalCashOutAmount = 0;

            txtRefNbr.Focus();
            txtRefNbr.Select();

            txtFee.Text = string.Format("{0:#,##0.00}", _fee);
            lblTotalCashOutAmount.Text = string.Format("{0:#,##0.00}", _totalCashOutAmount);
        }

        private decimal GetCashOutFee(decimal amount)
        {            
            if (amount >= 1 && amount <= 1000)            
                return 10;            

            if (amount >= 1001 && amount <= 9999)            
                return (amount * 0.015M);
            
            return (amount * 0.025M);           
        }

        private IList<string> ValidateTransaction()
        {
            IList<string> validations = new List<string>();

            if (string.IsNullOrEmpty(txtRefNbr.Text))
                validations.Add("• Please input GCash Reference Number.");

            if (string.IsNullOrEmpty(txtAmt.Text))
                validations.Add("• Please input a cash out amount.");

            return validations;
        }
    }
}
