using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BBMS
{
    public partial class viewPatients : Form
    {
        int id, timer = 5;
        public viewPatients()
        {
            InitializeComponent();
            update_data_grid_view();
        }


        public void update_data_grid_view()
        {
            PatientUserLayer u = new PatientUserLayer();
            DataTable dt = u.View_Patients();
            dataGridView1.DataSource = dt;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox8.Text == "" || textBox9.Text == "")
            {

                MessageBox.Show("Error !!! Make Sure you inserted all values");
                textBox5_Click(sender, e);
            }
            else
            {
                id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                PatientUserLayer u = new PatientUserLayer(id);
                u.Delete_Patient();
                timer1.Start();
                update_data_grid_view();


            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || textBox8.Text == "" || textBox9.Text == "")
            {

                MessageBox.Show("Error !!! Make Sure you inserted all values");
                textBox5_Click(sender, e);
            }
            else
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                PatientUserLayer u = new PatientUserLayer(id, textBox1.Text, textBox8.Text, textBox9.Text, int.Parse(textBox2.Text), comboBox1.Text, textBox3.Text, comboBox2.Text, textBox4.Text);
                u.update_Patient();
                UserLayer u1 = new UserLayer("");
                DataTable dt = u1.Search_for_a_Donor();
                dataGridView1.DataSource = dt;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox1.Text.Length; i++)
            {

                if (!(textBox1.Text[i] >= 'a' && textBox1.Text[i] <= 'z' || textBox1.Text[i] >= 'A' && textBox1.Text[i] <= 'Z'))
                {

                    MessageBox.Show("Name Can't Have Numbers or Symbols  in it");
                    
                    update_data_grid_view();
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
                    
                    update_data_grid_view();
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
                    
                    update_data_grid_view();
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
                   
                    update_data_grid_view();
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
                    
                    update_data_grid_view();
                    break;

                }

            }
        }



        private void textBox7_Leave(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PatientUserLayer u = new PatientUserLayer(textBox7.Text);
            DataTable dt = u.Search_for_a_Patient();
            dataGridView1.DataSource = dt;
        }

        private void viewPatients_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pictureBox1_Click(sender, e);
            }
        }



        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            PatientUserLayer u = new PatientUserLayer(textBox7.Text);
            DataTable dt = u.Search_for_a_Patient();
            dataGridView1.DataSource = dt;
            textBox11.Visible = true;
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            button3.Enabled = false;
            if (timer == 0)
            {
                button3.Enabled = true;
                timer1.Stop();
                button1.Visible = false;
                button3.Enabled = true;


            }
            if (timer != 5 && button1.Visible == false)
            {
                timer = 5;
                button3.Enabled = true;
            }
            else
            {
                button3.Enabled = false;
                button1.Visible = true;
                button1.Text = Convert.ToString(timer) + "   Undo";
                timer--;
                button1.Focus();
            }


        }

        
private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox7.Text = "Search...";
            PatientUserLayer u = new PatientUserLayer();
            DataTable dt = u.View_Patients();
            dataGridView1.DataSource = dt;
            textBox11.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer = 0;
            PatientUserLayer u = new PatientUserLayer(id);
            u.reverse_deleted_patient();
            update_data_grid_view();
            button1.Visible = false;


        }




    }
}