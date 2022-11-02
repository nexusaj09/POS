using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using POS.Classes;

namespace POS.Helpers
{
    public class CategoryHelper : DatabaseConnection
    {

        public void CreateCategory(Categories currCategory)
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
                    cmd.CommandText = @"INSERT INTO Categories
                                                              (Category,                                                              
                                                               CreatedbyID,
                                                               CreatedDateTime,
                                                               LastModifiedByID,
                                                               LastModifiedDateTime)
                                                            VALUES
                                                                  (@Category,                                                                 
                                                                   @CreatedbyID,
                                                                   @CreatedDateTime,
                                                                   @LastModifiedByID,
                                                                   @LastModifiedDateTime)";
                    cmd.Parameters.AddWithValue(@"Category", currCategory.Category);
                    cmd.Parameters.AddWithValue(@"CreatedbyID", currCategory.CreatedByID);
                    cmd.Parameters.AddWithValue(@"CreatedDateTime", currCategory.CreatedDateTime);
                    cmd.Parameters.AddWithValue(@"LastModifiedByID", currCategory.LastModifiedByID);
                    cmd.Parameters.AddWithValue(@"LastModifiedDateTime", currCategory.LastModifiedDateTime);
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

        public void LoadCategories(DataGridView grid, string search)
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
                    cmd.CommandText = @"SELECT ID, Category FROM Categories WHERE Category LIKE '%" + search + "%' ORDER BY ID";

                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        count += 1;
                        grid.Rows.Add(count, dr["ID"].ToString(), dr["Category"].ToString());
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

        public void DeleteCategory(int ID)
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
                    cmd.CommandText = @"DELETE FROM Categories WHERE ID = @ID";
                    cmd.Parameters.AddWithValue(@"ID", ID);
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

        public void UpdateCategory(Categories categories)
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
                    cmd.CommandText = @"UPDATE Categories SET Category = @Category, LastModifiedByID = @LastModifiedByID, LastModifiedDateTime = @LastModifiedDateTime WHERE ID = @ID";
                    cmd.Parameters.AddWithValue(@"ID", categories.ID);
                    cmd.Parameters.AddWithValue(@"Category", categories.Category);
                    cmd.Parameters.AddWithValue(@"LastModifiedByID", categories.LastModifiedByID);
                    cmd.Parameters.AddWithValue(@"LastModifiedDateTime", categories.LastModifiedDateTime);

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

        public bool IsExisting(string category)
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
                    cmd.CommandText = @"SELECT Category FROM Categories WHERE LTRIM(RTRIM(Category)) = LTRIM(RTRIM('" + category + "')) ";
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        return true;
                    }
                    else return false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;
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
