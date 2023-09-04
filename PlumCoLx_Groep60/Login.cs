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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public Login()
        {
            InitializeComponent();
            // initialize connection to database with a relative path
            con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\PlumCoLX.mdf; Integrated Security = True";

           

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // validate login details from text box inputs and check if they appear in the database
            // if they don't apper show register form
            // if they do appear in client table show user form, if they apper in admin table show admin form 
            // if they apper in either one create a text file with the username and date and time of login
            // when the program starts check if the text file exists and if it does show the user form or admin form depending on the text file
            // if the text file doesn't exist show the login form

           
            
                //check user login
                String Username = textBox1.Text;
                String Password = textBox2.Text;
                //check if user exists
                bool userExists = false;
               
                    con.Open();
                    //sql to check if user exists
                    string sql = "SELECT * FROM ClientID WHERE name = '" + Username + "' AND Password = '" + Password + "'";
                    // check if user exists
                    cmd = new SqlCommand(sql, con);
                    adapt = new SqlDataAdapter(cmd);
                    adapt.SelectCommand.ExecuteNonQuery();
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    int count = ds.Tables[0].Rows.Count;
            // get userID from database
            con.Close();

            if (count == 1)
                    {

                int id = (int)ds.Tables[0].Rows[0]["ClientID"];
                //user exists
                userExists = true;
                        //create text file
                        // owerwrite file if it exists
                        string path = "login.txt";
                using (StreamWriter sw = File.CreateText(path))
                        {
                    // write username form text box to file
                    sw.WriteLine(Username);
                    sw.WriteLine(id);
                            sw.WriteLine("user");
                            sw.WriteLine(DateTime.Now);
                        }
                //show user form
               
                User user = new User();
                        user.Show();
                        this.Hide();

                    }
                    else
                    {
                        //check if admin exists
                        con.Open();
                        //sql to check if admin exists
                        string sql2 = "SELECT * FROM Admin WHERE Name = '" + Username + "' AND Password = '" + Password + "'";
                        // check if admin exists
                        cmd = new SqlCommand(sql2, con);
                        adapt = new SqlDataAdapter(cmd);
                    adapt.SelectCommand.ExecuteNonQuery();
                        DataSet ds2 = new DataSet();
                        adapt.Fill(ds2);
                        int count2 = ds2.Tables[0].Rows.Count;
                
                        con.Close();
                        if (count2 == 1)
                        {
                            //admin exists
                            userExists = true;
                            //create text file
                            using (StreamWriter sw = File.CreateText("login.txt"))
                            {
                        // write username form text box to file
                                   sw.WriteLine(Username);
                                sw.WriteLine("admin");
                                sw.WriteLine(DateTime.Now);
                            }
                            //show admin form
                            Admin admin = new Admin();
                            admin.Show();
                            this.Hide();
                        }
                        else
                        {
                            //user doesn't exist
                            MessageBox.Show("Username or Password is incorrect");
                        }
                    

                
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
                
        }

        private void Login_Shown(object sender, EventArgs e)
        {
        //check if file exists

        if (File.Exists("login.txt"))
        {

            //read file
            string lines = File.ReadAllText("login.txt");

            //check if user is admin
            if (lines.Contains("admin"))
            {

                //show admin form
                Admin admin = new Admin();
                this.Hide();
                admin.Show();
                this.Hide();
            }
            else
             if (lines.Contains("user"))
            {
                //show user form
                User user = new User();
                this.Hide();
                user.Show();
                this.Hide();

            }
        }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
