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
    public class NotesHelper: DatabaseConnection
    {
        public void CreateNotes(Notes note)
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
                    cmd.CommandText = @"INSERT INTO Notes
                                                        (
                                                        Title,
                                                        Description,
                                                        CreatedByID,
                                                        CreatedDateTime,
                                                        LastModifiedByID,
                                                        LastModifiedDateTime
                                                        )
                                                    VALUES
                                                        (
                                                        @Title,
                                                        @Description,
                                                        @CreatedByID,
                                                        @CreatedDateTime,
                                                        @LastModifiedByID,
                                                        @LastModifiedDateTime
                                                        )";
                    cmd.Parameters.AddWithValue(@"Title", note.Title);
                    cmd.Parameters.AddWithValue(@"Description", note.Description);
                    cmd.Parameters.AddWithValue(@"CreatedByID", note.CreatedByID);
                    cmd.Parameters.AddWithValue(@"CreatedDateTime", note.CreatedDateTime);
                    cmd.Parameters.AddWithValue(@"LastModifiedByID", note.LastModifiedByID);
                    cmd.Parameters.AddWithValue(@"LastModifiedDateTime", note.LastModifiedDateTime);
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

        public void LoadNotes(DataGridView dataGrid,string search)
        {
            try
            {
                int count = 0;

                conn.Close();
                conn.Dispose();

                connection();

                dataGrid.Rows.Clear();

                using (cmd = new SqlCommand())
                {

                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = @"SELECT ID, Title, Description, CreatedDateTime FROM Notes WHERE Title LIKE '%" + search + "%' OR Description LIKE '" + search + "' ORDER BY ID";
                    dr = cmd.ExecuteReader();

                    while(dr.Read())
                    {
                        count++;

                        dataGrid.Rows.Add(count, dr["ID"].ToString(), dr["Title"].ToString(), dr["Description"].ToString(), string.Format("{0:MM/dd/yyyy hh:mm tt}", dr["CreatedDateTime"].ToString()));
                    }
                }

            }
            catch(Exception ex)
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

        public void DeleteNotes (int ID)
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
                    cmd.CommandText = @"DELETE FROM NOTES WHERE ID = @ID";
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

        public void UpdateNotes(Notes note)
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
                    cmd.CommandText = @"UPDATE Notes SET Description = @Description, Title = @Title, 
                                        LastModifiedByID = @LastModifiedByID, LastModifiedDateTime = @LastModifiedDateTime
                                        WHERE ID = @ID";
                    cmd.Parameters.AddWithValue(@"Description", note.Description);
                    cmd.Parameters.AddWithValue(@"Title", note.Title);
                    cmd.Parameters.AddWithValue(@"LastModifiedByID", note.LastModifiedByID);
                    cmd.Parameters.AddWithValue(@"LastModifiedDateTime", note.LastModifiedDateTime);
                    cmd.Parameters.AddWithValue(@"ID", note.ID);
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
