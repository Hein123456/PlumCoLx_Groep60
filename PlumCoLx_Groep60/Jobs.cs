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
    public partial class Jobs : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd;
        SqlDataAdapter adap;

        public Jobs()
        {
            InitializeComponent();

            con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\PlumCo.mdf; Integrated Security = True";
        }

        private void btnAddSup_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = $"INSERT INTO Jobs VALUES('{txtJobID.Text}','{txtClientID.Text}','{txtJobDesc.Text}','{txtJobStatus.Text}')";
                con.Open();

                cmd = new SqlCommand(sql, con);
                adap.InsertCommand = cmd;
                adap.InsertCommand.ExecuteNonQuery();

                con.Close();

                con.Open();
                string query = "SELECT * FROM Jobs";
                adap = new SqlDataAdapter(query, con);
                adap.SelectCommand.ExecuteNonQuery();
                DataSet ds = new DataSet();

                adap.Fill(ds, "User");
                dgvJobs.DataSource = ds;
                dgvJobs.DataMember = "user";
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemoveSup_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = "DELETE FROM Jobs WHERE JobId = '" + dgvJobs.SelectedRows + "'";
                con.Open();

                cmd = new SqlCommand(sql, con);
                adap.DeleteCommand = cmd;
                adap.DeleteCommand.ExecuteNonQuery();

                con.Close();

                con.Open();
                string query = "SELECT * FROM Jobs";
                adap = new SqlDataAdapter(query, con);
                adap.SelectCommand.ExecuteNonQuery();
                DataSet ds = new DataSet();

                adap.Fill(ds, "User");
                dgvJobs.DataSource = ds;
                dgvJobs.DataMember = "user";
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditSup_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = $"UPDATE Jobs SET JobId = @ID, ClientID = @Client, description = @Desc, status = @Status WHERE '" + dgvJobs.SelectedRows + "'";
                con.Open();

                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ID", txtJobID.Text);
                cmd.Parameters.AddWithValue("@Supplier", txtClientID.Text);
                cmd.Parameters.AddWithValue("@Desc", txtJobDesc.Text);
                cmd.Parameters.AddWithValue("@Name", txtJobStatus.Text);
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Open();
            string query = "SELECT * FROM Jobs";
            adap = new SqlDataAdapter(query, con);
            adap.SelectCommand.ExecuteNonQuery();
            DataSet ds = new DataSet();

            adap.Fill(ds, "User");
            dgvJobs.DataSource = ds;
            dgvJobs.DataMember = "user";
            con.Close();
        }

        private void dgvJobs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                object value = dgvJobs.Rows[e.RowIndex].Cells[0].Value;

                if (value != null)
                {
                    txtJobID.Text = value.ToString();
                }
                else
                {
                    txtJobID.Text = string.Empty;
                }

                object value2 = dgvJobs.Rows[e.RowIndex].Cells[1].Value;

                if (value != null)
                {
                    txtClientID.Text = value.ToString();
                }
                else
                {
                    txtClientID.Text = string.Empty;
                }

                object value3 = dgvJobs.Rows[e.RowIndex].Cells[2].Value;

                if (value != null)
                {
                    txtJobDesc.Text = value.ToString();
                }
                else
                {
                    txtJobDesc.Text = string.Empty;
                }

                object value4 = dgvJobs.Rows[e.RowIndex].Cells[3].Value;

                if (value != null)
                {
                    txtJobStatus.Text = value.ToString();
                }
                else
                {
                    txtJobStatus.Text = string.Empty;
                }
            }
        }

        private void Jobs_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM Jobs";
            adap = new SqlDataAdapter(query, con);
            adap.SelectCommand.ExecuteNonQuery();
            DataSet ds = new DataSet();

            adap.Fill(ds, "User");
            dgvJobs.DataSource = ds;
            dgvJobs.DataMember = "user";
            con.Close();
        }
    }
}

