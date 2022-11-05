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
    public partial class splashwindow : Form
    {
        public splashwindow()
        {
            InitializeComponent();
        }

        private void splashwindow_Load(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Make sure You Inserted All Values");
            }
            else
            {
                EmployeeUserLayer em = new EmployeeUserLayer(int.Parse(textBox1.Text), textBox2.Text);
                string role = em.login();
                if (role == "no role")
                {
                    MessageBox.Show("Id and Passwords don't Match");
                }
                else
                {
                    this.Hide();
                    Form1 b = new Form1();
                    b.ShowDialog();
                    this.Close();

                }
            }

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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
