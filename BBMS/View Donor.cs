using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BBMS
{
    public partial class viewDonors : Form
    {
        int id, timer = 5;
        public viewDonors()
        {
            InitializeComponent();
            update_data_grid_view();
        }
        public void update_data_grid_view()
        {
            UserLayer u = new UserLayer();
            DataTable dt = u.View_All_Donors();
            dataGridView1.DataSource = dt;
        }
        public void clear()
        {
            textBox1.Text="";
            textBox8.Text="";
            textBox9.Text="";
            textBox2.Text="";
            textBox3.Text="";
            textBox4.Text="";
            comboBox1.Text = null;
            comboBox2.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || textBox8.Text == "" || textBox9.Text == "")
            {
                update_data_grid_view();
                MessageBox.Show("Error !!! Make Sure you inserted all values");
                update_data_grid_view();
            }
            else
            {
                id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                UserLayer u = new UserLayer(id);
                u.Delete_donor();
                timer1.Start();

                update_data_grid_view();
                clear();

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
                update_data_grid_view();
                MessageBox.Show("Error !!! Make Sure you inserted all values");
                update_data_grid_view();

            }
            else
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                UserLayer u = new UserLayer(id, textBox1.Text, textBox8.Text, textBox9.Text, int.Parse(textBox2.Text), comboBox1.Text, textBox3.Text, comboBox2.Text, textBox4.Text);
                u.update_donor();
                UserLayer u1 = new UserLayer("");
                DataTable dt = u1.Search_for_a_Donor();
                dataGridView1.DataSource = dt;
                clear();

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
                    textBox8.Focus();
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
                    textBox9.Focus();
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
                  
                    textBox2.Focus();
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
                    textBox3.Focus();
                    update_data_grid_view();
                    break;
                }

            }
        }



        private void textBox7_Leave(object sender, EventArgs e)
        {

        }






        private void textBox7_TextChanged(object sender, EventArgs e)
        {

            UserLayer u = new UserLayer(textBox7.Text);
            DataTable dt = u.Search_for_a_Donor();
            dataGridView1.DataSource = dt;
            textBox10.Visible = true;
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer = 0;
            UserLayer u = new UserLayer(id);
            u.reverse_deleted_donor();
            update_data_grid_view();
            button1.Visible = false;
            clear();
        }

        private void textBox10_Click(object sender, EventArgs e)
        {
            textBox7.Text = "Search...";
            UserLayer u = new UserLayer();
            DataTable dt = u.View_All_Donors();
            dataGridView1.DataSource = dt;
            textBox10.Visible = false;
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
    }
}