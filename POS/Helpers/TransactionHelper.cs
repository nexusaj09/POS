using POS.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Helpers
{
    public class TransactionHelper : DatabaseConnection
    {

        public Product InsertProductToGrid(string barcode)
        {
            Product product = null;

            try
            {
                conn.Close();
                conn.Dispose();

                connection();

                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = @"SELECT ProductCode,Barcode,Description,
                                BrandName,GenericName,Classification,Formulation,
                                Category, UOM,QTY,ReOrderQty,SupplierPrice,SRP,FinalPrice,MarkUp,ExpirationDate 
                                FROM Products WHERE Barcode = '" + barcode + "'";
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        product = new Product();
                        product.ProductCode = dr["ProductCode"].ToString();
                        product.Description = dr["Description"].ToString();
                        product.UOM = dr["UOM"].ToString();
                        product.FinalPrice = Convert.ToDecimal(dr["FinalPrice"].ToString());
                    }

                }

                return product;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                dr.Close();
                conn.Close();
                conn.Dispose();
            }
        }

        public int CheckQtyProduct(string productCode)
        {
            int productQty = 0;

            try
            {


                conn.Close();
                conn.Dispose();

                connection();

                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = @"SELECT Qty FROM Products WHERE ProductCode = @productCode";
                    cmd.Parameters.AddWithValue(@"productCode", productCode);
                    productQty = Convert.ToInt32(cmd.ExecuteScalar());
                }

                return productQty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return productQty;
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
            string currUnit = Environment.MachineName;
            try
            {
                conn.Close();
                conn.Dispose();

                connection();

                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = @"SELECT TOP 1 TransactionNbr FROM Transactions WHERE TransactionNbr LIKE '" + date + "%' ORDER BY TransactionNbr DESC";
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

        public bool SaveTransaction(Transaction transaction)
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
                    cmd.CommandText = @"INSERT INTO Transactions
                                                                (
                                                                TransactionNbr,
                                                                NbrOfItems,
                                                                TotalDueAmt,
                                                                TotalAmt,
                                                                ChangeAmt,
                                                                TenderedAmt,
                                                                DiscountAmt,
                                                                VatAmt,
                                                                VatExemptAmt,
                                                                MachineName,
                                                                Status,
                                                                CreatedByID,
                                                                CreatedDateTime,
                                                                LastModifiedByID,
                                                                LastModifiedDateTime
                                                                )
                                                          VALUES
                                                                ( 
                                                                @TransactionNbr,
                                                                @NbrOfItems,
                                                                @TotalDueAmt,
                                                                @TotalAmt,
                                                                @ChangeAmt,
                                                                @TenderedAmt,
                                                                @DiscountAmt,
                                                                @VatAmt,
                                                                @VatExemptAmt,
                                                                @MachineName,
                                                                @Status,
                                                                @CreatedByID,
                                                                @CreatedDateTime,
                                                                @LastModifiedByID,
                                                                @LastModifiedDateTime
                                                                )";
                    cmd.Parameters.AddWithValue(@"TransactionNbr", transaction.TransactionNbr);
                    cmd.Parameters.AddWithValue(@"NbrOfItems", transaction.NbrOfItems);
                    cmd.Parameters.AddWithValue(@"TotalDueAmt", transaction.TotalDueAmt);
                    cmd.Parameters.AddWithValue(@"TotalAmt", transaction.TotalAmt);
                    cmd.Parameters.AddWithValue(@"ChangeAmt", transaction.ChangeAmt);
                    cmd.Parameters.AddWithValue(@"TenderedAmt", transaction.TenderedAmt);
                    cmd.Parameters.AddWithValue(@"DiscountAmt", transaction.DiscountAmt);
                    cmd.Parameters.AddWithValue(@"VatAmt", transaction.VatAmt);
                    cmd.Parameters.AddWithValue(@"VatExemptAmt", transaction.VatExemptAmt);
                    cmd.Parameters.AddWithValue(@"MachineName", transaction.MachineName);
                    cmd.Parameters.AddWithValue(@"Status", transaction.Status);
                    cmd.Parameters.AddWithValue(@"CreatedByID", transaction.CreatedByID);
                    cmd.Parameters.AddWithValue(@"CreatedDateTime", transaction.CreatedDateTime);
                    cmd.Parameters.AddWithValue(@"LastModifiedByID", transaction.LastModifiedByID);
                    cmd.Parameters.AddWithValue(@"LastModifiedDateTime", transaction.LastModifiedDateTime);
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
        public void SaveTransactionDetails(TransactionDetail transactionDetail)
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
                    cmd.CommandText = @"INSERT INTO TransactionDetails
                                                                (
                                                                TransactionNbr,
                                                                ProductCode,
                                                                UOM,
                                                                Price,
                                                                Qty,
                                                                LessAmt,
                                                                RowTotalAmt,
                                                                Status,
                                                                CreatedByID,
                                                                CreatedDateTime,
                                                                LastModifiedByID,
                                                                LastModifiedDateTime
                                                                )
                                                          VALUES
                                                                ( 
                                                                @TransactionNbr,
                                                                @ProductCode,
                                                                @UOM,
                                                                @Price,
                                                                @Qty,
                                                                @LessAmt,
                                                                @RowTotalAmt,
                                                                @Status,
                                                                @CreatedByID,
                                                                @CreatedDateTime,
                                                                @LastModifiedByID,
                                                                @LastModifiedDateTime
                                                                )";
                    cmd.Parameters.AddWithValue(@"TransactionNbr", transactionDetail.TransactionNbr);
                    cmd.Parameters.AddWithValue(@"ProductCode", transactionDetail.ProductCode);
                    cmd.Parameters.AddWithValue(@"UOM", transactionDetail.UOM);
                    cmd.Parameters.AddWithValue(@"Price", transactionDetail.Price);
                    cmd.Parameters.AddWithValue(@"Qty", transactionDetail.Qty);
                    cmd.Parameters.AddWithValue(@"LessAmt", transactionDetail.LessAmt);
                    cmd.Parameters.AddWithValue(@"RowTotalAmt", transactionDetail.RowTotalAmt);
                    cmd.Parameters.AddWithValue(@"Status", transactionDetail.Status);
                    cmd.Parameters.AddWithValue(@"CreatedByID", transactionDetail.CreatedByID);
                    cmd.Parameters.AddWithValue(@"CreatedDateTime", transactionDetail.CreatedDateTime);
                    cmd.Parameters.AddWithValue(@"LastModifiedByID", transactionDetail.LastModifiedByID);
                    cmd.Parameters.AddWithValue(@"LastModifiedDateTime", transactionDetail.LastModifiedDateTime);
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
        public void DeductProductQtyFromTransaction(TransactionDetail transactionDetail)
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
                    cmd.CommandText = @"UPDATE Products SET QTY -= @Qty WHERE ProductCode = @ProductCode";
                    cmd.Parameters.AddWithValue(@"Qty", transactionDetail.Qty);
                    cmd.Parameters.AddWithValue(@"ProductCode", transactionDetail.ProductCode);
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

        public List<Transaction> LoadHoldItems()
        {
            try
            {
                conn.Close();
                conn.Dispose();

                connection();

                List<Transaction> transaction = new List<Transaction>();

                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = @"SELECT TransactionNbr, TotalAmt FROM Transactions WHERE MachineName = @MachineName AND Status = 'Hold' ORDER BY TransactionNbr DESC";
                    cmd.Parameters.AddWithValue(@"MachineName", Environment.MachineName);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Transaction holdTran = new Transaction();
                        holdTran.TransactionNbr = dr["TransactionNbr"].ToString();
                        holdTran.TotalAmt = Convert.ToDecimal(dr["TotalAmt"].ToString());
                        transaction.Add(holdTran);

                    }

                }
                if (transaction != null)
                {

                    return transaction;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }


    }
}
