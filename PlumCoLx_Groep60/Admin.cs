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
    public partial class Admin : Form
    {
        Equipment myForm = new Equipment();
        Products myForm2 = new Products();
        Jobs myForm3 = new Jobs();
        Plumbers myForm4 = new Plumbers();
        Clients myForm5 = new Clients();
        Finances myForm6 = new Finances();

        public Admin()
        {
            InitializeComponent();
        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myForm.MdiParent = this;
            myForm.Show();

            myForm2.Hide();
            myForm3.Hide();
            myForm4.Hide();
            myForm5.Hide();
            myForm6.Hide();

        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myForm2.MdiParent = this;
            myForm2.Show();

            myForm.Hide();
            myForm3.Hide();
            myForm4.Hide();
            myForm5.Hide();
            myForm6.Hide();
        }

        private void jobsToolStripMenuItem_Click(object sender, EventArgs e)
        {         
            myForm3.MdiParent = this;
            myForm3.Show();

            myForm2.Hide();
            myForm.Hide();
            myForm4.Hide();
            myForm5.Hide();
            myForm6.Hide();
        }

        private void plumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myForm4.MdiParent = this;
            myForm4.Show();

            myForm2.Hide();
            myForm3.Hide();
            myForm.Hide();
            myForm5.Hide();
            myForm6.Hide();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {         
            myForm5.MdiParent = this;
            myForm5.Show();

            myForm2.Hide();
            myForm3.Hide();
            myForm4.Hide();
            myForm.Hide();
            myForm6.Hide();
        }

        private void financesToolStripMenuItem_Click(object sender, EventArgs e)
        {         
            myForm6.MdiParent = this;
            myForm6.Show();

            myForm2.Hide();
            myForm3.Hide();
            myForm4.Hide();
            myForm5.Hide();
            myForm.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void switchUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // delete file
            System.IO.File.Delete("login.txt");
            // show login
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
