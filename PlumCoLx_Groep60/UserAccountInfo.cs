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
    public partial class UserAccountInfo : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public UserAccountInfo()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\PlumCo.mdf; Integrated Security = True";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //update user info at client id that is received from txtID
            // display user info in datagridview
            con.Open();
            string query = "UPDATE ClientID SET name = '" + txtName.Text + "', phone_Num = '" + txtPhoneNumber.Text + "', Address = '" + txtAddress.Text + "', Password = '" + txtPassword.Text + "' WHERE ClientID = '" + txtID.Text + "'";
            SqlDataAdapter adapt = new SqlDataAdapter(query, con);
            adapt.UpdateCommand.ExecuteNonQuery();
            string query1 = "SELECT * FROM ClientID WHERE ClientID = '" + txtID.Text + "'";
            DataSet ds = new DataSet();

            adapt.Fill(ds, "User");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "user";
            txtID.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            txtPhoneNumber.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            txtAddress.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
            con.Close();
        }

        private void UserAccountInfo_Load(object sender, EventArgs e)
        {

        }

        private void UserAccountInfo_Shown(object sender, EventArgs e)
        {
            // get user id from text file login.txt
            string[] lines = File.ReadAllLines("login.txt");
             string id = lines[1];
            // display user info in datagridview
            con.Open();
            string query = "SELECT * FROM ClientID WHERE ClientID = '" + id + "'";
            adapt = new SqlDataAdapter(query, con);
            adapt.SelectCommand.ExecuteNonQuery();
            DataSet ds = new DataSet();
            
            adapt.Fill(ds, "User");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "user";
            txtID.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            txtPhoneNumber.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            txtAddress.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
            con.Close();
            // insert user information from datagridview into textboxes
            

        }
    }
}
