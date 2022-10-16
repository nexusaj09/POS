using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POS.Helpers
{
    public class PreferenceHelper: DatabaseConnection
    {

        public Tuple<bool,string> IsVatSet()
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
                    cmd.CommandText = @"SELECT * VAT";
                    dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        return new Tuple<bool, string>(true, dr["Vat"].ToString());
                    }
                    else
                        return new Tuple<bool, string>(false, "0");


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new Tuple<bool, string>(false, "0");
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }


    }
}
