using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment_1
{
    // 9 May 2023
    // Phemelo Shaun Makgopa 42165504
    // Llewelyn Kruger 41186427
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();                     // Exiting the application
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
  
        }


        private void staffLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Creating the frmStaff instance object and showing the form
            frmStaff frmStaff = new frmStaff();
            frmStaff.MdiParent = this;
            frmStaff.Show();
            
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Creating the frmStaff instance object and showing the form
            frmOrder frmOrders = new frmOrder();
            frmOrders.MdiParent = this;
            frmOrders.Show();
        }
    }
}
