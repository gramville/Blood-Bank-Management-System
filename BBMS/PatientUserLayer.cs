using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BBMS
{
    class PatientUserLayer
    {
        public string firstname, fathersname, lastname, gender, phone, bloodGroup, address, searched;
        public int age, id;

        // constructor for registering a new Patient
        public PatientUserLayer(String firstname, String fathersname, String lastname, int age, String gender, String phone, String bloodGroup, String address)
        {
            this.firstname = firstname;
            this.fathersname = fathersname;
            this.lastname = lastname;
            this.age = age;
            this.gender = gender;
            this.phone = phone;
            this.bloodGroup = bloodGroup;
            this.address = address;
        }
        // constructor for viewing all Patients
        public PatientUserLayer()
        {

        }
        // constructor for updating a Patient
        public PatientUserLayer(int id, String firstname, String fathersname, String lastname, int age, String gender, String phone, String bloodGroup, String address)
        {
            this.id = id;
            this.firstname = firstname;
            this.fathersname = fathersname;
            this.lastname = lastname;
            this.age = age;
            this.gender = gender;
            this.phone = phone;
            this.bloodGroup = bloodGroup;
            this.address = address;
        }
        // constructor for deleting  a Patient
        public PatientUserLayer(int id)
        {
            this.id = id;

        }
        // constructor for searching a Patient 
        public PatientUserLayer(String searched)
        {
            this.searched = searched;
        }

        public void Register_Patient()
        {
            PatientDBLayer Register_Patient = new PatientDBLayer();
            Register_Patient.Register_Patient_By__Stored_Procedure(this);
        }
        public DataTable View_Patients()
        {
            PatientDBLayer db = new PatientDBLayer();
            DataTable dt = db.View_All_Patients(this);
            return dt;
        }
        public void update_Patient()
        {
            PatientDBLayer u = new PatientDBLayer();
            u.update_Patient(this);
        }
        public void Delete_Patient()
        {
            PatientDBLayer u = new PatientDBLayer();
            u.delete_Patient(this);

        }
        public DataTable Search_for_a_Patient()
        {
            PatientDBLayer db = new PatientDBLayer();
            DataTable dt = db.Search_for_a_Patient(this);
            return dt;

        }
        public void reverse_deleted_patient()
        {
            PatientDBLayer u = new PatientDBLayer();
            u.reverse_deleted_Patient(this);
        }
        public void Blood_transfer(string blood_type)
        {
            PatientDBLayer u = new PatientDBLayer();
            u.transfer_blood(blood_type);
        }

    }
}