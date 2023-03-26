using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using POS.Classes;
using POS.Enumerators;
using POS.Helpers;

namespace POS.Panels
{
    public partial class PanelSettlePayments : MetroForm
    {
        public Transaction transaction = new Transaction();
        decimal change = 0.00M;
        TransactionHelper transactionHelper = new TransactionHelper();
        private bool isProcessed = false;
        public List<TransactionDetail> transactionDetails = new List<TransactionDetail>();

        public virtual bool IsProcessed
        {
            get { return isProcessed; }
            set { isProcessed = value; }
        }

        public PanelSettlePayments(Transaction _transaction, List<TransactionDetail> _transactionDetails)
        {
            InitializeComponent();

            transaction = _transaction;
            transactionDetails = _transactionDetails;
        }

        private void PanelSettlePayments_Load(object sender, EventArgs e)
        {
            if (transaction == null)
                return;

            lblTotalDue.Text = string.Format("{0:C}", transaction.TotalDueAmt);

            cmbPaymentType.DataSource = Enum.GetValues(typeof(PaymentType));
            cmbPaymentType.SelectedItem = PaymentType.Cash;
        }

        private void txtTenderedAmt_TextChanged(object sender, EventArgs e)
        {
            string _tenderedAmt = txtTenderedAmt.Text;

            if (!string.IsNullOrEmpty(txtTenderedAmt.Text) && !_tenderedAmt.Substring(0, 1).Equals("."))
            {
                change = Convert.ToDecimal(txtTenderedAmt.Text) - transaction.TotalDueAmt;
            }
            else if (string.IsNullOrEmpty(txtTenderedAmt.Text))
            {
                change = 0.00M;
            }

            lblChange.Text = String.Format("{0:n}", change);
        }

        private void txtTenderedAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtTenderedAmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (change < 0)
                {
                    MessageBox.Show("Tendered Amount is Insufficient!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(txtTenderedAmt.Text))
                {
                    MessageBox.Show("No Tendered Amount Entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SaveTransaction();

                    this.Close();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void cmbPaymentType_SelectedValueChanged(object sender, EventArgs e)
        {
            var paymentType = (PaymentType)((MetroFramework.Controls.MetroComboBox)sender).SelectedItem;

            switch (paymentType)
            {
                case PaymentType.Cash:
                    txtTenderedAmt.Enabled = true;
                    txtTenderedAmt.Focus();

                    txtGCashReferenceNo.Clear();
                    txtGCashReferenceNo.Enabled = false;
                    break;

                case PaymentType.GCash:
                    txtTenderedAmt.Clear();
                    txtTenderedAmt.Text = string.Format("{0:#,##0.00}", transaction.TotalDueAmt);
                    txtTenderedAmt.Enabled = false;

                    txtGCashReferenceNo.Enabled = true;
                    txtGCashReferenceNo.Focus();                    
                    break;
            }
        }

        private void txtGCashReferenceNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtGCashReferenceNo.Text))
                {
                    MessageBox.Show("Please input the GCash Reference No. for this transaction before proceeding.", "GCash Reference Number...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var dialogResult = MessageBox.Show("Please double check the GCash Reference Number. It cannot be modified once you confirm this transactions.", "Transaction Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    SaveTransaction();
                    Close();
                }
            }
        }

        private void SaveTransaction()
        {
            var paymentType = (PaymentType)cmbPaymentType.SelectedItem;

            transaction.PaymentType = (int)paymentType;
            transaction.GCashReferenceNo = txtGCashReferenceNo.Text;
            transaction.ChangeAmt = change;
            transaction.TenderedAmt = Convert.ToDecimal(txtTenderedAmt.Text);

            isProcessed = transactionHelper.SaveTransaction(transaction);

            foreach (TransactionDetail item in transactionDetails)
            {
                transactionHelper.SaveTransactionDetails(item);
                transactionHelper.DeductProductQtyFromTransaction(item);
            }
        }
    }
}
