using MetroFramework.Forms;
using POS.Forms;
using POS.Helpers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace POS.Panels
{
    public partial class PanelDiscounts : MetroForm
    {
        public decimal DiscountPercentage { get; set; }

        private readonly DiscountHelper _discountHelper;

        public PanelDiscounts(FormTransaction fromTran)
        {
            InitializeComponent();

            _discountHelper = new DiscountHelper();
        }

        private void PanelDiscounts_Load(object sender, System.EventArgs e)
        {
            _discountHelper.LoadDiscount(gridDiscount, txtSearch.Text);

            Init();
        }

        private void PanelDiscounts_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    Init();
                    break;

                case Keys.Escape:
                    Close();
                    break;

                case Keys.Enter:
                    // TODO: Apply discount and close this Form
                    e.Handled = true;
                    break;

                case Keys.Down:
                    if (txtSearch.ContainsFocus && gridDiscount.Rows.Count > 0)
                    {
                        gridDiscount.Select();
                        gridDiscount.Rows[0].Selected = true;
                    }
                    break;
            }
        }

        private void gridDiscount_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dataGridView = sender as DataGridView;
            if (dataGridView.Rows[e.RowIndex].Selected)
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                e.CellStyle.SelectionBackColor = Color.Coral;
            }
        }

        private void gridDiscount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DiscountPercentage = Convert.ToDecimal(gridDiscount[3, e.RowIndex].Value);
            DialogResult = DialogResult.OK;
        }

        private protected void Init()
        {
            FocusSearch();

            gridDiscount.ClearSelection();
            gridDiscount.CurrentCell = null;
        }

        private protected void FocusSearch()
        {
            txtSearch.Select();
            txtSearch.Focus();
        }
    }
}
