using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BBMS
{
    public partial class donate : Form
    {
        public donate()
        {
            InitializeComponent();
            UserLayer u = new UserLayer();
            DataTable dt = u.View_All_Donors();
            dataGridView1.DataSource = dt;
        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {


        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Make sure You inserted all values");
            }
            else
            {
                UserLayer u = new UserLayer(int.Parse(textBox1.Text), textBox4.Text);
                u.Donate();
            }
           
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }
    }
}