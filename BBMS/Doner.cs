using System;
using System.Collections;
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
    public partial class Doner : Form
    {
        int clicked = 0;
        ArrayList restrictions = new ArrayList();
        public Doner()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CustomCheckBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomCheckBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox2__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox3__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox6__TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2__TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3__TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || comboBox1.Text == "" || comboBox2.Text == "")
            {

                MessageBox.Show("Error !!! Make Sure you inserted all values");
            }
            else
            {
                UserLayer Donor_Registration;

                if (restrictions.Count == 0)
                {
                    Donor_Registration = new UserLayer(textBox1.Text, textBox5.Text, textBox6.Text, int.Parse(textBox2.Text), comboBox1.Text, textBox3.Text, comboBox2.Text, textBox4.Text);
                    Donor_Registration.Register_Donor();
                }
                else if (restrictions.Count == 1)
                {

                    Donor_Registration = new UserLayer(textBox1.Text, textBox5.Text, textBox6.Text, int.Parse(textBox2.Text), comboBox1.Text, textBox3.Text, comboBox2.Text, textBox4.Text, (string)restrictions[0]);
                    Donor_Registration.Register_Donor_with_one_restriction();
                }
                else if (restrictions.Count == 2)
                {
                    Donor_Registration = new UserLayer(textBox1.Text, textBox5.Text, textBox6.Text, int.Parse(textBox2.Text), comboBox1.Text, textBox3.Text, comboBox2.Text, textBox4.Text, (string)restrictions[0], (string)restrictions[1]);
                    Donor_Registration.Register_Donor_with_two_restrictions();
                }
                else if (restrictions.Count == 3)
                {
                    Donor_Registration = new UserLayer(textBox1.Text, textBox5.Text, textBox6.Text, int.Parse(textBox2.Text), comboBox1.Text, textBox3.Text, comboBox2.Text, textBox4.Text, (string)restrictions[0], (string)restrictions[1], (string)restrictions[2]);
                    Donor_Registration.Register_Donor_with_three_restrictions();
                }
                else if (restrictions.Count == 4)
                {
                    Donor_Registration = new UserLayer(textBox1.Text, textBox5.Text, textBox6.Text, int.Parse(textBox2.Text), comboBox1.Text, textBox3.Text, comboBox2.Text, textBox4.Text);
                    Donor_Registration.Register_Donor_with_four_restrictions();
                }
                textBox1.Text="";
                textBox2.Text="";
                textBox3.Text="";
                textBox4.Text="";
                textBox5.Text="";
                textBox6.Text="";
                comboBox1.Text = null;
                comboBox2.Text = null;
                checkBox1.Checked = false;
                guna2CustomCheckBox2.Checked = false;
                guna2CustomCheckBox3.Checked = false;
                guna2CustomCheckBox4.Checked = false;
            }
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

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            label6.Visible = true;
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            label6.Visible = false;
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) restrictions.Add(checkBox1.Text);
            else restrictions.Remove(checkBox1.Text);
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox2.Checked == true) restrictions.Add(guna2CustomCheckBox2.Text);
            else restrictions.Remove(guna2CustomCheckBox2.Text);
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox3.Checked == true) restrictions.Add(guna2CustomCheckBox3.Text);
            else restrictions.Remove(guna2CustomCheckBox3.Text);
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox4.Checked == true) restrictions.Add(guna2CustomCheckBox4.Text);
            else restrictions.Remove(guna2CustomCheckBox4.Text);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
