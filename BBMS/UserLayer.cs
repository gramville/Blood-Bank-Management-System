
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBMS
{
    class UserLayer
    {
        public string firstname, fathersname, lastname, gender, phone, bloodGroup, address, searched, restriction1, restriction2, restriction3;
        public int age, id;

        // constructor for registering a new donor
        public UserLayer(String firstname, String fathersname, String lastname, int age, String gender, String phone, String bloodGroup, String address)
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
        // constructor for viewing all donors
        public UserLayer()
        {

        }
        // constructor for updating a donor
        public UserLayer(int id, String firstname, String fathersname, String lastname, int age, String gender, String phone, String bloodGroup, String address)
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
        // constructor for deleting  a donor
        public UserLayer(int id)
        {
            this.id = id;

        }
        // constructor for searching a donor 
        public UserLayer(String searched)
        {
            this.searched = searched;
        }
        // constructor for Donating
        public UserLayer(int id, string bloodgroup)
        {
            this.id = id;
            this.bloodGroup = bloodgroup;
        }
        // constructor for registering a donor with 3 restrictions
        public UserLayer(String firstname, String fathersname, String lastname, int age, String gender, String phone, String bloodGroup, String address, string restriction1, string restriction2, string restriction3)
        {
            this.firstname = firstname;
            this.fathersname = fathersname;
            this.lastname = lastname;
            this.age = age;
            this.gender = gender;
            this.phone = phone;
            this.bloodGroup = bloodGroup;
            this.address = address;
            this.restriction1 = restriction1;
            this.restriction2 = restriction2;
            this.restriction3 = restriction3;

        }
        // constructor for registering a donor with 2 restrictions
        public UserLayer(String firstname, String fathersname, String lastname, int age, String gender, String phone, String bloodGroup, String address, string restriction1, string restriction2)
        {
            this.firstname = firstname;
            this.fathersname = fathersname;
            this.lastname = lastname;
            this.age = age;
            this.gender = gender;
            this.phone = phone;
            this.bloodGroup = bloodGroup;
            this.address = address;
            this.restriction1 = restriction1;
            this.restriction2 = restriction2;

        }
        // constructor for registering a donor with 1 restrictions
        public UserLayer(String firstname, String fathersname, String lastname, int age, String gender, String phone, String bloodGroup, String address, string restriction1)
        {
            this.firstname = firstname;
            this.fathersname = fathersname;
            this.lastname = lastname;
            this.age = age;
            this.gender = gender;
            this.phone = phone;
            this.bloodGroup = bloodGroup;
            this.address = address;
            this.restriction1 = restriction1;

            
}

        public void Register_Donor()
        {
            UserDbLayer Register_Donor = new UserDbLayer();
            Register_Donor.Register_Donor_By__Stored_Procedure(this);
        }
        public DataTable View_All_Donors()
        {
            UserDbLayer db = new UserDbLayer();
            DataTable dt = db.View_All_Donors(this);
            return dt;
        }
        public void update_donor()
        {
            UserDbLayer u = new UserDbLayer();
            u.update_donor(this);
        }
        public void Delete_donor()
        {
            UserDbLayer u = new UserDbLayer();
            u.delete_donor(this);
        }
        public DataTable Search_for_a_Donor()
        {
            UserDbLayer db = new UserDbLayer();
            DataTable dt = db.Search_for_a_Donor(this);
            return dt;

        }
        public void reverse_deleted_donor()
        {
            UserDbLayer u = new UserDbLayer();
            u.reverse_deleted_donor(this);
        }
        public void Donate()
        {
            UserDbLayer u = new UserDbLayer();
            u.Donate(this);
        }
        public void Register_Donor_with_four_restrictions()
        {
            UserDbLayer u = new UserDbLayer();
            u.Register_Donor_with_four_restrictions(this);

        }
        public void Register_Donor_with_three_restrictions()
        {
            UserDbLayer u = new UserDbLayer();
            u.Register_Donor_with_three_restrictions(this);

        }
        public void Register_Donor_with_two_restrictions()
        {
            UserDbLayer u = new UserDbLayer();
            u.Register_Donor_with_two_restrictions(this);

        }
        public void Register_Donor_with_one_restriction()
        {
            UserDbLayer u = new UserDbLayer();
            u.Register_Donor_with_one_restriction(this);

        }

    }
}