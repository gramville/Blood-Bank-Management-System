using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BBMS
{
    public partial class All_Users : Form
    {
        int id;
        public All_Users()
        {
            InitializeComponent();
            update_data_grid_view();
        }
        public void update_data_grid_view()
        {
            EmployeeUserLayer em = new EmployeeUserLayer();
            DataTable dt = em.view_employees();
            dataGridView1.DataSource = dt;
        }
        public void clear()
        {
            textBox1.Text="";
            textBox8.Text="";
            textBox9.Text="";
            textBox2.Text="";
            textBox5.Text="";
            textBox3.Text="";
            textBox6.Text="";
            textBox4.Text="";
            comboBox1.Text = null;
            comboBox3.Text = null;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            comboBox3.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[12].Value.ToString() == "Terminated")
            {
                button1.Visible = true;
                button1.Focus();
                button2.Enabled = false;
                button3.Enabled = false;
            }
            else
            {
                button1.Visible = false;
                button2.Enabled = true;
                button3.Enabled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox2.Text == "" || textBox5.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Make Sure You Inserted All Values");
            }
            else
            {
                id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                EmployeeUserLayer em = new EmployeeUserLayer(id, textBox1.Text, textBox8.Text, textBox9.Text, int.Parse(textBox2.Text), comboBox1.Text, double.Parse(textBox5.Text), textBox3.Text, textBox6.Text, comboBox3.Text, textBox4.Text);
                em.update_employee();
                update_data_grid_view();
                clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox2.Text == "" || textBox5.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Make Sure You Inserted All Values");
            }
            else
            {
                id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                EmployeeUserLayer em = new EmployeeUserLayer(id);
                em.delete_employee();
                update_data_grid_view();
                clear();
            }
        }

private void button1_Click(object sender, EventArgs e)
        {
            EmployeeUserLayer em = new EmployeeUserLayer(id);
            em.reverse_deleted_employee();
            update_data_grid_view();
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

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

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

        private void textBox5_Leave(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox5.Text.Length; i++)
            {

                if ((textBox5.Text[i] < '0' || textBox5.Text[i] > '9') && (textBox5.Text[i] != '.' && textBox5.Text[i] != ','))
                {

                    MessageBox.Show("Salary  Can't Have Characters  in it");
                    
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

      
private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 9 && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            EmployeeUserLayer em = new EmployeeUserLayer(textBox7.Text);
            dataGridView1.DataSource = em.search_for_an_employee();
            textBox11.Visible = true;
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
          
        }



        private void textBox10_Click(object sender, EventArgs e)
        {
            textBox7.Text = "Search...";
            EmployeeUserLayer em = new EmployeeUserLayer();
            dataGridView1.DataSource = em.view_employees();
            textBox11.Visible = false;
        }

        private void textBox10_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}