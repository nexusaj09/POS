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
    public class DiscountHelper : DatabaseConnection
    {

        public void CreateDiscount(Discount currDiscount)
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
                    cmd.CommandText = @"INSERT INTO DISCOUNTS
                                                        (
                                                        Description,
                                                        DiscountPercentage,
                                                        CreatedDateTime,
                                                        CreatedByID,
                                                        LastModifiedByID,
                                                        LastModifiedDateTime
                                                        ) 
                                                  VALUES
                                                        (
                                                        @Description,
                                                        @DiscountPercentage,
                                                        @CreatedDateTime,
                                                        @CreatedByID,
                                                        @LastModifiedByID,
                                                        @LastModifiedDateTime
                                                        )";
                    cmd.Parameters.AddWithValue(@"Description", currDiscount.Description);
                    cmd.Parameters.AddWithValue(@"DiscountPercentage", currDiscount.DiscountPercentage);
                    cmd.Parameters.AddWithValue(@"CreatedDateTime", currDiscount.CreatedDateTime);
                    cmd.Parameters.AddWithValue(@"CreatedByID", currDiscount.CreatedByID);
                    cmd.Parameters.AddWithValue(@"LastModifiedByID", currDiscount.LastModifiedByID);
                    cmd.Parameters.AddWithValue(@"LastModifiedDateTime", currDiscount.LastModifiedDateTime);
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

        public void LoadDiscount(DataGridView grid, string search)
        {
            try
            {
                int count = 0;

                grid.Rows.Clear();

                conn.Close();
                conn.Dispose();

                connection();

                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = @"SELECT ID,Description,DiscountPercentage FROM Discounts WHERE Description LIKE '%" + search + "%' ORDER BY ID";

                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        count += 1;
                        grid.Rows.Add(count, dr["ID"].ToString(), dr["Description"].ToString(), dr["DiscountPercentage"].ToString());
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

        public void DeleteDiscount (int ID)
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
                    cmd.CommandText = @"DELETE FROM Discounts WHERE ID = @ID";
                    cmd.Parameters.AddWithValue(@"ID", ID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        public void UpdateDiscount (Discount updateDiscount)
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
                    cmd.CommandText = @"UPDATE Discounts SET Description = @Description, DiscountPercentage = @DiscountPercentage, 
                                        LastModifiedByID = @LastModifiedByID, LastModifiedDateTime = @LastModifiedDateTime
                                        WHERE ID = @ID";
                    cmd.Parameters.AddWithValue(@"Description", updateDiscount.Description);
                    cmd.Parameters.AddWithValue(@"DiscountPercentage", updateDiscount.DiscountPercentage);
                    cmd.Parameters.AddWithValue(@"LastModifiedByID", updateDiscount.LastModifiedByID);
                    cmd.Parameters.AddWithValue(@"LastModifiedDateTime", updateDiscount.LastModifiedDateTime);
                    cmd.Parameters.AddWithValue(@"ID", updateDiscount.ID);
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
