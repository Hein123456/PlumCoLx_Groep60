using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PlumCoLx_Groep60
{
    public partial class Finances : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd;
        SqlDataAdapter adap;

        public Finances()
        {
            InitializeComponent();

            con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\PlumCo.mdf; Integrated Security = True";
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "select *, (select sum(Total) from ServiceOrder WHERE Status = 'Waiting For Payment') as TotalCost from ServiceOrder WHERE Status = 'Waiting For Payment'";

                cmd = new SqlCommand(query, con);
                adap = new SqlDataAdapter(cmd);
                adap.SelectCommand.ExecuteNonQuery();
                DataSet ds = new DataSet();
                adap.Fill(ds, "ServiceOrder");
                dgvFinances.DataSource = ds;
                dgvFinances.DataMember = "ServiceOrder";
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "select * from ServiceOrder";
                cmd = new SqlCommand(query, con);
                adap = new SqlDataAdapter(cmd);
                adap.SelectCommand.ExecuteNonQuery();
                DataSet ds = new DataSet();
                adap.Fill(ds, "ServiceOrder");
                dgvFinances.DataSource = ds;
                dgvFinances.DataMember = "ServiceOrder";
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
