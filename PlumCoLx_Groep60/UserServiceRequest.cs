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
    public partial class UserServiceRequest : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd;
        SqlDataAdapter adapt;
        string userid = "";
        public UserServiceRequest()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\PlumCo.mdf; Integrated Security = True";
            string[] lines = File.ReadAllLines("login.txt");
            userid = lines[1];
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void UserServiceRequest_Load(object sender, EventArgs e)
        {
            // display all services that are offered by the company in the datagridview
            try
            {
                con.Open();
                String query = "select * from Services";
                cmd = new SqlCommand(query, con);
                adapt = new SqlDataAdapter(cmd);
                adapt.SelectCommand.ExecuteNonQuery();
                DataSet ds = new DataSet();
                adapt.Fill(ds, "services");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "services";
                con.Close();
            } catch (Exception ex) { MessageBox.Show(ex.Message); }


        }
    }
}
