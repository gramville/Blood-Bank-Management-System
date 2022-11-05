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
    public partial class Blood_stock : Form
    {
        public Blood_stock()
        {
            InitializeComponent();
            initialize_labels();
            
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
        public void initialize_labels()
        {
            Blood b = new Blood();
            string quantity = b.quantity_of_blood_types();
            string[] n = quantity.Split(' ');
            label20.Text = n[0].ToString();
            label21.Text = n[1].ToString();
            label22.Text = n[2].ToString();
            label23.Text = n[3].ToString();
            label24.Text = n[4].ToString();
            label25.Text = n[5].ToString();
            label26.Text = n[6].ToString();
            label27.Text = n[7].ToString();
        }

        private void guna2PictureBox_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }
    }
}
