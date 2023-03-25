using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using POS.Classes;
using POS.Helpers;

namespace POS.Panels
{
    public partial class PanelPettyCash : MetroForm
    {
        public EmployeeShift EmployeeShift { get; private set; }

        private readonly User _currentUser;
        private readonly ShiftHelper _shiftHelper;

        public PanelPettyCash(User user)
        {
            _currentUser = user;
            _shiftHelper = new ShiftHelper();

            InitializeComponent();
        }

        private void PanelPettyCash_Load(object sender, EventArgs e)
        {

        }

        private void txtPettyCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtGCashPettyCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPettyCash_Enter(object sender, EventArgs e)
        {
            if (txtPettyCash.Text.Equals("0.00"))
            {
                txtPettyCash.Text = null;
            }
        }

        private void txtGCashPettyCash_Enter(object sender, EventArgs e)
        {
            if (txtGCashPettyCash.Text.Equals("0.00"))
            {
                txtGCashPettyCash.Text = null;
            }
        }

        private void txtPettyCash_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPettyCash.Text))
            {
                txtPettyCash.Text = string.Format("{0:#,##0.00}", double.Parse(txtPettyCash.Text));
            }
            else
            {
                txtPettyCash.Text = "0.00";
            }
        }

        private void txtGCashPettyCash_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGCashPettyCash.Text))
            {
                txtGCashPettyCash.Text = string.Format("{0:#,##0.00}", double.Parse(txtGCashPettyCash.Text));
            }
            else
            {
                txtGCashPettyCash.Text = "0.00";
            }
        }

        private async void btnProceed_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txtPettyCash.Text) == 0)
                {
                    MessageBox.Show("Please input your starting petty cash.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPettyCash.Focus();

                    return;
                }

                if (Convert.ToDecimal(txtGCashPettyCash.Text) == 0)
                {
                    MessageBox.Show("Please input your starting GCash petty cash", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtGCashPettyCash.Focus();

                    return;
                }
               
                var shift = new EmployeeShift
                {
                    EmployeeID = _currentUser.UserID,
                    StartTime = DateTime.Now,
                    TotalCashSalesShift = Convert.ToDecimal(txtPettyCash.Text),
                    TotalGcashSalesShift = Convert.ToDecimal(txtGCashPettyCash.Text),
                    CreatedByID = _currentUser.UserID
                };

                EmployeeShift = await _shiftHelper.StartShiftAsync(shift);                

                DialogResult = DialogResult.OK;

                Close();
            }
            catch (Exception ex)
            {

            }
        }        
    }
}
