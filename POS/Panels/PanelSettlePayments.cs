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
                    transaction.ChangeAmt = change;
                    transaction.TenderedAmt = Convert.ToDecimal(txtTenderedAmt.Text);

                    isProcessed = transactionHelper.SaveTransaction(transaction);

                    foreach(TransactionDetail item in transactionDetails)
                    {
                        transactionHelper.SaveTransactionDetails(item);
                        transactionHelper.DeductProductQtyFromTransaction(item);
                    }
                    
                    this.Close();
                }


            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void PanelSettlePayments_Load(object sender, EventArgs e)
        {
            if (transaction == null) return;

            lblTotalDue.Text = string.Format("{0:C}", transaction.TotalDueAmt);

        }
    }
}
