using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BBMS
{
    public partial class Form1 : Form
    {   //Fields
        private int borderSize = 2;
        private Form currentchildform;

        public Form1()
        {
            splashwindow SP = new splashwindow();
            SP.Show();
            InitializeComponent();
            collapsemenu();
            this.Padding = new Padding(borderSize); // Border Size
            this.BackColor = Color.FromArgb(98, 102, 244);  // border color
            
        }
        private void Openchildform(Form childform)
        {
            if(currentchildform != null)
            {
                currentchildform.Close();
            }
            currentchildform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childform);
            panelDesktop.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        private void iconButton3_Click(object sender, EventArgs e)
        {
            Openchildform(new Doner());
        }
        private void iconButton4_Click(object sender, EventArgs e)
        {
            Openchildform(new donate());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            collapsemenu();
        }

        private void collapsemenu()
        {
            if ( this . panelMenu . Width > 200 ) // Collapse menu   
        {
            panelMenu. Width = 100 ;
            guna2PictureBox1. Visible = false ;
            iconButton1. Dock = DockStyle. Top ;
            foreach ( Button menuButton in panelMenu. Controls . OfType < Button > ()) 
            {
                menuButton. Text = "" ;
                menuButton. ImageAlign = ContentAlignment. MiddleCenter ;
                menuButton. Padding = new Padding ( 0 ) ; 
            }
        }
        else
        { // Expand menu
            panelMenu. Width = 230 ;
            guna2PictureBox1. Visible = true ;
            iconButton1. Dock = DockStyle. None ;
            foreach ( Button menuButton in panelMenu. Controls . OfType < Button > ()) 
            {
                menuButton. Text = "" + menuButton. Tag . ToString () ;
                menuButton. ImageAlign = ContentAlignment. MiddleLeft ;
                menuButton. Padding = new Padding ( 10 , 0 , 0 , 0 ) ; 
            }
        }
        }
        

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {  

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Openchildform(new dashboard());
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            this.Hide();
            splashwindow sp = new splashwindow();
            sp.ShowDialog();
            this.Close();

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            Openchildform(new Blood_stock());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            Openchildform(new Patient());
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            Openchildform(new viewDonors());
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            Openchildform(new bloodTransfer());
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            Openchildform(new viewPatients());
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            Openchildform(new unprocessed_blod());
        }
    }
}
