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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // get user information for text boxes
            String Username = textBox1.Text;
            String Password = textBox2.Text;
            String Address = textBox4.Text;
            String Phone = textBox3.Text;

        }
    }
}
