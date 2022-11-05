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
    class UserDbLayer
    {
        // change server name and  passwords 
        string constr = "server=ANA;database=BBMS;uid=lab;pwd=123;";
        public void Register_Donor_By__Stored_Procedure(UserLayer u)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("register_new_donor", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@firstName", u.firstname);
                    cmd.Parameters.AddWithValue("@fathersName", u.fathersname);
                    cmd.Parameters.AddWithValue("@grandFathersName", u.lastname);
                    cmd.Parameters.AddWithValue("@age", u.age);
                    cmd.Parameters.AddWithValue("@gender", u.gender);
                    cmd.Parameters.AddWithValue("@phone", u.phone);
                    cmd.Parameters.AddWithValue("@bloodGroup", u.bloodGroup);
                    cmd.Parameters.AddWithValue("@address", u.address);

                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                    {
                        MessageBox.Show("SAVED Successfully");
                    }




                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public DataTable View_All_Donors(UserLayer u)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = new SqlCommand("view_all_donors", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@i", 0);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "dtusers");
                    DataTable dt = ds.Tables["dtusers"];
                    return dt;
                }
            }
        }
        public void update_donor(UserLayer u)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update_donor", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", u.id);
                    cmd.Parameters.AddWithValue("@firstName", u.firstname);
                    cmd.Parameters.AddWithValue("@fathersName", u.fathersname);
                    cmd.Parameters.AddWithValue("@grandFathersName", u.lastname);
                    cmd.Parameters.AddWithValue("@age", u.age);
                    cmd.Parameters.AddWithValue("@gender", u.gender);
                    cmd.Parameters.AddWithValue("@phone", u.phone);
                    cmd.Parameters.AddWithValue("@bloodGroup", u.bloodGroup);
                    cmd.Parameters.AddWithValue("@address", u.address);
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                MessageBox.Show("Updated Successfuly");

            }

            
}
        public void delete_donor(UserLayer u)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete_donor", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", u.id);
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                MessageBox.Show("Deleted Successfuly");

            }

        }
        public DataTable Search_for_a_Donor(UserLayer u)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = new SqlCommand("search_For_a_donor", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@searched", u.searched);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "dtusers");
                    DataTable dt = ds.Tables["dtusers"];
                    return dt;
                }
            }
        }
        public void reverse_deleted_donor(UserLayer u)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("reverse_deleted_donor", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", u.id);
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }



        }
        public void Donate(UserLayer u)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Donate", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@donor_id", u.id);
                    cmd.Parameters.AddWithValue("@blood_group", u.bloodGroup);
                    int row = cmd.ExecuteNonQuery();
                    con.Close();

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }
        public void Register_Donor_with_four_restrictions(UserLayer u)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("register_donor_with_four_restrictions", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@firstName", u.firstname);
                    cmd.Parameters.AddWithValue("@fathersName", u.fathersname);
                    cmd.Parameters.AddWithValue("@grandFathersName", u.lastname);
                    cmd.Parameters.AddWithValue("@age", u.age);
                    cmd.Parameters.AddWithValue("@gender", u.gender);
                    cmd.Parameters.AddWithValue("@phone", u.phone);
                    cmd.Parameters.AddWithValue("@bloodGroup", u.bloodGroup);
                    cmd.Parameters.AddWithValue("@address", u.address);

                    
int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                    {
                        MessageBox.Show("SAVED Successfully");
                    }




                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void Register_Donor_with_three_restrictions(UserLayer u)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("register_donor_with_three_restrictions", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@firstName", u.firstname);
                    cmd.Parameters.AddWithValue("@fathersName", u.fathersname);
                    cmd.Parameters.AddWithValue("@grandFathersName", u.lastname);
                    cmd.Parameters.AddWithValue("@age", u.age);
                    cmd.Parameters.AddWithValue("@gender", u.gender);
                    cmd.Parameters.AddWithValue("@phone", u.phone);
                    cmd.Parameters.AddWithValue("@bloodGroup", u.bloodGroup);
                    cmd.Parameters.AddWithValue("@address", u.address);
                    cmd.Parameters.AddWithValue("@restriction1", u.restriction1);
                    cmd.Parameters.AddWithValue("@restriction2", u.restriction2);
                    cmd.Parameters.AddWithValue("@restriction3", u.restriction3);
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                    {
                        MessageBox.Show("SAVED Successfully");
                    }




                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void Register_Donor_with_two_restrictions(UserLayer u)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("register_donor_with_two_restrictions", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@firstName", u.firstname);
                    cmd.Parameters.AddWithValue("@fathersName", u.fathersname);
                    cmd.Parameters.AddWithValue("@grandFathersName", u.lastname);
                    cmd.Parameters.AddWithValue("@age", u.age);
                    cmd.Parameters.AddWithValue("@gender", u.gender);
                    cmd.Parameters.AddWithValue("@phone", u.phone);
                    cmd.Parameters.AddWithValue("@bloodGroup", u.bloodGroup);
                    cmd.Parameters.AddWithValue("@address", u.address);
                    cmd.Parameters.AddWithValue("@restriction1", u.restriction1);
                    cmd.Parameters.AddWithValue("@restriction2", u.restriction2);
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                    {
                        MessageBox.Show("SAVED Successfully");
                    }

                    
}
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void Register_Donor_with_one_restriction(UserLayer u)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("register_donor_with_one_restriction", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@firstName", u.firstname);
                    cmd.Parameters.AddWithValue("@fathersName", u.fathersname);
                    cmd.Parameters.AddWithValue("@grandFathersName", u.lastname);
                    cmd.Parameters.AddWithValue("@age", u.age);
                    cmd.Parameters.AddWithValue("@gender", u.gender);
                    cmd.Parameters.AddWithValue("@phone", u.phone);
                    cmd.Parameters.AddWithValue("@bloodGroup", u.bloodGroup);
                    cmd.Parameters.AddWithValue("@address", u.address);
                    cmd.Parameters.AddWithValue("@restriction1", u.restriction1);
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                    {
                        MessageBox.Show("SAVED Successfully");
                    }




                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

    }
}