using MetroFramework.Forms;
using POS.Forms;
using POS.Helpers;
using System.Drawing;
using System.Windows.Forms;

namespace POS.Panels
{
    public partial class PanelDiscounts : MetroForm
    {
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

        private void gridDiscount_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dataGridView = sender as DataGridView;
            if (dataGridView.Rows[e.RowIndex].Selected)
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                e.CellStyle.SelectionBackColor = Color.Coral;
            }
        }
    }
}
