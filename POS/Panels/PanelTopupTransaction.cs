using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework.Forms;
using POS.Classes;
using POS.Enumerators;
using POS.Extensions;

namespace POS.Panels
{
    public partial class PanelTopupTransaction : MetroForm
    {
        public User CurrentUser { get; set; }
        public EmployeeShift EmployeeShift { get; set; }
        public TopupType TopupType { get; set; }

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

        private void btnTopup_Click(object sender, EventArgs e)
        {

        }

        protected void Init()
        {
            txtRefNbr.Enabled = TopupType == TopupType.TopupGCash;
        }

        private IList<string> ValidateTopup()
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
