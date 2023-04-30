using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using POS.Classes;
using POS.Enumerators;
using POS.Extensions;
using POS.Helpers;
using POS.Repositories;

namespace POS.Panels
{
    public partial class PanelTopupTransaction : MetroForm
    {
        private readonly GCashTransactionHelper _gcashRepo;
        private readonly TopupTransactionRepository _topupRepo;

        public User CurrentUser { get; set; }
        public EmployeeShift EmployeeShift { get; set; }
        public TopupType TopupType { get; set; }

        private decimal _topupAmount = 0;

        public PanelTopupTransaction()
        {
            InitializeComponent();

            _topupRepo = new TopupTransactionRepository();
            _gcashRepo = new GCashTransactionHelper();
        }
        
        private async void PanelTopupTransaction_Load(object sender, EventArgs e)
        {
            this.Text = TopupType.GetDescription();

            await InitAsync();
        }

        private void PanelTopupTransaction_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                DialogResult = DialogResult.Cancel;
        }

        private void txtAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void txtAmt_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAmt.Text))
            {
                txtAmt.Text = string.Format("{0:#,##0.00}", double.Parse(txtAmt.Text));
            }
            else
            {
                txtAmt.Text = "0.00";
            }
        }

        private async void btnTopup_Click(object sender, EventArgs e)
        {
            var validations = ValidateTopupData();
            if (validations.Any())
            {
                MessageBox.Show(string.Join("\n", validations), "Validation Errors...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _topupAmount = 0;
            decimal.TryParse(txtAmt.Text, out _topupAmount);

            var topupTransaction = new TopupTransaction
            {
                Amount = _topupAmount,
                ReferenceNumber = txtRefNbr.Text,
                TopupType = (int)TopupType,
                ShiftID = EmployeeShift.ID,
                CreatedByID = CurrentUser.UserID,
                CreatedDateTime = DateTime.Now,
            };

            var isSaved = await _topupRepo.SaveTopupTransactionAsync(topupTransaction);
            if (isSaved)
            {
                DialogResult = DialogResult.OK;
            }
        }

        protected async Task InitAsync()
        {
            _topupAmount = 0;

            txtRefNbr.Enabled = TopupType == TopupType.TopupGCash;
            txtAmt.Text = String.Format("{0:#,##0.00}", _topupAmount);

            await GetGCashBalanceAsync();            
        }

        private async Task GetGCashBalanceAsync()
        {
            var gcashBalance = await _gcashRepo.GetGCashAvailableBalanceAsync(EmployeeShift.ID);
            var availableBalance = EmployeeShift.TotalGcashSalesShift + gcashBalance;
            lblGCashBalance.Text = String.Format("{0:#,##0.00}", availableBalance);
        }

        private IList<string> ValidateTopupData()
        {
            IList<string> validations = new List<string>();

            if (string.IsNullOrEmpty(txtAmt.Text))
                validations.Add("• Please input an amount.");

            if (TopupType == TopupType.TopupGCash)
            {
                if (string.IsNullOrEmpty(txtRefNbr.Text))
                    validations.Add("• Please the input GCash Reference Number.");
            }

            return validations;
        }
    }
}
