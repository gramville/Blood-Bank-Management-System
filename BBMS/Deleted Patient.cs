using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BBMS
{
    public partial class Deleted_Patients : Form
    {
        int id;
        public Deleted_Patients()
        {
            InitializeComponent();
            update_data_grid_view();
        }
        public void update_data_grid_view()
        {
            EmployeeUserLayer em = new EmployeeUserLayer();
            dataGridView1.DataSource = em.view_deleted_patients();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Maake sure You Selected A Patient");
            }
            else
            {
                EmployeeUserLayer em = new EmployeeUserLayer(id);
                em.reverse_deleted_patient();
                update_data_grid_view();
            }
        }
    }
}