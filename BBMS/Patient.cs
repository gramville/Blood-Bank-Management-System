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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void textBox1__TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_Leave(object sender, EventArgs e)
        {

        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox1.Text.Length; i++)
            {

                if (!(textBox1.Text[i] >= 'a' && textBox1.Text[i] <= 'z' || textBox1.Text[i] >= 'A' && textBox1.Text[i] <= 'Z'))
                {

                    MessageBox.Show("Name Can't Have Numbers or Symbols  in it");
                    textBox1.Focus();
                    break;
                }



            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox5.Text.Length; i++)
            {

                if (!(textBox5.Text[i] >= 'a' && textBox5.Text[i] <= 'z' || textBox5.Text[i] >= 'A' && textBox5.Text[i] <= 'Z'))
                {

                    MessageBox.Show("Name Can't Have Numbers or Symbols  in it");
                    textBox5.Focus();
                    break;
                }



            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox6.Text.Length; i++)
            {

                if (!(textBox6.Text[i] >= 'a' && textBox6.Text[i] <= 'z' || textBox6.Text[i] >= 'A' && textBox6.Text[i] <= 'Z'))
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

                    textBox2.Focus();
                    break;
                }
                if (int.Parse(textBox2.Text) < 18 || int.Parse(textBox2.Text) > 65)
                {
                    MessageBox.Show("you must be between ages 18 and 65 to be registered as a donor ");
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

                    MessageBox.Show("Phone Numebr  Can't Have Characters  in it");
                    textBox3.Focus();
                    break;
                }

            }
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || comboBox1.Text == "" || comboBox2.Text == "")
            {

                MessageBox.Show("Error !!! Make Sure you inserted all values");
            }
            else
            {
                PatientUserLayer Patient_Registration = new PatientUserLayer(textBox1.Text, textBox5.Text, textBox6.Text, int.Parse(textBox2.Text), comboBox1.Text, textBox3.Text, comboBox2.Text, textBox4.Text);
                Patient_Registration.Register_Patient();
                textBox1.Text="";
                textBox2.Text="";
                textBox3.Text="";
                textBox4.Text="";
                textBox5.Text="";
                textBox6.Text="";
                comboBox1.Text = null;
                comboBox2.Text = null;
            }
        }
    }
}
