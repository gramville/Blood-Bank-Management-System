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
    class EmployeeDbLayer
    {
        string constr = "server=ANA;database=BBMS;uid=lab;pwd=123;";
        public string Login(EmployeeUserLayer u)
        {
            string role = "";
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("login", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", u.id);
                    cmd.Parameters.AddWithValue("@password", u.password);
                    object obj = cmd.ExecuteScalar();

                    if (obj != null)
                        role = obj.ToString();
                    else
                        role = "no role";
                    return role;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return " ";
            }
        }
        public string admin_Login(EmployeeUserLayer u)
        {
            string role = "";

            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[admin login]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", u.id);
                cmd.Parameters.AddWithValue("@password", u.password);
                object obj = cmd.ExecuteScalar();
                con.Close();
                if (obj != null)
                    role = obj.ToString();
                else
                    role = "no role";
                return role;
            }
        }
        public void Register_Employee(EmployeeUserLayer u)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("[Register new user]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@firstName", u.firstName);
                    cmd.Parameters.AddWithValue("@fathersName", u.Fathers_name);
                    cmd.Parameters.AddWithValue("@grandFathersName", u.grand_fathers_name);
                    cmd.Parameters.AddWithValue("@age", u.age);
                    cmd.Parameters.AddWithValue("@gender", u.gender);
                    cmd.Parameters.AddWithValue("@salary", u.salary);
                    cmd.Parameters.AddWithValue("@phone", u.phone);
                    cmd.Parameters.AddWithValue("@password", u.password);
                    cmd.Parameters.AddWithValue("@role", u.role);
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
        public void update_Employee(EmployeeUserLayer u)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("[update_Employee]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", u.id);
                    cmd.Parameters.AddWithValue("@fname", u.firstName);
                    cmd.Parameters.AddWithValue("@faname", u.Fathers_name);
                    cmd.Parameters.AddWithValue("@gfname", u.grand_fathers_name);
                    cmd.Parameters.AddWithValue("@age", u.age);
                    cmd.Parameters.AddWithValue("@gender", u.gender);
                    cmd.Parameters.AddWithValue("@salary", u.salary);
                    cmd.Parameters.AddWithValue("@phone", u.phone);
                    cmd.Parameters.AddWithValue("@password", u.password);
                    cmd.Parameters.AddWithValue("@role", u.role);
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
        public void delete_employee(EmployeeUserLayer u)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("[Delete Employee]", con);
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
        public void reverse_deleted_employee(EmployeeUserLayer u)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("[reverse deleted user]", con);
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
        public DataTable view_deleted_employees()
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = new SqlCommand("[view all employees]", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "dtusers");
                    DataTable dt = ds.Tables["dtusers"];
                    return dt;
                }
            }
        }
        public DataTable view_deleted_Donors()
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = new SqlCommand("[view deleted donors]", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "dtusers");
                    DataTable dt = ds.Tables["dtusers"];
                    return dt;
                }
            }
        }
        public DataTable view_restricted_donors()
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = new SqlCommand("[view restricted donors]", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "dtusers");
                    DataTable dt = ds.Tables["dtusers"];
                    return dt;
                }
            }
        }
        public DataTable view_deleted_patients()
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = new SqlCommand("[view deleted patients]", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "dtusers");
                    DataTable dt = ds.Tables["dtusers"];
                    return dt;
                }
            }
        }
        public DataTable Search_for_an_employee(EmployeeUserLayer u)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = new SqlCommand("[Search for an employee]", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@searched", u.searched);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "dtusers");
                    DataTable dt = ds.Tables["dtusers"];
                    return dt;
                }
            }
        }
        public void reverse_deleted_donor(EmployeeUserLayer u)
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
        public void reverse_deleted_Patient(EmployeeUserLayer u)
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
    }
}