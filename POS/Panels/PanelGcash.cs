using System;
using System.Windows.Forms;
using MetroFramework.Forms;

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
            GCashTransaction("CASH IN");
        }        

        private void btnCashOut_Click(object sender, EventArgs e)
        {
            GCashTransaction("CASH OUT");
        }

        private void GCashTransaction(string mode)
        {
            using (PanelCreateGCashTransaction gCashTransaction = new PanelCreateGCashTransaction())
            {

                gCashTransaction.Text = mode.Equals("CASH IN") ? "GCASH CASH IN" : "GCASH CASH OUT";
                gCashTransaction.IsCashIn = mode.Equals("CASH IN") ? true : false;
                gCashTransaction.ShowDialog();
                gCashTransaction.Dispose();
                Close();
            }
        }
    }
}
