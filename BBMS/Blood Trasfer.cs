
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BBMS
{
    public partial class bloodTransfer : Form
    {
        public bloodTransfer()
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
        public void transfer_blood()
        {
            PatientUserLayer p = new PatientUserLayer();
            p.Blood_transfer(textBox4.Text);
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Make sure you inserted all values");
            }
            else
            {
                Blood_stock b = new Blood_stock();

                if (textBox4.Text == "A+")
                {
                    if (b.label20.Text == "0")
                    {
                        label1.Visible = true;
                        label1.ForeColor = Color.Red;
                        label1.Text = "Sorry there is no Blood type A+ in the store";
                        textBox1.Clear();
                        textBox4.Clear();
                    }
                    else
                    {
                        transfer_blood();
                        label1.Visible = true;
                        label1.ForeColor = Color.Green;
                        label1.Text = "Transfer Successful";
                    }
                }
                if (textBox4.Text == "A-")
                {
                    if (b.label21.Text == "0")
                    {
                        label1.Visible = true;
                        label1.ForeColor = Color.Red;
                        label1.Text = "Sorry there is no Blood type A- in the store";
                        textBox1.Clear();
                        textBox4.Clear();
                    }
                    else
                    {
                        transfer_blood();
                        label1.Visible = true;
                        label1.ForeColor = Color.Green;
                        label1.Text = "Transfer Successful";
                    }

                    
}
                if (textBox4.Text == "B+")
                {
                    if (b.label22.Text == "0")
                    {
                        label1.Visible = true;
                        label1.ForeColor = Color.Red;
                        label1.Text = "Sorry there is no Blood type B+ in the store";
                        textBox1.Clear();
                        textBox4.Clear();
                    }
                    else
                    {
                        transfer_blood();
                        label1.Visible = true;
                        label1.ForeColor = Color.Green;
                        label1.Text = "Transfer Successful";
                    }
                }
                if (textBox4.Text == "B-")
                {
                    if (b.label23.Text == "0")
                    {
                        label1.Visible = true;
                        label1.ForeColor = Color.Red;
                        label1.Text = "Sorry there is no Blood type B- in the store";
                        textBox1.Clear();
                        textBox4.Clear();
                    }
                    else
                    {
                        transfer_blood();
                        label1.Visible = true;
                        label1.ForeColor = Color.Green;
                        label1.Text = "Transfer Successful";
                    }
                }
                if (textBox4.Text == "AB+")
                {
                    if (b.label24.Text == "0")
                    {
                        label1.Visible = true;
                        label1.ForeColor = Color.Red;
                        label1.Text = "Sorry there is no Blood type AB+ in the store";
                        textBox1.Clear();
                        textBox4.Clear();
                    }
                    else
                    {
                        transfer_blood();
                        label1.Visible = true;
                        label1.ForeColor = Color.Green;
                        label1.Text = "Transfer Successful";
                    }
                }
                if (textBox4.Text == "AB-")
                {
                    if (b.label25.Text == "0")
                    {
                        label1.Visible = true;
                        label1.ForeColor = Color.Red;
                        label1.Text = "Sorry there is no Blood type AB- in the store"; textBox1.Clear();
                        textBox4.Clear();
                    }
                    else
                    {
                        transfer_blood();
                        label1.Visible = true;
                        label1.ForeColor = Color.Green;
                        label1.Text = "Transfer Successful";
                    }
                }
                if (textBox4.Text == "O+")
                {
                    if (b.label26.Text == "0")
                    {
                        label1.Visible = true;
                        label1.ForeColor = Color.Red;
                        label1.Text = "Sorry there is no Blood type O+ in the store";
                        textBox1.Clear();
                        textBox4.Clear();
                    }
                    else
                    {
                        transfer_blood();
                        label1.Visible = true;
                        label1.ForeColor = Color.Green;
                        label1.Text = "Transfer Successful";
                    }
                }
                if (textBox4.Text == "O-")
                {
                    if (b.label27.Text == "0")
                    {
                        label1.Visible = true;
                        label1.ForeColor = Color.Red;
                        label1.Text = "Sorry there is no Blood type O- in the store";
                        textBox1.Clear();
                        textBox4.Clear();
                    }
                    else
                    {
                        transfer_blood();

                       
label1.Visible = true;
                        label1.ForeColor = Color.Green;
                        label1.Text = "Transfer Successful";
                    }
                }
                textBox1.Clear();
                textBox4.Clear();
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}