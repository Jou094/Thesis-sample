using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thesis_sample
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            panelmaintenance.Visible = false;
            panelinventory.Visible = false;
        }

        private void hideSubMenu()
        {
            if(panelmaintenance.Visible == true) 
                panelmaintenance.Visible = false;
            if(panelinventory.Visible == true)
                panelinventory.Visible = false;
            
        }

        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnmaintenance_Click(object sender, EventArgs e)
        {
            showSubMenu(panelmaintenance);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btninventory_Click(object sender, EventArgs e)
        {
            showSubMenu(panelinventory);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
    }
}
