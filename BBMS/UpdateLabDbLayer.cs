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
    class UpdateLabDbLayer
    {
        string constr = "server=ANA;database=BBMS;uid=lab;pwd=123;";

        public void update_unprocessed_donation(UpdateLabUserLayer u)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update_laboratory_check", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@blood_id", u.bloodid);
                    cmd.Parameters.AddWithValue("@check", u.check);
                    int row = cmd.ExecuteNonQuery();
                    con.Close();

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public DataTable view_unprocessed_donations()
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = new SqlCommand("view_unprocessed_donations", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "dtusers");
                    DataTable dt = ds.Tables["dtusers"];
                    return dt;
                }
            }
        }
    }
}