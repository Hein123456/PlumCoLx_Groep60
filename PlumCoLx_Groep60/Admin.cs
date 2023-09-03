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
        public Admin()
        {
            InitializeComponent();
        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipment myForm = new Equipment();
            myForm.MdiParent = this;
            myForm.Show();

        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products myForm = new Products();
            myForm.MdiParent = this;
            myForm.Show();
        }

        private void jobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Jobs myForm = new Jobs();
            myForm.MdiParent = this;
            myForm.Show();
        }

        private void plumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plumbers myForm = new Plumbers();
            myForm.MdiParent = this;
            myForm.Show();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clients myForm = new Clients();
            myForm.MdiParent = this;
            myForm.Show();
        }

        private void financesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Finances myForm = new Finances();
            myForm.MdiParent = this;
            myForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
