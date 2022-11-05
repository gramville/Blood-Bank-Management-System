using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BBMS
{
    public partial class Register_User : Form
    {
        public Register_User()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox1.Text.Length; i++)
            {

                if (!(textBox1.Text[i] >= 'a' && textBox1.Text[i] <= 'z' || textBox1.Text[i] >= 'A' && textBox1.Text[i] <= 'Z'))
                {

                    MessageBox.Show("Name Can't Have Numbers or Symbols  in it");
                    
                    break;
                }



            }
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox8.Text.Length; i++)
            {

                if (!(textBox8.Text[i] >= 'a' && textBox8.Text[i] <= 'z' || textBox8.Text[i] >= 'A' && textBox8.Text[i] <= 'Z'))
                {

                    MessageBox.Show("Name Can't Have Numbers or Symbols  in it");
                   
                    break;
                }



            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox9.Text.Length; i++)
            {

                if (!(textBox9.Text[i] >= 'a' && textBox9.Text[i] <= 'z' || textBox9.Text[i] >= 'A' && textBox9.Text[i] <= 'Z'))
                {

                    MessageBox.Show("Name Can't Have Numbers or Symbols  in it");
                    
                    break;
                }



            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox2.Text.Length; i++)
            {

                if (textBox2.Text[i] < '0' || textBox2.Text[i] > '9')
                {

                    MessageBox.Show("Age  Can't Have Characters  in it");
                    
                    break;
                }

            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox5.Text.Length; i++)
            {

                if ((textBox5.Text[i] < '0' || textBox5.Text[i] > '9') && (textBox5.Text[i] != '.' && textBox5.Text[i] != ','))
                {

                    MessageBox.Show("Salary  Can't Have Characters  in it");
                    
                    break;
                }

            }
        }

       private void textBox3_Leave(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox3.Text.Length; i++)
            {

                if (textBox3.Text[i] < '0' || textBox3.Text[i] > '9')
                {

                    MessageBox.Show("Phone  Can't Have Characters  in it");
                    break;
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox6.Text == "" || textBox2.Text == "" || textBox5.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Make Sure You Inserted All Values");
            }
            else
            {
                EmployeeUserLayer em = new EmployeeUserLayer(textBox1.Text, textBox8.Text, textBox9.Text, int.Parse(textBox2.Text), comboBox1.Text, double.Parse(textBox5.Text), textBox3.Text, textBox6.Text, comboBox3.Text, textBox4.Text);
                em.register_employee();
            }
        }
    }
}