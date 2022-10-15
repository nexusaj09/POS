using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Helpers
{
    public class DatabaseConnection
    {
        public static SqlConnectionStringBuilder sqlbuilder = new SqlConnectionStringBuilder();
        public string ConnectionString;
        public string user;
        public string password;
        public string dataSource;
        public string initialCatalog;
        RegistryKey Key;
        public string KeyValue;
        public SqlConnection conn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public bool SaveConnectionStringRegistry()
        {
            try
            {
                try
                {
                    sqlbuilder.DataSource = dataSource;
                    sqlbuilder.InitialCatalog = initialCatalog;
                    sqlbuilder.UserID = user;
                    sqlbuilder.Password = password;
                    ConnectionString = sqlbuilder.ConnectionString;
                    if (Registry.CurrentUser.OpenSubKey("Software\\POS\\System") == null)
                    {
                        Key = Registry.CurrentUser.CreateSubKey("Software\\POS\\System");
                    }
                    Registry.SetValue("HKEY_CURRENT_USER\\Software\\POS\\System\\Settings", "POS", ConnectionString);

                }
                finally
                {
                    Registry.CurrentUser.Close();
                }
                KeyValue = Conversions.ToString(Registry.GetValue("HKEY_CURRENT_USER\\Software\\POS\\System\\Settings", "POS", "Default Value"));

                if (KeyValue == null)
                {
                    return false;
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void connection()
        {
            try
            {
                DisplayConnSetup();

                sqlbuilder.DataSource = dataSource;
                sqlbuilder.InitialCatalog = initialCatalog;
                sqlbuilder.UserID = user;
                sqlbuilder.Password = password;
                sqlbuilder.IntegratedSecurity = false;
                ConnectionString = sqlbuilder.ConnectionString;
                conn.ConnectionString = ConnectionString;
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void DisplayConnSetup()
        {
            KeyValue = Conversions.ToString(Registry.GetValue("HKEY_CURRENT_USER\\Software\\POS\\System\\Settings", "POS", "Default Value"));
            if (Strings.Trim(KeyValue) == "")
            {
                MessageBox.Show("Please Set Up Server Connection", "Server not set up", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(KeyValue.ToString());
                user = builder.UserID;
                password = builder.Password;
                dataSource = builder.DataSource;
                initialCatalog = builder.InitialCatalog;
            }
        }

    }
}

