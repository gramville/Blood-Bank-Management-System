using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BBMS
{
    public partial class unprocessed_blod : Form
    {
        public unprocessed_blod()
        {
            InitializeComponent();
            update_data_grid_view();
        }
        public void update_data_grid_view()
        {
            UpdateLabUserLayer u = new UpdateLabUserLayer();
            DataTable dt = u.view_unprocessed_donations();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || conboBox2.Text == "")
            {
                MessageBox.Show("Make sure You inserted All Values");
            }
            else
            {
                UpdateLabUserLayer u = new UpdateLabUserLayer(int.Parse(textBox1.Text), conboBox2.Text);
                u.update_unprocessed_donation();
                update_data_grid_view();
                textBox1.Text="";;
                textBox4.Text="";;
                conboBox2.Text = null;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            button1.Focus();
        }

        private void Unprocessed_donations_Load(object sender, EventArgs e)
        {

        }
    }
}