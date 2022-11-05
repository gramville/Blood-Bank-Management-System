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
    class EmployeeUserLayer
    {
        public string firstName, Fathers_name, grand_fathers_name, gender, phone, password, role, address, searched;
        public int id, age;
        public double salary;

        // constructor for loging in
        public EmployeeUserLayer(int id, string password)
        {
            this.id = id;
            this.password = password;
        }
        //constructor for registering an employee
        public EmployeeUserLayer(String firstname, String fathersname, String lastname, int age, String gender, double salary, String phone, String password, string role, String address)
        {
            this.firstName = firstname;
            this.Fathers_name = fathersname;
            this.grand_fathers_name = lastname;
            this.age = age;
            this.gender = gender;
            this.phone = phone;
            this.address = address;
            this.salary = salary;
            this.role = role;
            this.password = password;
        }
        //constructor for updating an emplyee
        public EmployeeUserLayer(int id, String firstname, String fathersname, String lastname, int age, String gender, double salary, String phone, String password, string role, String address)
        {
            this.id = id;
            this.firstName = firstname;
            this.Fathers_name = fathersname;
            this.grand_fathers_name = lastname;
            this.age = age;
            this.gender = gender;
            this.phone = phone;
            this.address = address;
            this.salary = salary;
            this.role = role;
            this.password = password;
        }
        //constructor for deleteing and reversing a deleted Employee
        public EmployeeUserLayer(int id)
        {
            this.id = id;
        }
        //constructor for viewing all employees
        public EmployeeUserLayer()
        {


        }
        //constructor for searching for an Employee
        public EmployeeUserLayer(string searched)
        {
            this.searched = searched;
        }
        public string login()
        {
            EmployeeDbLayer e = new EmployeeDbLayer();
            return e.Login(this);
        }
        public string admin_login()
        {
            EmployeeDbLayer e = new EmployeeDbLayer();
            return e.admin_Login(this);
        }
        public void register_employee()
        {
            EmployeeDbLayer e = new EmployeeDbLayer();
            e.Register_Employee(this);
        }
        public void update_employee()
        {
            EmployeeDbLayer e = new EmployeeDbLayer();
            e.update_Employee(this);
        }
        public void delete_employee()
        {
            EmployeeDbLayer e = new EmployeeDbLayer();
            e.delete_employee(this);
        }
        public void reverse_deleted_employee()
        {
            EmployeeDbLayer e = new EmployeeDbLayer();
            e.reverse_deleted_employee(this);
        }
        public DataTable view_employees()
        {
            EmployeeDbLayer e = new EmployeeDbLayer();
            return e.view_deleted_employees();
        }
        public DataTable view_deleted_donor()
        {
            EmployeeDbLayer e = new EmployeeDbLayer();
            return e.view_deleted_Donors();
        }
        public DataTable view_restricted_donors()
        {
            EmployeeDbLayer e = new EmployeeDbLayer();
            return e.view_restricted_donors();
        }
        public DataTable view_deleted_patients()
        {
            EmployeeDbLayer e = new EmployeeDbLayer();
            return e.view_deleted_patients();

}
        public DataTable search_for_an_employee()
        {
            EmployeeDbLayer em = new EmployeeDbLayer();
            return em.Search_for_an_employee(this);
        }
        public void reverse_deleted_patient()
        {
            EmployeeDbLayer em = new EmployeeDbLayer();
            em.reverse_deleted_Patient(this);
        }
        public void reverse_deleted_donor()
        {
            EmployeeDbLayer em = new EmployeeDbLayer();
            em.reverse_deleted_donor(this);
        }



    }
}
