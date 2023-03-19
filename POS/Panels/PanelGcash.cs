using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using POS.Enumerators;

namespace POS.Panels
{
    public partial class PanelGcash : MetroForm
    {
        public PanelGcash()
        {
            InitializeComponent();
        }

        private void PanelGcash_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void btnCashIN_Click(object sender, EventArgs e)
        {
            GCashTransaction(GCashTransactionType.CashIn);
        }        

        private void btnCashOut_Click(object sender, EventArgs e)
        {
            GCashTransaction(GCashTransactionType.CashOut);
        }

        private void GCashTransaction(GCashTransactionType transactionType)
        {
            using (PanelCreateGCashTransaction gCashTransaction = new PanelCreateGCashTransaction())
            {
                gCashTransaction.Text = transactionType == GCashTransactionType.CashIn ? "GCASH CASH IN" : "GCASH CASH OUT";
                gCashTransaction.IsCashIn = transactionType == GCashTransactionType.CashIn;
                gCashTransaction.ShowDialog();
                gCashTransaction.Dispose();
                Close();
            }
        }
    }
}
