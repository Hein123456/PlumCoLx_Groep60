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
        // create absolute path to database
      
        SqlCommand cmd;
        SqlDataAdapter adapt;

        public Login()
        {
            InitializeComponent();
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
            
            //check if file exists
            if (File.Exists("login.txt"))
            {
                //read file
                string[] lines = File.ReadAllLines("login.txt");
                //check if user is admin
                if (lines[0] == "admin")
                {
                    //show admin form
                    Admin admin = new Admin();
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    //show user form
                    User user = new User();
                    user.Show();
                    this.Hide();
                }
            }
            else
            {
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
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    int count = ds.Tables[0].Rows.Count;
                    con.Close();
                    if (count == 1)
                    {
                        //user exists
                        userExists = true;
                        //create text file
                        using (StreamWriter sw = File.CreateText("login.txt"))
                        {
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
        }
    }
}
