﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlumCoLx_Groep60
{
    public partial class UserProducts : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd;
        SqlDataAdapter adapt;
        string[] ProductID = new string[20];
        string[] ProductDes = new string[20];
        int[] ProductQuantity = new int[20];
        double[] ProductPrice = new double[20];
        int tel = 0;
        double subtotal = 0;
       
        public UserProducts()
        {
            InitializeComponent();
           con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PlumCoLX.mdf;Integrated Security=True";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UserProducts_Load(object sender, EventArgs e)
        {
            //populate the datadridview with the products from the database
            //only show products that are in stiock
            // only show the user the product description and price
            // sort products by category (plumbing_category)
            ProductID[0] = null;
            listBox1.Items.Clear();
            listBox1.Items.Add("Your Cart:");
            listBox1.Items.Add("Item: \t Quantity: \t Price:");

          

             con.Open();
             string sql = "SELECT Description, Price FROM Product WHERE quantity > 0";
             cmd = new SqlCommand(sql, con);
             adapt = new SqlDataAdapter(cmd);
             adapt.SelectCommand.ExecuteNonQuery();
             DataSet ds = new DataSet();
             adapt.Fill(ds, "product");
             dataGridView1.DataSource = ds;
             dataGridView1.DataMember = "product";

             con.Close();
         




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // if the user clicks on a product display that items description in the text box
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                // Get the value from the first column of the selected row
                object value = dataGridView1.Rows[e.RowIndex].Cells[0].Value;

                // Check if the value is not null before converting to string
                if (value != null)
                {
                    textBox1.Text = value.ToString();
                }
                else
                {
                    textBox1.Text = string.Empty; // Set to an empty string if the value is null
                }
            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get selected product id based on the description
            string id = "";
            double price = 0;
            string description = "";
            try
            {
                con.Open();
                string sql = "SELECT * FROM Product WHERE Description = '" + textBox1.Text + "'";
                cmd = new SqlCommand(sql, con);
                adapt = new SqlDataAdapter(cmd);
                adapt.SelectCommand.ExecuteNonQuery();
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                id = ds.Tables[0].Rows[0]["productId"].ToString();
                price = Convert.ToDouble(ds.Tables[0].Rows[0]["Price"].ToString());
                description = ds.Tables[0].Rows[0]["Description"].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                if (ProductID[0] == null)
                {
                    ProductID[0] = id;
                    ProductQuantity[0] = 1;
                    ProductDes[0] = description;
                    ProductPrice[0] = price;
                    subtotal += Convert.ToDouble(price);
                    tel++;
                }
                else
                {

                    if (ProductID.Contains(id))
                    {
                       
                        ProductQuantity[Array.IndexOf(ProductID, id)] += 1;
                        subtotal += Convert.ToDouble(price);
                    }
                    else
                    {
                        // if the user clicks add to cart add the product description to the list box and if a user adds the same product twice increase the quantity by 1
                        //grow the array if the user adds a product that is already in the cart
                       
                        ProductDes[tel] =(description);
                        ProductID[tel] =(id);
                        ProductQuantity[tel]=(1);
                        ProductPrice[tel] = (price);
                        subtotal += Convert.ToDouble(price);
                        tel++;
                    }
                }
                listBox1.Items.Clear();
                    listBox1.Items.Add("Your Cart:");
                    listBox1.Items.Add("Item: \t\t\t\t Quantity: \t Price:");
                    for (int i = 0; i < tel; i++)
                    {
                        double sub = (Convert.ToDouble(ProductPrice[i]) * Convert.ToDouble(ProductQuantity[i]));
                        listBox1.Items.Add(ProductDes[i] + "\t\t" + ProductQuantity[i] + "\tR " + sub);
                    }
                    listBox1.Items.Add("\nSubtotal: R" + subtotal);
                
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // if the user presses the button reset clear all items form the cart.
            textBox1.Text = "";
            ProductID = new string[20];
            ProductQuantity = new int[20];

            ProductDes = new string[20];
            ProductPrice = new double[20];
            tel = 0;

            subtotal = 0;
            listBox1.Items.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // if the user clicks on checkout then a message box shoud display a summary of products aswell as totals and ask the user if they want to checkout
            // whan the user checks out the oerder shoul be added to the Product_log table with a unique integer order number and the date and time of the order along with the client id, subtotal and the status as pending with a description of the products the customer ordere by means of a list of product ids and quantities
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to checkout?", "Checkout", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string userid = "";
                int orderID = 0;
                string orderDes = "";
                try
                {
                    //get user id from login.txt
                    string[] lines = File.ReadAllLines("login.txt");
                     userid = lines[1];
                    con.Open();
                    //get next order number
                    string sql = "SELECT MAX(OrderID) FROM Product_log";
                    cmd = new SqlCommand(sql, con);
                    adapt = new SqlDataAdapter(cmd);
                    adapt.SelectCommand.ExecuteNonQuery();
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                     orderID = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) + 1;

                   
                    for (int i = 0; i < tel; i++)
                    {
                        orderDes += ProductID[i] + " " + ProductQuantity[i] + ", ";
                    }
                   con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
                try { 
               
                    con.Open();
                     string sql2 = "INSERT INTO Product_log (OrderID, ClientID, OrderDate, Total, Status, Description) " +
                                   "VALUES (@OrderID, @ClientID, @OrderDate, @Total, @Status, @Description)";
                     cmd = new SqlCommand(sql2, con);

                     // Assuming orderID is an integer, userid is an integer, and subtotal is a decimal
                     cmd.Parameters.AddWithValue("@OrderID", orderID);
                     cmd.Parameters.AddWithValue("@ClientID", Convert.ToInt32(userid));
                     cmd.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                     cmd.Parameters.AddWithValue("@Total", subtotal);
                     cmd.Parameters.AddWithValue("@Status", "Pending");
                     cmd.Parameters.AddWithValue("@Description", orderDes);
                    
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Order Placed");
                    textBox1.Text = "";
                    ProductID = new string[20];
                    ProductQuantity = new int[20];

                    ProductDes = new string[20];
                    ProductPrice = new double[20];
                    tel = 0;

                    subtotal = 0;
                    listBox1.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
        }
    }
}
