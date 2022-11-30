using POS.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Helpers
{
    public class StockAdjustmentHelper : DatabaseConnection
    {

        public void LoadProduct(DataGridView grd, string search)
        {
            try
            {
                conn.Close();
                conn.Dispose();

                connection();

                int count = 0;

                grd.Rows.Clear();

                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"SELECT ProductCode,Barcode,Description,QTY
                                FROM Products WHERE ProductCode LIKE '%" + search + "%' OR Barcode LIKE '%" + search + "%' OR Description LIKE '%" + search + "%' ORDER BY ProductCode";
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        count++;
                        grd.Rows.Add(count, dr["ProductCode"].ToString(), dr["Barcode"].ToString(), dr["Description"].ToString(), dr["QTY"].ToString());
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

        public void LoadStockAdjustment(DataGridView grd, string search)
        {
            try
            {
                conn.Close();
                conn.Dispose();

                connection();

                int count = 0;

                grd.Rows.Clear();

                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"SELECT A.AdjustmentID,A.AdjustmentNbr,A.ProductCode,B.Barcode,B.Description,A.QtyOnHand,A.QtyAdjusted,A.PrevQty,A.Action,A.Reasons,C.FullName
                            FROM Adjustments A INNER JOIN Products B
                            ON A.ProductCode = B.ProductCode
                            INNER JOIN Users C
                            ON A.CreatedByID = C.ID
                            WHERE A.ProductCode LIKE '%" + search + "%' OR B.Description LIKE '%" + search + "%' OR A.Action LIKE '%" + search + "%' OR Reasons LIKE '%" + search + "%'  ORDER BY A.AdjustmentNbr DESC";
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        count++;
                        grd.Rows.Add(count,dr["AdjustmentID"].ToString(),dr["AdjustmentNbr"].ToString(), dr["ProductCode"].ToString(), dr["Barcode"].ToString(), dr["Description"].ToString()
                                        , dr["QtyOnHand"].ToString(), dr["QtyAdjusted"].ToString(), dr["PrevQty"].ToString(), dr["Action"].ToString(), dr["Reasons"].ToString(), dr["FullName"].ToString());
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
                    cmd.CommandText = @"SELECT TOP 1 AdjustmentNbr FROM Adjustments WHERE AdjustmentNbr LIKE '%" + date + "%' ORDER BY AdjustmentNbr DESC";
                    dr = cmd.ExecuteReader();

                    dr.Read();
                    if (dr.HasRows)
                    {
                        RefNbr = dr[0].ToString();
                        count = int.Parse(RefNbr.Substring(11, 4));
                        RefNbr = "ADJ" + date + (count + 1);
                    }
                    else
                    {
                        RefNbr = "ADJ" + date + "1001";
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

        public bool InsertAdjustment(StockAdjustment adjustment)
        {
            try
            {
                conn.Close();
                conn.Dispose();

                connection();

                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"INSERT INTO ADJUSTMENTS
                                                               (
                                                               AdjustmentNbr,     
                                                               ProductCode,     
                                                               QtyOnHand,     
                                                               QtyAdjusted,
                                                               PrevQty,
                                                               Action,     
                                                               Reasons,     
                                                               CreatedByID,     
                                                               CreatedDateTime,     
                                                               LastModifiedByID,     
                                                               LastModifiedDateTime     
                                                               )
                                                         VALUES
                                                               (
                                                               @AdjustmentNbr,     
                                                               @ProductCode,     
                                                               @QtyOnHand,     
                                                               @QtyAdjusted,     
                                                               @PrevQty,     
                                                               @Action,     
                                                               @Reasons,     
                                                               @CreatedByID,     
                                                               @CreatedDateTime,     
                                                               @LastModifiedByID,     
                                                               @LastModifiedDateTime
                                                               )";
                    cmd.Parameters.AddWithValue(@"AdjustmentNbr", adjustment.AdjustmentNbr);
                    cmd.Parameters.AddWithValue(@"ProductCode", adjustment.ProductCode);
                    cmd.Parameters.AddWithValue(@"QtyOnHand", adjustment.QtyOnHand);
                    cmd.Parameters.AddWithValue(@"QtyAdjusted", adjustment.QtyAdjusted);
                    cmd.Parameters.AddWithValue(@"PrevQty", adjustment.PrevQty);
                    cmd.Parameters.AddWithValue(@"Action", adjustment.Actions);
                    cmd.Parameters.AddWithValue(@"Reasons", adjustment.Reason);
                    cmd.Parameters.AddWithValue(@"CreatedByID", adjustment.CreatedByID);
                    cmd.Parameters.AddWithValue(@"CreatedDateTime", adjustment.CreatedDateTime);
                    cmd.Parameters.AddWithValue(@"LastModifiedByID", adjustment.LastModifiedByID);
                    cmd.Parameters.AddWithValue(@"LastModifiedDateTime", adjustment.LastModifiedDateTime);
                    cmd.ExecuteNonQuery();
                }
                return true;
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
        public void AdjustProduct(int qtyAdjust, string productCode, int action)
        {
            try
            {
                conn.Close();
                conn.Dispose();

                connection();

                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    if (action == 0)
                    {
                        cmd.CommandText = @"UPDATE Products SET Qty += '" + qtyAdjust + "' WHERE ProductCode = '" + productCode + "'";
                    }
                    else
                    {
                        cmd.CommandText = @"UPDATE Products SET Qty -= '" + qtyAdjust + "' WHERE ProductCode = '" + productCode + "'";
                    }
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
    }
}
