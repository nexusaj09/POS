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
    public class UserHelper : DatabaseConnection
    {

        public User UserLogin(User currentUser)
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
                    cmd.CommandText = @"SELECT * FROM USERS WHERE Username = @Username AND Password = @Password";
                    cmd.Parameters.AddWithValue(@"Username", currentUser.Username);
                    cmd.Parameters.AddWithValue(@"Password", currentUser.Password);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        currentUser.UserID = Convert.ToInt32(dr["ID"].ToString());
                        currentUser.Password = dr["Password"].ToString();
                        currentUser.Username = dr["Username"].ToString();
                        currentUser.Fullname = dr["FullName"].ToString();
                        currentUser.Role = dr["Role"].ToString();
                        currentUser.IsActive = Convert.ToBoolean(dr["IsActive"]);
                    }
                    else
                        return null;

                }
                return currentUser;

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

        public void CreateUser(User newUser)
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
                    cmd.CommandText = @"INSERT INTO USERS
                                                         (
                                                          Username,
                                                          Password,
                                                          FullName,
                                                          Role,
                                                          CreatedDateTime,
                                                          LastModifiedDateTime,
                                                          CreatedByID,
                                                          LastModifiedByID,
                                                          IsActive
                                                          )
                                                    VALUES
                                                          (
                                                          @Username,
                                                          @Password,
                                                          @FullName,
                                                          @Role,
                                                          @CreatedDateTime,
                                                          @LastModifiedDateTime,
                                                          @CreatedByID,
                                                          @LastModifiedByID,
                                                          @IsActive
                                                          )";

                    cmd.Parameters.AddWithValue(@"Username", newUser.Username);
                    cmd.Parameters.AddWithValue(@"Password", newUser.Password);
                    cmd.Parameters.AddWithValue(@"FullName", newUser.Fullname);
                    cmd.Parameters.AddWithValue(@"Role", newUser.Role);
                    cmd.Parameters.AddWithValue(@"CreatedDateTime", newUser.CreatedDateTime);
                    cmd.Parameters.AddWithValue(@"LastModifiedDateTime", newUser.LastModifiedDateTime);
                    cmd.Parameters.AddWithValue(@"CreatedByID", newUser.CreatedByID);
                    cmd.Parameters.AddWithValue(@"LastModifiedByID", newUser.LastModifiedByID);
                    cmd.Parameters.AddWithValue(@"IsActive", newUser.IsActive);
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

        public void LoadUsers(DataGridView grid, string search)
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
                    cmd.CommandText = @"SELECT * FROM Users Where Username LIKE '%" + search + "%' OR FullName LIKE '%" + search + "%' ORDER BY ID";

                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        count += 1;
                        grid.Rows.Add(count, dr["ID"].ToString(), dr["Username"].ToString(), dr["Password"].ToString(), dr["FullName"].ToString(), dr["Role"].ToString(), dr["IsActive"]);
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

        public void DeleteUser(int userID)
        {
            try
            {

                conn.Close();
                conn.Dispose();

                connection();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = @"DELETE FROM Users WHERE ID = @userID";
                    cmd.Parameters.AddWithValue(@"userID", userID);
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

        public void UpdateUser(User user)
        {
            try
            {
                conn.Close();
                conn.Dispose();

                connection();


                using (SqlCommand cmd = new SqlCommand())
                {

                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = @"UPDATE Users SET FullName = @FULLNAME, Username = @USERNAME, 
                                                Role = @ROLE, Password = @PASSWORD, LastModifiedDateTime = @LASTMODIFIEDDATETIME, IsActive = @ISACTIVE
                                                ,LastModifiedByID = @LASTMODIFIEDBYID
                                                  WHERE ID = @USERID";
                    cmd.Parameters.AddWithValue("@PASSWORD", user.Password);
                    cmd.Parameters.AddWithValue("@FULLNAME", user.Fullname);
                    cmd.Parameters.AddWithValue("@USERNAME", user.Username);
                    cmd.Parameters.AddWithValue("@ROLE", user.Role);
                    cmd.Parameters.AddWithValue("@LASTMODIFIEDDATETIME", user.LastModifiedDateTime);
                    cmd.Parameters.AddWithValue("@USERID", user.UserID);
                    cmd.Parameters.AddWithValue("@ISACTIVE", user.IsActive);
                    cmd.Parameters.AddWithValue("@LASTMODIFIEDBYID", user.LastModifiedByID);
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

        public void CreateLoginLog(int currUserID)
        {
            try
            {
                conn.Close();
                conn.Dispose();

                connection();

                string workStation = Environment.MachineName;

                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = @"INSERT INTO Logs 
                                                        (UserID,
                                                        WorkStation,
                                                        SDate,
                                                        TimeIn)
                                                    VALUES
                                                        (@UserID,
                                                         @WorkStation,
                                                         @SDate,
                                                         @TimeIn
                                                        )";
                    cmd.Parameters.AddWithValue(@"UserID", currUserID);
                    cmd.Parameters.AddWithValue(@"WorkStation",workStation);
                    cmd.Parameters.AddWithValue(@"SDate", DateTime.Now);
                    cmd.Parameters.AddWithValue(@"TimeIn", string.Format("{0:hh:mm:ss tt}", DateTime.Now));
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
        public void CreateLogoutLog(int currUserID)
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
                    cmd.CommandText = @"UPDATE Logs SET TimeOut = @TimeOut WHERE UserID = @UserID AND SDate = @SDate AND TimeOut IS NULL";
                                                       
                    cmd.Parameters.AddWithValue(@"UserID", currUserID);
                    cmd.Parameters.AddWithValue(@"SDate", DateTime.Now.ToString("MM/dd/yyyy"));
                    cmd.Parameters.AddWithValue(@"TimeOut", string.Format("{0:hh:mm:ss tt}", DateTime.Now));
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

        public int UserCount()
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
                    cmd.CommandText = @"SELECT Count(ID) as Count FROM Users";
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        count = Convert.ToInt32(dr["Count"].ToString());

                        return count;
                    }
                    else return count;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return count;
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
