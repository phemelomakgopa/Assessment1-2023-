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
    // Phemelo Shaun Makgopa 42165504
    // Llewelyn Kruger 41186427
    public partial class frmReceipt : Form
    {
        private frmOrder frmOrder;
        public frmReceipt(frmOrder frmOrder)
        {
            InitializeComponent();
            this.frmOrder = frmOrder;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add process code
            Application.Exit();
        }

        private void frmReceipt_Load(object sender, EventArgs e)
        {
            // Adding the orders to the receipt
            lstbxReceipt.Items.AddRange(frmOrder.lstbxOrders.Items);

        }
    }
}
