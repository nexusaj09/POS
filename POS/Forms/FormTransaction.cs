using POS.Classes;
using POS.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace POS.Forms
{
    public partial class FormTransaction : Form
    {
        public User currUser = new User();
        TransactionHelper transactionHelper = new TransactionHelper();
        int count = 0;
        decimal _discount = 0;
        decimal _vat = 0;
        decimal _vatExempt = 0;
        decimal _total = 0;
        decimal _totaldue = 0;
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

        private void Init()
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            Clock();

            lblTotal.Text = String.Format("{0:C}", _total);
            lblDiscount.Text = String.Format("{0:C}", _discount);
            lblTotalDue.Text = String.Format("{0:C}", _totaldue);
            lblVatExempt.Text = String.Format("{0:C}", _vatExempt);
            lblVat.Text = String.Format("{0:C}", _vat);

            lblTransactionNbr.Text = transactionHelper.GetRefNbr();

            txtSearch.Select();
        }
        private void Clock()
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                lblTIME.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy") + " " + DateTime.Now.ToString("T");
            }));
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel7.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            bool IsFound = false;
            int row = 0;
            decimal price = 0;
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txtSearch.Text))
            {
                Product product = new Product();

                product = transactionHelper.InsertProductToGrid(txtSearch.Text);

                if (product == null)
                {
                    MessageBox.Show(this, "Barcode Doesn't Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
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
                            grdProductList.Rows[row].Cells[5].Value = Convert.ToInt32(grdProductList.Rows[row].Cells[5].Value) + 1;
                            GetTotalPerRow(row);
                        }
                        else
                        {
                            count++;
                            price = Convert.ToDecimal(product.FinalPrice * 1);
                            grdProductList.Rows.Add(count, product.ProductCode, product.Description, product.UOM, product.FinalPrice, 1, "0.00", price);
                            
                        }
                    }
                    else
                    {
                        count++;
                        price = Convert.ToDecimal(product.FinalPrice * 1);
                        grdProductList.Rows.Add(count, product.ProductCode, product.Description, product.UOM, product.FinalPrice, 1, "0.00",price);

                    }
                    int rowIndex = grdProductList.RowCount - 1;
                    grdProductList.CurrentCell = grdProductList.Rows[rowIndex].Cells[0];
                }
                txtSearch.Clear();


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

        public void GetTotalPerRow(int row)
        {

            grdProductList.Rows[row].Cells[7].Value = Convert.ToDecimal(grdProductList.Rows[row].Cells[4].Value.ToString()) * Convert.ToInt32(grdProductList.Rows[row].Cells[5].Value.ToString());


        }

        private void FormTransaction_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtSearch.Select();
            }
        }

        private void btnProductSearch_Click(object sender, EventArgs e)
        {
            
        }
    }
}
