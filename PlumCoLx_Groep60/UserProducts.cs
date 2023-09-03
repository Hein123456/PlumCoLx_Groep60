using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
        public UserProducts()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\PlumCo.mdf; Integrated Security = True";
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
             con.Open();
            string sql = "SELECT Description, Price FROM Product WHERE quantity > 0";
            cmd = new SqlCommand(sql, con);
            adapt = new SqlDataAdapter(cmd);
            adapt.SelectCommand.ExecuteNonQuery();
            DataSet ds = new DataSet();
            adapt.Fill(ds,"product");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "product";
            con.Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // if the user clicks on a product display that items description in the text box
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();    
            
            // if the user clicks add to cart add the product description to the list box and if a user adds the same product twice increase the quantity by 1
            // if the user presses the button reset clear all items form the cart.
            // if the user clicks on checkout then a message box shoud display a summary of products aswell as totals and ask the user if they want to checkout
            // whan the user checks out the oerder shoul be added to the Product_log table with a unique integer order number and the date and time of the order along with the client id, subtotal and the status as pending with a description of the products the customer ordere by means of a list of product ids and quantities
           
        }
    }
}
