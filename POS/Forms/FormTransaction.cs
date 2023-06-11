using POS.Classes;
using POS.Helpers;
using POS.Models;
using POS.Models.Product;
using POS.Panels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace POS.Forms
{
    public partial class FormTransaction : Form
    {
        public User currUser = new User();
        TransactionHelper transactionHelper = new TransactionHelper();
        UserHelper userHelper = new UserHelper();

        int count = 0;
        decimal _discount = 0;
        decimal _vat = 0;
        decimal _vatExempt = 0;
        decimal _total = 0;
        decimal _totaldue = 0;
        int _adjustedQty = 0;
        int _qtyCount = 0;
        decimal _rowTotal = 0;
        static decimal _vatPct = 1.12M;
        bool isClosing = false;
        Product product = new Product();
        Transaction transaction = new Transaction();
        TransactionDetail transactionDetail = new TransactionDetail();

        bool shifted = false;

        public EmployeeShift EmployeeShift { get; private set; }
        public List<ProductDiscount> ProductDiscounts { get; private set; }

        public FormTransaction(User user)
        {
            InitializeComponent();

            currUser = user;
            lblUser.Text = currUser.Fullname;
            lblRole.Text = currUser.Role;
            lblPCName.Text = Environment.MachineName;
        }

        private void FormTransaction_Load(object sender, EventArgs e)
        {
            Init();
        }        
        
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (isClosing == false)
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    lblTIME.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy") + " " + DateTime.Now.ToString("T");
                }));
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel7.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txtSearch.Text))
            {
                product = transactionHelper.InsertProductToGrid(txtSearch.Text);

                AddProduct(product);
            }
        }

        private void grdProductList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dataGridView = sender as DataGridView;
            if (dataGridView.Rows[e.RowIndex].Selected)
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                // edit: to change the background color:
                e.CellStyle.SelectionBackColor = Color.Coral;
                e.CellStyle.SelectionForeColor = Color.White;
            }
        }

        private void FormTransaction_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    btnSettlePayment.PerformClick();
                    break;
                case Keys.F1:
                    txtSearch.Select();
                    break;
                case Keys.F2:
                    btnNewTransaction.PerformClick();
                    break;
                case Keys.F3:
                    btnProductSearch.PerformClick();
                    break;
                case Keys.F4:
                    btnHoldTransaction.PerformClick();
                    break;
                case Keys.F6:
                    btnDiscount.PerformClick();
                    break;
                case Keys.F8:
                    btnAdjustQty.PerformClick();
                    break;
                case Keys.F11:
                    btnShift.PerformClick();
                    break;
                case Keys.F12:
                    btnClose.PerformClick();
                    break;
                case Keys.Up:
                    if (txtSearch.ContainsFocus)
                    {
                        grdProductList.Select();
                        break;
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnProductSearch_Click(object sender, EventArgs e)
        {
            using (PanelProducts products = new PanelProducts(this, true))
            {
                products.ShowDialog();
                products.Dispose();
                txtSearch.Select();
            }
        }

        private void btnAdjustQty_Click(object sender, EventArgs e)
        {
            if (grdProductList.CurrentCell == null) return;

            int productQty = 0;

            int? currRow = grdProductList.CurrentCell.RowIndex;

            int currQty = Convert.ToInt32(grdProductList[5, currRow.Value].Value.ToString());

            using (PanelAdjustQty panelAdjust = new PanelAdjustQty(this))
            {
                panelAdjust.ShowDialog();
                _adjustedQty = Convert.ToInt32(panelAdjust.AdjustedQty);
                _adjustedQty = _adjustedQty == 0 ? currQty : _adjustedQty;

                panelAdjust.Dispose();
                txtSearch.Select();
            }

            productQty = transactionHelper.CheckQtyProduct(grdProductList[1, currRow.Value].Value.ToString());

            if (productQty - _adjustedQty >= 0)
            {
                AdjustedRowQty(currRow, _adjustedQty);

                GetTransactionTotal();
            }
            else
            {
                MessageBox.Show("Qty entered is greater than stock!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void btnGcash_Click(object sender, EventArgs e)
        {
            using (PanelGcash panelGcash = new PanelGcash(currUser, EmployeeShift))
            {
                panelGcash.ShowDialog();
                txtSearch.Select();
            }
        }

        private void btnSettlePayment_Click(object sender, EventArgs e)
        {
            SaveTransaction("Pending", true);
        }

        private void btnHoldTransaction_Click(object sender, EventArgs e)
        {
            if (grdProductList.Rows.Count > 0)
            {
                SaveTransaction("Hold", false);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (currUser.Role.Equals("Cashier"))
            {
                if (MessageBox.Show("Are you sure to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    userHelper.CreateLogoutLog(currUser.UserID);
                    MessageBox.Show("Logout Successfully", "Logged Out", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormInit login = new FormInit();
                    login.Show();
                }
            }

            isClosing = true;
            this.Close();
        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {
            using (PanelViewCart cart = new PanelViewCart())
            {
                cart.ShowDialog();
                cart.Dispose();
                txtSearch.Select();
            }
        }

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            NewTransaction();
        }

        private void btnShift_Click(object sender, EventArgs e)
        {
            if (btnShift.Text.Equals("START SHIFT") && shifted == false)
            {
                shifted = true;

                EnableDisableShift(true);

                using (PanelPettyCash panelPettyCash = new PanelPettyCash(currUser))
                {
                    var result = panelPettyCash.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        EmployeeShift = panelPettyCash.EmployeeShift;
                    }
                }
            }
            else if (btnShift.Text.Equals("END SHIFT") && shifted == true)
            {
                EnableDisableShift(false);
            }
            else
            {
                MessageBox.Show("You Already Shifted Today!", "Already Shifted", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            using (var discount = new PanelDiscounts(this))
            {
                var result = discount.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // Get products that are eligible for the discount
                    var eligibleProductDiscounts = GetEligibleProductDiscounts(discount.DiscountID, discount.DiscountPercentage);
                    var pnlProductDiscountSelection = new PanelProductDiscountSelection(discount.DiscountPercentage, eligibleProductDiscounts);

                    var selectedResult = pnlProductDiscountSelection.ShowDialog();
                    if (selectedResult == DialogResult.OK)
                    {
                        // Apply the discount on the selected eligible discount product
                        var selectedEligibleProductDiscounts = eligibleProductDiscounts.Where(x => x.IsSelected);
                        foreach (var selectedDiscount in selectedEligibleProductDiscounts)
                        {
                            var productCode = selectedDiscount.ProductCode;
                            foreach (DataGridViewRow product in grdProductList.Rows)
                            {
                                if (grdProductList.Rows[product.Index].Cells[1].Value.ToString() != productCode)
                                    continue;

                                grdProductList.Rows[product.Index].Cells[6].Value = selectedDiscount.DiscountAmount;
                            }
                        }

                        GetTransactionTotal();
                        txtSearch.Select();
                    }
                }
            }
        }

        private void Init()
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            Clock();

            foreach (DataGridViewColumn column in grdProductList.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            EnableDisableShift(false);
            NewTransaction();
        }

        public void NewTransaction()
        {
            _qtyCount = 0;
            _discount = 0;
            _vat = 0;
            _vatExempt = 0;
            _total = 0;
            _totaldue = 0;
            count = 0;

            lblTotal.Text = String.Format("{0:C}", _total);
            lblDiscount.Text = String.Format("{0:C}", _discount);
            lblTotalDue.Text = String.Format("{0:C}", _totaldue);
            lblVatExempt.Text = String.Format("{0:C}", _vatExempt);
            lblVat.Text = String.Format("{0:C}", _vat);
            lblNbrOfItems.Text = "0";

            lblTransactionNbr.Text = transactionHelper.GetRefNbr();

            grdProductList.Rows.Clear();

            txtSearch.Select();
        }

        public void AdjustedRowQty(int? row, int value)
        {
            grdProductList[5, row.Value].Value = value;
        }

        public void AddProduct(Product product)
        {
            bool IsFound = false;
            int row = 0;
            int productQty = 0; ;
            int rowQty = 0;

            if (product == null)
            {
                MessageBox.Show(this, "Barcode Doesn't Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                productQty = transactionHelper.CheckQtyProduct(product.ProductCode);

                if (productQty > 0)
                {
                    if (grdProductList.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow r in grdProductList.Rows)
                        {
                            if (r.Cells[1].Value.Equals(product.ProductCode))
                            {
                                IsFound = true;
                                row = r.Index;
                                break;
                            }
                        }
                        if (IsFound)
                        {
                            rowQty = Convert.ToInt32(grdProductList.Rows[row].Cells[5].Value);
                            if (productQty > rowQty)
                                grdProductList.Rows[row].Cells[5].Value = Convert.ToInt32(grdProductList.Rows[row].Cells[5].Value) + 1;
                            else
                                MessageBox.Show("Product is Out of Stock!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            count++;
                            grdProductList.Rows.Add(count, product.ProductCode, product.Description, product.UOM, product.FinalPrice, 1, 0.00M, product.FinalPrice);
                        }
                    }
                    else
                    {
                        count++;
                        grdProductList.Rows.Add(count, product.ProductCode, product.Description, product.UOM, product.FinalPrice, 1, 0.00M, product.FinalPrice);
                    }

                    GetTransactionTotal();
                    int rowIndex = grdProductList.RowCount - 1;
                    grdProductList.CurrentCell = grdProductList.Rows[rowIndex].Cells[0];
                }
                else
                {
                    MessageBox.Show("Product is Out of Stock!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            txtSearch.Clear();
        }

        public decimal GetTotalPerRow(int row)
        {
            var qty = Convert.ToDecimal(grdProductList.Rows[row].Cells[5].Value);
            var unitAmount = Convert.ToDecimal(grdProductList.Rows[row].Cells[4].Value);
            var discountAmount = Convert.ToDecimal(grdProductList.Rows[row].Cells[6].Value);

            var lineAmount = (qty * unitAmount) - discountAmount;
            return lineAmount;
        }

        public void GetTransactionTotal()
        {
            if (grdProductList.Rows.Count > 0)
            {
                _qtyCount = 0;
                _discount = 0;
                _vat = 0;
                _vatExempt = 0;
                _total = 0;
                _totaldue = 0;

                foreach (DataGridViewRow item in grdProductList.Rows)
                {
                    _rowTotal = GetTotalPerRow(item.Index);
                    grdProductList.Rows[item.Index].Cells[7].Value = _rowTotal;
                    _qtyCount += Convert.ToInt32(grdProductList.Rows[item.Index].Cells[5].Value);
                    _total += _rowTotal;
                    _discount += Convert.ToDecimal(grdProductList.Rows[item.Index].Cells[6].Value);
                }
                _vatExempt = _total / _vatPct;
                _vat = (_vatExempt * _vatPct) - _vatExempt;
                _totaldue = _total - _discount;                

                lblNbrOfItems.Text = string.Format("{0:#,###}", _qtyCount);

                lblDiscount.Text = string.Format("{0:C2}", _discount);
                
                lblVat.Text = string.Format("{0:C2}", _vat);
                lblVatExempt.Text = string.Format("{0:C2}", _vatExempt);

                lblTotal.Text = string.Format("{0:C2}", _total);
                lblTotalDue.Text = string.Format("{0:C2}", _totaldue);
            }
        }

        private void SaveTransaction(string Status, bool isSettlePayment)
        {
            bool _isProcessed = false;

            if (grdProductList.Rows.Count == 0) return;
            transaction = new Transaction();
            transaction.TransactionNbr = lblTransactionNbr.Text;
            transaction.NbrOfItems = Convert.ToInt32(lblNbrOfItems.Text);
            transaction.TotalAmt = _total;
            transaction.DiscountAmt = _discount;
            transaction.TotalDueAmt = _totaldue;
            transaction.MachineName = Environment.MachineName;
            transaction.VatAmt = _vat;
            transaction.VatExemptAmt = _vatExempt;
            transaction.Status = Status;
            transaction.CreatedByID = currUser.UserID;
            transaction.CreatedDateTime = DateTime.Now;
            transaction.LastModifiedByID = currUser.UserID;
            transaction.LastModifiedDateTime = DateTime.Now;

            List<TransactionDetail> transactionDetailList = new List<TransactionDetail>();

            foreach (DataGridViewRow row in grdProductList.Rows)
            {
                transactionDetail = new TransactionDetail();
                transactionDetail.TransactionNbr = lblTransactionNbr.Text;
                transactionDetail.ProductCode = grdProductList[1, row.Index].Value.ToString();
                transactionDetail.UOM = grdProductList[3, row.Index].Value.ToString();
                transactionDetail.Price = Convert.ToDecimal(grdProductList[4, row.Index].Value);
                transactionDetail.Qty = Convert.ToInt32(grdProductList[5, row.Index].Value);
                transactionDetail.LessAmt = Convert.ToDecimal(grdProductList[6, row.Index].Value);
                transactionDetail.RowTotalAmt = Convert.ToDecimal(grdProductList[7, row.Index].Value);
                transactionDetail.CreatedByID = currUser.UserID;
                transactionDetail.CreatedDateTime = DateTime.Now;
                transactionDetail.LastModifiedByID = currUser.UserID;
                transactionDetail.LastModifiedDateTime = DateTime.Now;
                transactionDetail.Status = Status;
                transactionDetailList.Add(transactionDetail);
            }

            if (isSettlePayment)
            {
                using (PanelSettlePayments payments = new PanelSettlePayments(transaction, transactionDetailList))
                {
                    payments.ShowDialog();
                    _isProcessed = payments.IsProcessed;
                    payments.Dispose();
                }

                if (_isProcessed)
                {
                    NewTransaction();
                }
            }
            else
            {
                _isProcessed = transactionHelper.SaveTransaction(transaction);

                if (_isProcessed)
                {
                    foreach (TransactionDetail row in transactionDetailList)
                    {
                        transactionHelper.SaveTransactionDetails(row);
                    }

                    NewTransaction();
                }
            }
        }

        private void Clock()
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void EnableDisableShift(bool enable)
        {
            txtSearch.Enabled = enable;
            btnGcash.Enabled = enable;
            btnNewTransaction.Enabled = enable;
            btnProductSearch.Enabled = enable;
            btnHoldTransaction.Enabled = enable;
            btnViewCart.Enabled = enable;
            btnDiscount.Enabled = enable;
            btnAdjustQty.Enabled = enable;
            btnVoid.Enabled = enable;
            btnXReading.Enabled = enable;
            btnSettlePayment.Enabled = enable;
            button9.Enabled = enable;

            btnShift.Text = enable == false ? "START SHIFT" : "END SHIFT";
        }

        public async Task AddProductDiscountsAsync(string productCode)
        {
            // Get the product discounts here
            var productHelper = new ProductHelper();
            if (ProductDiscounts is null || !ProductDiscounts.Any())
            {
                ProductDiscounts = (await productHelper.GetProductDiscountsAsync(productCode)).ToList();
                return;
            }
                
            var productDiscounts = ProductDiscounts.Where(x => x.ProductCode == productCode).ToList();
            if (productDiscounts is null || !productDiscounts.Any())
            {
                var discounts = (await productHelper.GetProductDiscountsAsync(productCode)).ToList();   
                if (discounts.Any())
                    ProductDiscounts.AddRange(discounts);
            }
        }

        private IEnumerable<EligibleProductDiscount> GetEligibleProductDiscounts(int discountId, decimal discountPercent)
        {
            var discountPercentage = discountPercent / 100;
            var productDiscounts = ProductDiscounts.Where(x => x.DiscountID == discountId);

            var eligibleProductDiscounts = new List<EligibleProductDiscount>();

            foreach (var item in productDiscounts)
            {
                var productCode = item.ProductCode;
                foreach (DataGridViewRow product in grdProductList.Rows)
                {
                    if (grdProductList.Rows[product.Index].Cells[1].Value.ToString() != productCode)
                        continue;

                    var productDescription = grdProductList.Rows[product.Index].Cells[1].Value.ToString();
                    var qty = Convert.ToDecimal(grdProductList.Rows[product.Index].Cells[5].Value);
                    var unitPrice = Convert.ToDecimal(grdProductList.Rows[product.Index].Cells[4].Value);
                    var discountAmount = qty * (unitPrice * discountPercentage);
                    var lineAmount = (qty * unitPrice) - discountAmount;

                    eligibleProductDiscounts.Add(new EligibleProductDiscount
                    {
                        IsSelected = true,
                        ProductCode = productCode,
                        Description = productDescription,
                        Qty = qty,
                        UnitAmount = unitPrice,
                        DiscountAmount = discountAmount,
                        LineAmount = lineAmount,
                    });
                }
            }

            return eligibleProductDiscounts;
        }
    }
}
