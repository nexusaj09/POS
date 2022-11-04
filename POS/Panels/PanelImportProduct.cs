using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Microsoft.Office.Interop.Excel;
using POS.Classes;
using POS.Helpers;

namespace POS.Panels
{
    public partial class PanelImportProduct : MetroForm
    {
        public User currUser = new User();

        public ProductHelper productHelper = new ProductHelper();

        public PanelImportProduct(User user)
        {
            InitializeComponent();

            currUser = user;

            lblStockOnHand.Select();

            this.grdProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application xlApp;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                Microsoft.Office.Interop.Excel.Range xlRange;

                int xlRow = 0;
                string strFileName = "";

                openFileDialog1.Filter = "Excel File | *.xls; *.xlsx";
                openFileDialog1.FileName = "";
                openFileDialog1.ShowDialog();
                strFileName = openFileDialog1.FileName;

                if (strFileName != string.Empty)
                {
                    xlApp = new Microsoft.Office.Interop.Excel.Application();
                    xlWorkBook = xlApp.Workbooks.Open(strFileName);
                    xlWorkSheet = xlWorkBook.Worksheets[1];
                    xlRange = xlWorkSheet.UsedRange;


                    int i = 0;

                    for (xlRow = 2; xlRow <= xlRange.Rows.Count; xlRow++)
                    {
                        string descr = "";

                        descr = ConcatDescription(xlRange, xlRow);


                        if ((productHelper.IsExisting(xlRange.Cells[xlRow, 1].Text) == false && !string.IsNullOrEmpty(xlRange.Cells[xlRow, 1].Text)) && (productHelper.IsExistingBarcode(xlRange.Cells[xlRow, 2].Text) == false || string.IsNullOrEmpty(xlRange.Cells[xlRow, 2].Text)))
                        {

                            i++;
                            grdProductList.Rows.Add(i, xlRange.Cells[xlRow, 1].Text, xlRange.Cells[xlRow, 2].Text, descr, xlRange.Cells[xlRow, 3].Text,
                                    xlRange.Cells[xlRow, 4].Text, xlRange.Cells[xlRow, 5].Text, xlRange.Cells[xlRow, 6].Text, xlRange.Cells[xlRow, 7].Text,
                                    xlRange.Cells[xlRow, 8].Text, xlRange.Cells[xlRow, 9].Text, xlRange.Cells[xlRow, 10].Text, xlRange.Cells[xlRow, 11].Text,
                                    xlRange.Cells[xlRow, 12].Text, xlRange.Cells[xlRow, 13].Text, xlRange.Cells[xlRow, 14].Text);
                        }
                        else
                            continue;

                    }

                    xlWorkBook.Close();
                    xlApp.Quit();

                    lblStockOnHand.Text = i.ToString();

                    if (i >= 1)
                    {
                        if (MessageBox.Show(this, "Add this Products?", "Add Products", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {

                            foreach (DataGridViewRow row in grdProductList.Rows)
                            {
                                Product newProduct = new Product();
                                newProduct.ProductCode = grdProductList[1, row.Index].Value.ToString();
                                newProduct.ProductBarcode = grdProductList[2, row.Index].Value.ToString();
                                newProduct.Description = grdProductList[3, row.Index].Value.ToString();
                                newProduct.BrandName = grdProductList[4, row.Index].Value.ToString();
                                newProduct.GenericName = grdProductList[5, row.Index].Value.ToString();
                                newProduct.Classification = grdProductList[6, row.Index].Value.ToString();
                                newProduct.Formulation = grdProductList[7, row.Index].Value.ToString();
                                newProduct.Category = grdProductList[8, row.Index].Value.ToString();
                                newProduct.UOM = grdProductList[9, row.Index].Value.ToString();
                                newProduct.Qty = Convert.ToInt32(grdProductList[10, row.Index].Value.ToString());
                                newProduct.ReOrderQty = Convert.ToInt32(grdProductList[11, row.Index].Value.ToString());
                                newProduct.SupplierPrice = Convert.ToDecimal(grdProductList[12, row.Index].Value.ToString());
                                newProduct.SRP = Convert.ToDecimal(grdProductList[13, row.Index].Value.ToString());
                                newProduct.FinalPrice = Convert.ToDecimal(grdProductList[14, row.Index].Value.ToString());
                                newProduct.MarkUp = Convert.ToInt32(grdProductList[15, row.Index].Value.ToString());
                                newProduct.CreatedByID = currUser.UserID;
                                newProduct.CreatedDateTime = DateTime.Now;
                                newProduct.LastModifiedByID = currUser.UserID;
                                newProduct.LastModifiedDateTime = DateTime.Now;

                                productHelper.CreateProduct(newProduct);
                            }

                            MessageBox.Show(this, "New Products Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            grdProductList.Rows.Clear();
                        lblStockOnHand.Text = "0";
                        lblStockOnHand.Select();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }





        public string ConcatDescription(Microsoft.Office.Interop.Excel.Range xlRange, int row)
        {
            string descr = "";

            descr = xlRange.Cells[row, 3].Text + " " + xlRange.Cells[row, 4].Text + " " + xlRange.Cells[row, 5].Text + " " +
                xlRange.Cells[row, 6].Text + " " + xlRange.Cells[row, 8].Text;

            return descr;

        }

        private void PanelImportProduct_Load(object sender, EventArgs e)
        {
            this.grdProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }
    }
}

