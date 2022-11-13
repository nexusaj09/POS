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
                        count += 1;;

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
        
        public void CreateInvoiceDetail(InvoiceDetail invoiceDetail)
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
                                                                
                                                                
                                                                
                                                                
                                                                
                                                                
                                                                
                                                                )";
                }
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

    }
}
