
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace BBMS
{
    class BloodDbLayer
    {
        // change server name and  passwords 
        string constr = "server=ANA;database=BBMS;uid=lab;pwd=123;";
        public string quantity_of_blood()
        {
            string quantity = "";
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("quantity_of_blood_types", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@quantity", SqlDbType.VarChar, int.MaxValue).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    quantity = cmd.Parameters["@quantity"].Value.ToString();

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return quantity;
        }
    }
}