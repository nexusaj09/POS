using MetroFramework.Forms;
using POS.Forms;
using POS.Helpers;

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
    }
}
