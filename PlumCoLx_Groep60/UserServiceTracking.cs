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
    public partial class UserServiceTracking : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd;
        SqlDataAdapter adapt;
        string userid = "";
        public UserServiceTracking()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\PlumCo.mdf; Integrated Security = True";
            string[] lines = File.ReadAllLines("login.txt");
            userid = lines[1];
        }

        private void UserServiceTracking_Load(object sender, EventArgs e)
        {
            // display all service requests from the Jobs tabel and the Joblog table where the client id is the same as the logged in user in the datagridview
            con.Open();
            String query = "select * from Jobs where ClientID = '" + userid + "'";
            cmd = new SqlCommand(query, con);
            adapt = new SqlDataAdapter(cmd);
            adapt.SelectCommand.ExecuteNonQuery();
            DataSet ds = new DataSet();
            adapt.Fill(ds, "jobs");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "jobs";
            con.Close();
            String query2 = "select * from Joblog where ClientID = '" + userid + "'";
            con.Close();
            con.Open();
            cmd = new SqlCommand(query2, con);
            adapt = new SqlDataAdapter(cmd);
            adapt.SelectCommand.ExecuteNonQuery();
            
                adapt.Fill(ds, "jobs");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "jobs";
            con.Close();



        }
    }
}
