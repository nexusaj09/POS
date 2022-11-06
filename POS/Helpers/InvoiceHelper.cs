using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Helpers
{
    public class InvoiceHelper: DatabaseConnection
    {

        public void LoadSupplier()
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
                //    cmd.cmd

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }


    }
}
