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
    class PatientDBLayer
    {
        string constr = "server=ANA;database=BBMS;uid=lab;pwd=123;";
        public void Register_Patient_By__Stored_Procedure(PatientUserLayer u)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("register_new_patient", con);
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
        public DataTable View_All_Patients(PatientUserLayer u)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = new SqlCommand("view_all_patients", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "dtusers");
                    DataTable dt = ds.Tables["dtusers"];
                    return dt;
                }
            }
        }
        public void update_Patient(PatientUserLayer u)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update_patient", con);
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
        public void delete_Patient(PatientUserLayer u)
        {

try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete_patient", con);
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
        public void reverse_deleted_Patient(PatientUserLayer u)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("reverse_deleted_patient", con);
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
        public DataTable Search_for_a_Patient(PatientUserLayer u)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = new SqlCommand("search_For_a_Patient", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@searched", u.searched);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "dtusers");
                    DataTable dt = ds.Tables["dtusers"];
                    return dt;
                }
            }
        }
        public void transfer_blood(string blood_type)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Blood_transfer", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@blood_group", blood_type);
                    int row = cmd.ExecuteNonQuery();
                    con.Close();

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }



        }
    }
}