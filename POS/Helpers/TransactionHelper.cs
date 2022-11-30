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
                    cmd.CommandText = @"SELECT TOP 1 RefNbr FROM Invoice WHERE RefNbr LIKE '" + date + "%' ORDER BY RefNbr DESC";
                    dr = cmd.ExecuteReader();

                    dr.Read();
                    if (dr.HasRows)
                    {
                        RefNbr = dr[0].ToString();
                        count = int.Parse(RefNbr.Substring(8, 4));
                        RefNbr = currUnit + date + (count + 1);
                    }
                    else
                    {
                        RefNbr = currUnit + date + "1001";
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

    }
}
