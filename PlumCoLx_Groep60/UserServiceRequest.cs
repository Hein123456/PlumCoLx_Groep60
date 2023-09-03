using System;
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
    public partial class UserServiceRequest : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd;
        SqlDataAdapter adapt;
        string userid = "";
        string[] ServiceID = new string[20];
        string[] ServiceDes = new string[20];
        double[] ServicePrice = new double[20];
        int tel = 0;
        double subtotal = 0;
        public UserServiceRequest()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\PlumCo.mdf; Integrated Security = True";
            string[] lines = File.ReadAllLines("login.txt");
            userid = lines[1];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to checkout?", "Checkout", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
               
                int orderID = 0;
                string orderDes = "";
                try
                {
                   
                    
                    con.Open();
                    //get next order number

                    string sql = "SELECT MAX(OrderID) FROM ServiceOrder";
                    cmd = new SqlCommand(sql, con);
                    adapt = new SqlDataAdapter(cmd);
                    adapt.SelectCommand.ExecuteNonQuery();
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    orderID = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) + 1;


                    for (int i = 0; i < tel; i++)
                    {
                        orderDes += ServiceID[i] +  ", ";
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
                try
                {
                    MessageBox.Show(orderID + "," + Convert.ToInt32(userid) + ", '" + DateTime.Now + "', " + subtotal + ", 'Pending', '" + orderDes);
                    con.Open();

                    string sql2 = "INSERT INTO ServiceOrder (OrderID, ClientID, OrderDate, Total, Status, Description) " +
                                  "VALUES (@OrderID, @ClientID, @OrderDate, @Total, @Status, @Description)";

                    cmd = new SqlCommand(sql2, con);

                    // Assuming orderID is an integer, userid is an integer, and subtotal is a decimal
                    cmd.Parameters.AddWithValue("@OrderID", orderID);
                    cmd.Parameters.AddWithValue("@ClientID", Convert.ToInt32(userid));
                    cmd.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Total", subtotal);
                    cmd.Parameters.AddWithValue("@Status", "Pending");
                    cmd.Parameters.AddWithValue("@Description", orderDes);

                    // Create a SqlDataAdapter and associate it with the insert command
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.InsertCommand = cmd;

                    // Execute the insert command using the SqlDataAdapter
                    adapter.InsertCommand.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Order Placed");
                    textBox1.Text = "";
                    ServiceID = new string[20];
                    

                    ServiceDes = new string[20];
                    ServicePrice = new double[20];
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

        private void UserServiceRequest_Load(object sender, EventArgs e)
        {
            // display all services that are offered by the company in the datagridview
            try
            {
                con.Open();
                String query = "select Description, Price from Services";
                cmd = new SqlCommand(query, con);
                adapt = new SqlDataAdapter(cmd);
                adapt.SelectCommand.ExecuteNonQuery();
                DataSet ds = new DataSet();
                adapt.Fill(ds, "services");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "services";
                con.Close();
            } catch (Exception ex) { MessageBox.Show(ex.Message); }

            ServiceID[0] = null;
            listBox1.Items.Clear();
            listBox1.Items.Add("Your Cart:");
            listBox1.Items.Add("Service:  \t Price:");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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
            string id = "";
            double price = 0;
            string description = "";
            try
            {
                con.Open();
                string sql = "SELECT * FROM Services WHERE Description = '" + textBox1.Text + "'";
                cmd = new SqlCommand(sql, con);
                adapt = new SqlDataAdapter(cmd);
                adapt.SelectCommand.ExecuteNonQuery();
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                id = ds.Tables[0].Rows[0]["serviceID"].ToString();
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
                if (ServiceID[0] == null)
                {
                    ServiceID[0] = id;
                
                    ServiceDes[0] = description;
                    ServicePrice[0] = price;
                    subtotal += Convert.ToDouble(price);
                    tel++;
                }
                else
                {

                    if (ServiceID.Contains(id))
                    {

                       MessageBox.Show("This Service is already in your cart");
                    }
                    else
                    {
                        // if the user clicks add to cart add the Service description to the list box and if a user adds the same Service twice increase the quantity by 1
                        //grow the array if the user adds a Service that is already in the cart

                        ServiceDes[tel] = (description);
                        ServiceID[tel] = (id);
                        ServicePrice[tel] = (price);
                        subtotal += Convert.ToDouble(price);
                        tel++;
                    }
                }
                listBox1.Items.Clear();
                listBox1.Items.Add("Your Cart:");
                listBox1.Items.Add("Service:  \t Price:");
                for (int i = 0; i < tel; i++)
                {
                    
                    listBox1.Items.Add(ServiceDes[i] + "\t" + ServicePrice[i]);
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
            textBox1.Text = "";
            ServiceID = new string[20];
           

            ServiceDes = new string[20];
            ServicePrice = new double[20];
            tel = 0;

            subtotal = 0;
            listBox1.Items.Clear();
        }
    }
}
