using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlumCoLx_Groep60
{
    public partial class User : Form
    {
        UserInfo Info = new UserInfo();
        UserProducts Products = new UserProducts();
        UserServiceRequest SR = new UserServiceRequest();
        UserAccountInfo AccInfo = new UserAccountInfo();
        UserFinancial Fin = new UserFinancial();
        UserServiceTracking TS = new UserServiceTracking();
        public User()
        {
            InitializeComponent();
        }

        private void navToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInfo fomr = new UserInfo();
           Info.MdiParent = this;
            Info.Show();
            Products.Hide();
            SR.Hide();
            AccInfo.Hide();
            Fin.Hide();
            TS.Hide();
        }

        private void User_Load(object sender, EventArgs e)
        {
           
            Info.MdiParent = this;
            Info.Show();


            // get username from text file
              string path = "login.txt";
            string[] lines = System.IO.File.ReadAllLines(path);
            usernameToolStripMenuItem.Text = lines[0];
            // display username from text file in label

        }

        private void User_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void vanToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Products.MdiParent = this;
           Products.Show();
            Info.Hide();
            SR.Hide();
            AccInfo.Hide();
            Fin.Hide();
            TS.Hide();
        }

        private void navToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SR.MdiParent = this;
            SR.Show();
            Info.Hide();
            Products.Hide();
            AccInfo.Hide();
            Fin.Hide();
            TS.Hide();

        }

        private void accountInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccInfo.MdiParent = this;
            AccInfo.Show();
            Info.Hide();
            Products.Hide();
            SR.Hide();
            Fin.Hide();
            TS.Hide();
        }

        private void userFinancialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fin.MdiParent = this;
            Fin.Show();
            Info.Hide();
            Products.Hide();
            SR.Hide();
            AccInfo.Hide();
            TS.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void trackServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TS.MdiParent = this;
            TS.Show();
            Info.Hide();
            Products.Hide();
            SR.Hide();
            AccInfo.Hide();
            Fin.Hide();
        }
    }
}
