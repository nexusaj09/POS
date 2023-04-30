using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using POS.Classes;
using POS.Enumerators;
using POS.Extensions;
using POS.Repositories;

namespace POS.Panels
{
    public partial class PanelTopupTransaction : MetroForm
    {
        public User CurrentUser { get; set; }
        public EmployeeShift EmployeeShift { get; set; }
        public TopupType TopupType { get; set; }

        private decimal _topupAmount;

        public PanelTopupTransaction()
        {
            InitializeComponent();
        }
       
        private void PanelTopupTransaction_Load(object sender, EventArgs e)
        {
            this.Text = TopupType.GetDescription();

            Init();
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

        private async void btnTopup_Click(object sender, EventArgs e)
        {
            var validations = ValidateTopupData();
            if (validations.Any())
            {
                MessageBox.Show(string.Join("\n", validations), "Validation Errors...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _topupAmount = Convert.ToDecimal(txtAmt.Text);

            var topupTransaction = new TopupTransaction
            {
                Amount = _topupAmount,
                ReferenceNumber = txtRefNbr.Text,
                TopupType = (int)TopupType,
                ShiftID = EmployeeShift.ID,
                CreatedByID = CurrentUser.UserID,
                CreatedDateTime = DateTime.Now,
            };

            var repo = new TopupTransactionRepository();
            var isSaved = await repo.SaveTopupTransactionAsync(topupTransaction);
            if (isSaved)
            {
                DialogResult = DialogResult.OK;
            }
        }

        protected void Init()
        {
            _topupAmount = 0;

            txtRefNbr.Enabled = TopupType == TopupType.TopupGCash;
            txtAmt.Text = String.Format("{0:C}", _topupAmount);
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
