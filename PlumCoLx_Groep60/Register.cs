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
    public partial class Register : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public Register()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\PlumCo.mdf; Integrated Security = True";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // get user information for text boxes
            String Username = textBox1.Text;
            String Password = textBox2.Text;
            String Address = textBox4.Text;
            String Phone = textBox3.Text;
            // check if user exists
            con.Open();
            string sql = "SELECT * FROM ClientID WHERE name = '" + Username + "' AND Password = '" + Password + "'";
            cmd = new SqlCommand(sql, con);
            adapt = new SqlDataAdapter(cmd);
            adapt.SelectCommand.ExecuteNonQuery();
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            int count = ds.Tables[0].Rows.Count;
            con.Close();
            // if user doesn't exist add user to database
            if (count == 0)
            {
                con.Open();
                //generate new integer id based on ids in table
                string sql1 = "SELECT MAX(ClientID) FROM ClientID";
                cmd = new SqlCommand(sql1, con);
                adapt = new SqlDataAdapter(cmd);
                adapt.SelectCommand.ExecuteNonQuery();
                DataSet ds1 = new DataSet();
                adapt.Fill(ds1);
                int id = Convert.ToInt32(ds1.Tables[0].Rows[0][0]) + 1;

                con.Close();
                con.Open();
                // add user to database
                string sql2 = "INSERT INTO ClientID (ClientID, name, Password, Address, phone_Num) VALUES ("+id+"'" + Username + "', '" + Password + "', '" + Address + "', '" + Phone + "')";
                cmd = new SqlCommand(sql2, con);
                adapt = new SqlDataAdapter(cmd);
                adapt.InsertCommand.ExecuteNonQuery();
                // create text file with username
                con.Close();
                string path = "login.txt";
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(Username);
                    sw.WriteLine(id);
                    sw.WriteLine("user");
                    sw.WriteLine(DateTime.Now);
                }
                // show user form
                User user = new User();
                user.Show();
                this.Hide();
            }
            else
            {
                // if user exists show error message
                MessageBox.Show("User already exists");
            }   

        }
    }
}
