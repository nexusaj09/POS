using POS.Classes;
using POS.Forms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Helpers
{
    public class InvoiceHelper : DatabaseConnection
    {

        public void LoadInvoices(FormInvoice form, string search)
        {
            int count = 0;

            form.grdInvoiceList.Rows.Clear();

            try
            {
                conn.Close();
                conn.Dispose();

                connection();

                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = @"SELECT A.RefNbr, B.Supplier, A.SupplierContact, C.FullName, A.TransactionDate,A.TotalQty,A.TotalAmt
                               FROM Invoice A INNER JOIN Suppliers B
                               ON A.SupplierID = B.ID
                                INNER JOIN Users C
                                ON A.CreatedByID = C.ID
                                WHERE A.RefNbr LIKE '%" + search + "%' OR B.Supplier LIKE '%" + search + "%' ORDER BY A.RefNbr DESC";
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        count += 1; ;

                        form.grdInvoiceList.Rows.Add(count, dr["RefNbr"].ToString(), dr["Supplier"].ToString(), dr["SupplierContact"].ToString(), dr["FullName"].ToString(), Convert.ToDateTime(dr["TransactionDate"].ToString()).ToShortDateString(), dr["TotalQty"].ToString(), dr["TotalAmt"].ToString());
                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Close();
                conn.Close();
                conn.Dispose();
            }
        }

        public string GetRefNbr()
        {
            string date = DateTime.Now.ToString("yyyyMMdd");
            string RefNbr = "";
            int count = 0;

            try
            {
                conn.Close();
                conn.Dispose();

                connection();

                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = @"SELECT TOP 1 RefNbr FROM Invoice WHERE RefNbr LIKE '" + date + "%' ORDER BY RefNbr DESC";
                    dr = cmd.ExecuteReader();

                    dr.Read();
                    if (dr.HasRows)
                    {
                        RefNbr = dr[0].ToString();
                        count = int.Parse(RefNbr.Substring(8, 4));
                        RefNbr = date + (count + 1);
                    }
                    else
                    {
                        RefNbr = date + "1001";
                    }

                    return RefNbr;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return RefNbr;
            }
            finally
            {
                dr.Close();
                conn.Close();
                conn.Dispose();
            }
        }


        public void CreateInvoice(Invoice invoice)
        {
            try
            {
                conn.Close();
                conn.Dispose();

                connection();

                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = @"INSERT INTO Invoice 
                                                          (
                                                          RefNbr, 
                                                          SupplierID,
                                                          SupplierContact, 
                                                          TransactionDate, 
                                                          TotalAmt,
                                                          TotalQty,
                                                          CreatedByID,
                                                          CreatedDateTime,
                                                          LastModifiedByID,
                                                          LastModifiedDateTime                                                       
                                                          )
                                                   VALUES
                                                          (
                                                          @RefNbr, 
                                                          @SupplierID,
                                                          @SupplierContact, 
                                                          @TransactionDate, 
                                                          @TotalAmt,
                                                          @TotalQty,
                                                          @CreatedByID,
                                                          @CreatedDateTime,
                                                          @LastModifiedByID,
                                                          @LastModifiedDateTime                                                       
                                                          )";
                    cmd.Parameters.AddWithValue(@"RefNbr", invoice.RefNbr);
                    cmd.Parameters.AddWithValue(@"SupplierID", invoice.SupplierID);
                    cmd.Parameters.AddWithValue(@"SupplierContact", invoice.ContactPerson);
                    cmd.Parameters.AddWithValue(@"TransactionDate", invoice.TransactionDate);
                    cmd.Parameters.AddWithValue(@"TotalAmt", invoice.TotalAmt);
                    cmd.Parameters.AddWithValue(@"TotalQty", invoice.TotalQty);
                    cmd.Parameters.AddWithValue(@"CreatedByID", invoice.CreatedByID);
                    cmd.Parameters.AddWithValue(@"CreatedDateTime", invoice.CreatedDateTime);
                    cmd.Parameters.AddWithValue(@"LastModifiedByID", invoice.LastModifiedByID);
                    cmd.Parameters.AddWithValue(@"LastModifiedDateTime", invoice.LastModifiedDateTime);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        public void UpdateProduct(InvoiceDetail detail)
        {
            try
            {
                conn.Close();
                conn.Dispose();


                connection();

                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = @"UPDATE Products SET QTY += @Qty, LastModifiedByID = @LastModifiedByID, LastModifiedDateTime = @LastModifiedDateTime WHERE ProductCode = @ProductCode";
                    cmd.Parameters.AddWithValue(@"Qty", detail.Qty);
                    cmd.Parameters.AddWithValue(@"LastModifiedByID", detail.LastModifiedByID);
                    cmd.Parameters.AddWithValue(@"LastModifiedDateTime", detail.LastModifiedDateTime);
                    cmd.Parameters.AddWithValue(@"ProductCode", detail.ProductCode);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

        }

        public bool CreateInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            try
            {
                conn.Close();
                conn.Dispose();

                connection();

                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = @"INSERT INTO InvoiceDetails 
                                                                (
                                                                RefNbr,
                                                                ProductCode,
                                                                SupplierPrice,
                                                                Qty,
                                                                TotalPerItem,
                                                                CreatedByID,
                                                                CreatedDateTime,
                                                                LastModifiedByID,
                                                                LastModifiedDateTime
                                                                )
                                                            VALUES 
                                                                (
                                                                @RefNbr,
                                                                @ProductCode,
                                                                @SupplierPrice,
                                                                @Qty,
                                                                @TotalPerItem,
                                                                @CreatedByID,
                                                                @CreatedDateTime,
                                                                @LastModifiedByID,
                                                                @LastModifiedDateTime
                                                                )";
                    cmd.Parameters.AddWithValue(@"RefNbr", invoiceDetail.RefNbr);
                    cmd.Parameters.AddWithValue(@"ProductCode", invoiceDetail.ProductCode);
                    cmd.Parameters.AddWithValue(@"SupplierPrice", invoiceDetail.SupplierPrice);
                    cmd.Parameters.AddWithValue(@"Qty", invoiceDetail.Qty);
                    cmd.Parameters.AddWithValue(@"TotalPerItem", invoiceDetail.TotalPerItem);
                    cmd.Parameters.AddWithValue(@"CreatedByID", invoiceDetail.CreatedByID);
                    cmd.Parameters.AddWithValue(@"CreatedDateTime", invoiceDetail.CreatedDateTime);
                    cmd.Parameters.AddWithValue(@"LastModifiedByID", invoiceDetail.LastModifiedByID);
                    cmd.Parameters.AddWithValue(@"LastModifiedDateTime", invoiceDetail.LastModifiedDateTime);
                    cmd.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        public void LoadInvoiceDetail(FormCreateInvoice form, string RefNbr)
        {
            int count = 0;
            try
            {
                conn.Close();
                conn.Dispose();

                connection();

                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = @"SELECT A.InvoiceDetailID,A.ProductCode, B.Description, A.SupplierPrice,A.Qty,A.TotalPerItem
                                    FROM InvoiceDetails A INNER JOIN Products B
                                    ON A.ProductCode = B.ProductCode
                                    WHERE RefNbr = @RefNbr ORDER BY A.InvoiceDetailID";
                    cmd.Parameters.AddWithValue(@"RefNbr",RefNbr);
                        dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        count++;
                        form.grdInvoiceList.Rows.Add(count, dr["InvoiceDetailID"].ToString(), dr["ProductCode"].ToString()
                            , dr["Description"].ToString(), dr["SupplierPrice"].ToString(), dr["Qty"].ToString(), dr["TotalPerItem"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Close();
                conn.Close();
                conn.Dispose();

            }
        }

    }
}
