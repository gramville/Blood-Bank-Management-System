using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBMS
{
    public partial class admin_login : Form
    {
        public admin_login()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            splashwindow s = new splashwindow();
            s.Show();
            this.Close();
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                textBox2.PasswordChar = '\0';
            }
            else if (textBox2.PasswordChar == '\0')
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Make Sure You Inserted All Values");
            }
            else
            {
                EmployeeUserLayer em = new EmployeeUserLayer(7, textBox2.Text);
                string role = em.admin_login();
                if (role == "no role")
                {
                    MessageBox.Show("Id and Passwords Don't Match");
                }
                else
                {
                    this.Hide();
                    Admin a = new Admin();
                    a.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
