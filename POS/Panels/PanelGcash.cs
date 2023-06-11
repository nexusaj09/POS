using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using POS.Classes;
using POS.Enumerators;
using POS.Panels.GCashPanels;

namespace POS.Panels
{
    public partial class PanelGcash : MetroForm
    {
        private readonly EmployeeShift _employeeShift;
        private readonly User _currentUser;

        public PanelGcash(User currentUser, EmployeeShift employeeShift)
        {
            InitializeComponent();

            _employeeShift = employeeShift;
            _currentUser = currentUser;
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
            //GCashTransaction(GCashTransactionType.CashOut);
            using (var cashOut = new PanelCashOut(_currentUser))
            {
                cashOut.EmployeeShift = _employeeShift;
                cashOut.ShowDialog();
            }
        }

        private void btnTopupGCash_Click(object sender, EventArgs e)
        {
            TopupTransaction(TopupType.TopupGCash);
        }

        private void btnTopupDrawer_Click(object sender, EventArgs e)
        {
            TopupTransaction(TopupType.TopupDrawer);
        }

        private void GCashTransaction(GCashTransactionType transactionType)
        {
            using (PanelCreateGCashTransaction gCashTransaction = new PanelCreateGCashTransaction(_currentUser, transactionType))
            {
                gCashTransaction.Text = transactionType == GCashTransactionType.CashIn ? "GCASH CASH IN" : "GCASH CASH OUT";
                gCashTransaction.EmployeeShift = _employeeShift;
                
                var result = gCashTransaction.ShowDialog();
                if (result == DialogResult.OK)
                    Close();
            }
        }

        private void TopupTransaction(TopupType topupType)
        {
            using (var topupTransaction = new PanelTopupTransaction())
            {
                topupTransaction.CurrentUser = _currentUser;
                topupTransaction.EmployeeShift = _employeeShift;
                topupTransaction.TopupType = topupType;
                var result = topupTransaction.ShowDialog();
            }
        }
    }
}
