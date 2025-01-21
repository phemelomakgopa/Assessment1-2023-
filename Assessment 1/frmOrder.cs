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
    // Phemelo Shaun Makgopa 42165504
    // Llewelyn Kruger 41186427
    public partial class frmOrder : Form
    {
        // Declaring & assigning the connection string
        public string dbOrdConnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\legen\Downloads\Assessment_1\Assessment 1\Assessment 1\Orders.mdf;Integrated Security=True";
        public string dbDriConnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\legen\Downloads\Assessment_1\Assessment 1\Assessment 1\Drinks.mdf;Integrated Security=True";
        public string dbFooConnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\legen\Downloads\Assessment_1\Assessment 1\Assessment 1\Foods.mdf;Integrated Security=True";

        // Defining the sql instance variables
        public SqlConnection connD;
        public SqlConnection connF;
        public SqlConnection connO;
        public SqlCommand cmdD;
        public SqlCommand cmdF;
        public SqlCommand cmdO;
        public SqlDataAdapter adaptD;
        public SqlDataAdapter adaptF;
        public SqlDataAdapter adaptO;
        public SqlDataReader readerD;
        public SqlDataReader readerF;
        public DataSet ds;

        // Declaring a public int variable to store the Order ID
        public int orderId = 1;

        public void insertIntoOrdersTable()
        {
            // Using a try-catch block to handle exceptions
            try
            {
                // Incrementing the orderId to avoid duplicating
                orderId = orderId + 1;

                connO = new SqlConnection(dbOrdConnStr);            // Establishing the connection
                connO.Open();                                       // Opening the connection
                // Declaring and assigning a sql string to insert the contents of the Orders table
                string sql = $"INSERT INTO tblOrders(OrderId, Drink, DrinkQuantity, Food, FoodQuantity) VALUES('{orderId}', '{cmbDrinks.SelectedValue}', '{cmbDrinksQuantity.SelectedValue}', '{cmbFoods.SelectedValue}', '{cmbFoodQuantity.SelectedValue}')";
                adaptO = new SqlDataAdapter();                      // Instantiating the sql data adapter
                cmdO = new SqlCommand(sql, connO);                  // Instantiating the sql command
                adaptO.InsertCommand = cmdO;                        // Assigning the Insert Command to the sql command 
                adaptO.InsertCommand.ExecuteNonQuery();             // Executing a NonQuery Command

                connO.Close();                                      // Closing the connection
            }
            catch (SqlException error)
            {
                // Displaying an error message to the user
                MessageBox.Show("Oops, There was an error\n" + error.Message);
            }
        }

        public void loadAll()
        {
            // Using a try-catch block to handle exceptions
            try
            {
                // Loading the drinks combobox
                connD = new SqlConnection(dbDriConnStr);            // Establishing the connection
                connD.Open();                                       // Opening the connection
                // Declaring and assigning a sql string to select the contents of the Drink table
                string sql = "SELECT DrinkName FROM Drink";         
                adaptD = new SqlDataAdapter(sql, connD);            // Instantiating the sql data adapter
                DataSet ds = new DataSet();                         // Instantiating the data set
                adaptD.Fill(ds, "drinks");                          // Populating the data source with the table contents

                cmbDrinks.DisplayMember = "DrinkName";              // Assigning the display member of the combobox
                cmbDrinks.ValueMember = "DrinkName";                // Assigning the value member of the combobox 
                cmbDrinks.DataSource = ds.Tables["drinks"];         // Assigning the data source of the combobox

                connD.Close();                                      // Closing the connection

                // Loading the foods combobox
                connF = new SqlConnection(dbFooConnStr);            // Establishing the connection
                connF.Open();                                       // Opening the connection
                // Declaring and assigning a sql string to select the contents of the Food table
                string sql2 = "SELECT ProductName FROM Food";       
                adaptF = new SqlDataAdapter(sql2, connF);           // Instantiating the sql data adapter
                DataSet ds1 = new DataSet();                        // Instantiating the data set
                adaptF.Fill(ds1, "foods");                          // Populating the data source with the table contents

                cmbFoods.DisplayMember = "ProductName";             // Assigning the display member of the combobox
                cmbFoods.ValueMember = "ProductName";               // Assigning the value member of the combobox 
                cmbFoods.DataSource = ds1.Tables["foods"];          // Assigning the data source of the combobox

                connF.Close();                                      // Closing the connection
            }       
            catch (SqlException error)
            {
                // Displaying an error message to the user
                MessageBox.Show("Oops, There was an error\n" + error.Message);
            }
        }
        
        public frmOrder()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Creating the frmReceipt object and showing the form
            frmReceipt frmReceipts = new frmReceipt(this);
            frmReceipts.Show();

            this.Close();               // Closing the Order form

        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            loadAll();           // Calling the loadAll method

            // Setting the selected index to the first number in the combobox
            cmbDrinksQuantity.SelectedIndex = 0;
            cmbFoodQuantity.SelectedIndex = 0;

            // Displaying the headings in the listbox
            lstbxOrders.Items.Add("ItemID" + "\t\t" + "Product" + "\t\t" + "Price" + "\t\t" + "Quantity");
        }
        


        private void button2_Click(object sender, EventArgs e)
        {
            // Using a try-catch block to handle exceptions
            try
            {
                // Establishing the connections
                connD = new SqlConnection(dbDriConnStr);                
                connF = new SqlConnection(dbFooConnStr);
                // Opening the connections
                connD.Open();                                   
                connF.Open();
                // Declaring and assigning a sql strings to select the contents of the tables using the WHERE keyword
                string sql3 = "SELECT * FROM Drink WHERE DrinkName = '" + cmbDrinks.Text + "'";
                string sql4 = "SELECT * FROM Food WHERE ProductName = '" + cmbFoods.Text + "'";
                // Instantiating the sql commands
                cmdD = new SqlCommand(sql3, connD);
                cmdF = new SqlCommand(sql4, connF);
                // Assigning the readers to the ExecuteReader Commands
                readerD = cmdD.ExecuteReader();
                readerF = cmdF.ExecuteReader();

                // Using a while loop to read
                while (readerD.Read())
                {
                    // Displaying the selected drink to the listbox
                    string output = readerD.GetValue(0) + "\t\t" + readerD.GetValue(1) + "\t" + "R" + readerD.GetValue(2) + "\n";
                    lstbxOrders.Items.Add(output + "\t\t" + cmbDrinksQuantity.Text);

                    // Calling the insertIntoOrderMethod
                    insertIntoOrdersTable();
                }
                while (readerF.Read())
                {
                    // Displaying the selected food to the listbox
                    string output1 = readerF.GetValue(0) + "\t\t" + readerF.GetValue(1) + "\t" + "R" + readerF.GetValue(2) + "\n";
                    lstbxOrders.Items.Add(output1 + "\t\t" + cmbFoodQuantity.Text);

                    // Calling the insertIntoOrderMethod
                    insertIntoOrdersTable();
                }
            }
            catch (SqlException error)
            {
                // Displaying an error message to the user
                MessageBox.Show("Oops, There was an error\n" + error.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Deleting the selected item
            lstbxOrders.Items.Remove(lstbxOrders.SelectedItem);
        }
    }
}
