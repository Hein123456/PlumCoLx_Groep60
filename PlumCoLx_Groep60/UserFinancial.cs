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
    public partial class UserFinancial : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd;
        SqlDataAdapter adapt;
        string userid = "";
        public UserFinancial()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\PlumCo.mdf; Integrated Security = True";
            string[] lines = File.ReadAllLines("login.txt");
            userid = lines[1];
        }

        private void UserFinancial_Load(object sender, EventArgs e)
        {
            //display all pending services from the ServiceOrder table where the client id is the same as the logged in user in the datagridview
            try
            {
                con.Open();
                String query = "select * from ServiceOrder where ClientID = '" + userid + "'";
                cmd = new SqlCommand(query, con);
                adapt = new SqlDataAdapter(cmd);
                adapt.SelectCommand.ExecuteNonQuery();
                DataSet ds = new DataSet();
                adapt.Fill(ds, "ServiceOrder");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "ServiceOrder";
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //display all pending services from the ServiceOrder table where the client id is the same as the logged in user in the datagridview
            try
            {
                con.Open();
                // display all where the status is Waiting For Payment and create a new field with the total cost of the service
                String query = "select *, (select sum(Total) from ServiceOrder where ClientID = '" + userid + "' and Status = 'Waiting For Payment') as TotalCost from ServiceOrder where ClientID = '" + userid + "' and Status = 'Waiting For Payment'";
        
                cmd = new SqlCommand(query, con);
                adapt = new SqlDataAdapter(cmd);
                adapt.SelectCommand.ExecuteNonQuery();
                DataSet ds = new DataSet();
                adapt.Fill(ds, "ServiceOrder");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "ServiceOrder";
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "select * from ServiceOrder where ClientID = '" + userid + "'";
                cmd = new SqlCommand(query, con);
                adapt = new SqlDataAdapter(cmd);
                adapt.SelectCommand.ExecuteNonQuery();
                DataSet ds = new DataSet();
                adapt.Fill(ds, "ServiceOrder");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "ServiceOrder";
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
