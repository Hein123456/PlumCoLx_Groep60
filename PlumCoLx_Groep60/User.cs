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
        }

        private void User_Load(object sender, EventArgs e)
        {
           
            Info.MdiParent = this;
            Info.Show();
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
        }
    }
}
