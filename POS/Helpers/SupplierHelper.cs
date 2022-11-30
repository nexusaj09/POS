using POS.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace POS.Helpers
{
    public class SupplierHelper : DatabaseConnection
    {

        public void CreateSupplier(Suppliers supplier)
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
                    cmd.CommandText = @"INSERT INTO Suppliers (
                                                               Supplier,
                                                               Address,                                                               
                                                               ContactPerson,                                                               
                                                               ContactNbr,                                                               
                                                               EMail,                                                               
                                                               CreatedByID,                                                               
                                                               CreatedDateTime,                                                               
                                                               LastModifiedDateTime,                                                               
                                                               LastModifiedByID                                                              
                                                               )
                                                        VALUES
                                                             (
                                                               @Supplier,
                                                               @Address,                                                               
                                                               @ContactPerson,                                                               
                                                               @ContactNbr,                                                               
                                                               @EMail,                                                               
                                                               @CreatedByID,                                                               
                                                               @CreatedDateTime,                                                               
                                                               @LastModifiedDateTime,                                                               
                                                               @LastModifiedByID  
                                                             )";
                    cmd.Parameters.AddWithValue(@"Supplier", supplier.Supplier);
                    cmd.Parameters.AddWithValue(@"Address", supplier.Address);
                    cmd.Parameters.AddWithValue(@"ContactPerson", supplier.ContactPerson);
                    cmd.Parameters.AddWithValue(@"ContactNbr", supplier.ContactNbr);
                    cmd.Parameters.AddWithValue(@"EMail", supplier.Email);
                    cmd.Parameters.AddWithValue(@"CreatedByID", supplier.CreatedByID);
                    cmd.Parameters.AddWithValue(@"CreatedDateTime", supplier.CreatedDateTime);
                    cmd.Parameters.AddWithValue(@"LastModifiedDateTime", supplier.LastModifiedDateTime);
                    cmd.Parameters.AddWithValue(@"LastModifiedByID", supplier.LastModifiedByID);
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

        public void LoadSupplier(DataGridView dataGrid, string search)
        {
            try
            {
                int row = 0;

                conn.Close();
                conn.Dispose();

                connection();

                dataGrid.Rows.Clear();

                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = @"SELECT ID, Supplier, Address, ContactPerson, ContactNbr,EMail FROM Suppliers WHERE Supplier LIKE '%" + search + "%' OR ContactPerson LIKE '%" + search + "%' ORDER BY ID";
                 
                    dr = cmd.ExecuteReader();

                    while(dr.Read())
                    {
                        row += 1;
                        dataGrid.Rows.Add(row, dr["ID"].ToString(), dr["Supplier"].ToString(), dr["Address"].ToString(), dr["ContactPerson"].ToString(), dr["ContactNbr"].ToString(), dr["EMail"].ToString());
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

        public void DeleteSupplier (int ID)
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
                    cmd.CommandText = @"DELETE FROM Suppliers WHERE ID = @ID";
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

        public void UpdateSupplier(Suppliers supplier)
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
                    cmd.CommandText = @"UPDATE Suppliers SET Supplier = @Supplier, Address = @Address, 
                                        ContactPerson = @ContactPerson, ContactNbr = @ContactNbr, EMail = @EMail,
                                        LastModifiedByID = @LastModifiedByID, LastModifiedDateTime = @LastModifiedDateTime
                                        WHERE ID = @ID";
                    cmd.Parameters.AddWithValue(@"Supplier", supplier.Supplier);
                    cmd.Parameters.AddWithValue(@"Address", supplier.Address);
                    cmd.Parameters.AddWithValue(@"ContactPerson", supplier.ContactPerson);
                    cmd.Parameters.AddWithValue(@"ContactNbr", supplier.ContactNbr);
                    cmd.Parameters.AddWithValue(@"EMail", supplier.Email);
                    cmd.Parameters.AddWithValue(@"LastModifiedByID", supplier.LastModifiedByID);
                    cmd.Parameters.AddWithValue(@"LastModifiedDateTime", supplier.LastModifiedDateTime);
                    cmd.Parameters.AddWithValue(@"ID", supplier.ID);
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

        public bool IsExisting(string supplier)
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
                    cmd.CommandText = @"SELECT Supplier FROM Suppliers WHERE LTRIM(RTRIM(Supplier)) = LTRIM(RTRIM('" + supplier + "')) ";
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        return true;
                    }
                    else return false;
                }
            }
            catch (Exception ex)
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
