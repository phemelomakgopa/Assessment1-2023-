using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Assessment_1
{
    public partial class frmStaff : Form
    {
        // Phemelo Shaun Makgopa 42165504
        // Llewelyn Kruger 41186427

        // Instantiating a public Order form object
        public frmOrder frmOrder = new frmOrder();


        public void displayOrders(string sql)
        {
            // Using a try-catch block to handle exceptions
            try
            {
                frmOrder.connO = new SqlConnection(frmOrder.dbOrdConnStr);  // Establishing a connection 
                frmOrder.connO.Open();                                      // Opening the connection
                frmOrder.adaptO = new SqlDataAdapter();                     // Instantiating the sql data adapter
                frmOrder.ds = new DataSet();                                // Instantiating the data set

                frmOrder.cmdO = new SqlCommand(sql, frmOrder.connO);        // Instantiating the sql command
                frmOrder.adaptO.SelectCommand = frmOrder.cmdO;               // Assigning the Select Command to the sql command         
                frmOrder.adaptO.Fill(frmOrder.ds, "tblOrders");              // Populating the data source with the table contents

                dataGridViewOrders.DataSource = frmOrder.ds;                 // Assigning the data source of the data grid view 
                dataGridViewOrders.DataMember = "tblOrders";                 // Displaying the Orders table to the data grid view

                frmOrder.connO.Close();                                      // Closing the connection
            }
            catch (SqlException error)
            {
                //Displaying an error message to the user
                MessageBox.Show("Oops, There was an error\n" + error.Message);
            }
        }

        public frmStaff()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //add process code
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Using a try-catch block to handle exceptions
            try
            {
                // Instantiating the Update form object and showing the form
                frmStuffUpdate frmUpdate = new frmStuffUpdate();
                frmUpdate.ShowDialog();

                // Incrementing the orderId to avoid duplicating
                frmOrder.orderId = frmOrder.orderId + 1;
                
                frmOrder.connO = new SqlConnection(frmOrder.dbOrdConnStr);          // Establishing a connection 
                frmOrder.connO.Open();                                              // Opening the connection
                // Declaring and assigning a sql string to insert the contents of the Orders table
                string sql = $"INSERT INTO tblOrders(OrderId, Drink, DrinkQuantity, Food, FoodQuantity) VALUES('{frmOrder.orderId}', '{frmUpdate.txtDrink.Text}', '{frmUpdate.txtDrinkQua.Text}', '{frmUpdate.txtFood.Text}', '{frmUpdate.txtFoodQua.Text}')";
                frmOrder.adaptO = new SqlDataAdapter();                             // Instantiating the sql data adapter                         
                frmOrder.cmdO = new SqlCommand(sql, frmOrder.connO);                // Instantiating the sql command
                frmOrder.adaptO.InsertCommand = frmOrder.cmdO;                      // Assigning the Insert Command to the sql command
                frmOrder.adaptO.InsertCommand.ExecuteNonQuery();                    // Executing a NonQuery Command

                frmOrder.connO.Close();                                             // Closing the connection

                // Declaring and assigning a sql string to select the contents of the Orders table
                string sqlAll = "SELECT * FROM tblOrders";     
                displayOrders(sqlAll);                                               // Displaying the orders 
            }

            catch (SqlException error)
            {
                // Displaying an error message to the user
                MessageBox.Show("Oops, There was an error\n" + error.Message);
            }



        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            // Declaring and assigning a sql string to select the contents of the Orders table
            string sql = "SELECT * FROM tblOrders";                            

            displayOrders(sql);                                               // Displaying the orders 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Using a try-catch block to handle exceptions
            try
            {
                frmOrder.connO.Open();                                      // Opening the connection
                // Declaring and assigning a sql string to delete the contents of the Orders table using the OrderId
                string sql = "DELETE FROM tblOrders WHERE OrderId = '" + txtDeleteOrderId.Text + "'";
                frmOrder.adaptO = new SqlDataAdapter();                     // Instantiating the sql data adapter
                frmOrder.cmdO = new SqlCommand(sql, frmOrder.connO);        // Instantiating the sql command
                frmOrder.adaptO.DeleteCommand = frmOrder.cmdO;              // Assigning the Delete Command to the sql command
                frmOrder.adaptO.DeleteCommand.ExecuteNonQuery();            // Executing a NonQuery Command

                frmOrder.connO.Close();                                     // Closing the connection

                // Declaring and assigning a sql string to select the contents of the Orders table
                string sql1 = "SELECT * FROM tblOrders";

                displayOrders(sql1);                                        // Displaying the orders 

            }
            catch (SqlException error)
            {
                // Displaying an error message to the user
                MessageBox.Show("Oops, There was an error\n" + error.Message);
            }
        }



        private void txtSearchQuantity_TextChanged(object sender, EventArgs e)
        {
            // Declaring and assigning a sql string to filter the contents of the Orders table
            string sql = "SELECT * FROM tblOrders WHERE FoodQuantity = '" + txtSearchQuantity.Text.ToString() + "' OR DrinkQuantity = '" + txtSearchQuantity.Text.ToString() + "'";     
            
            displayOrders(sql);                // Displaying the orders 
        }

        private void txtSearchProd_TextChanged(object sender, EventArgs e)
        {
            // Declaring and assigning a sql string to filter the contents of the Orders table
            string sql = "SELECT * FROM tblOrders WHERE Food LIKE '%" + txtSearchProd.Text.ToString() + "%' OR Drink LIKE '%" + txtSearchProd.Text.ToString() + "%'";
            displayOrders(sql);             // Displaying the orders 
        }
    }
}
