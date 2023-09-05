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
    public partial class Clients : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd;
        SqlDataAdapter adap;

        public Clients()
        {
            InitializeComponent();

            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\37419935\Desktop\Hein123456\PlumCoLx_Groep60\PlumCoLx_Groep60\PlumCoLX.mdf;Integrated Security=True";
        }

        private void btnAddSup_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = $"INSERT INTO ClientID VALUES('{Convert.ToInt32(txtClientID.Text)}','{txtClientName.Text}','{txtPhoneNum.Text}','{txtAddress.Text}','{txtPassword.Text}')";
                con.Open();

                cmd = new SqlCommand(sql, con);
                adap.InsertCommand = cmd;
                adap.InsertCommand.ExecuteNonQuery();

                con.Close();

                con.Open();
                string query = "SELECT * FROM ClientID";
                adap = new SqlDataAdapter(query, con);
                adap.SelectCommand.ExecuteNonQuery();
                DataSet ds = new DataSet();

                adap.Fill(ds, "User");
                dgvClients.DataSource = ds;
                dgvClients.DataMember = "user";
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

                string sql = "DELETE FROM ClientID WHERE ClientID = "  +Convert.ToInt32(txtClientID.Text) ;
                con.Open();

                cmd = new SqlCommand(sql, con);
                adap.DeleteCommand = cmd;
                adap.DeleteCommand.ExecuteNonQuery();

                con.Close();

                con.Open();
                string query = "SELECT * FROM ClientID";
                adap = new SqlDataAdapter(query, con);
                adap.SelectCommand.ExecuteNonQuery();
                DataSet ds = new DataSet();

                adap.Fill(ds, "User");
                dgvClients.DataSource = ds;
                dgvClients.DataMember = "user";
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

                string sql = $"UPDATE ClientID SET ClientID = @ID, Name = @Name, phone_Num = @Number, Address = @Address, Password = @Password WHERE ClientID = "  + Convert.ToInt32(txtClientID.Text);
                con.Open();

                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtClientID.Text));
                cmd.Parameters.AddWithValue("@Name", txtClientName.Text);
                cmd.Parameters.AddWithValue("@Number", txtPhoneNum.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Open();
            string query = "SELECT * FROM ClientID";
            adap = new SqlDataAdapter(query, con);
            adap.SelectCommand.ExecuteNonQuery();
            DataSet ds = new DataSet();

            adap.Fill(ds, "User");
            dgvClients.DataSource = ds;
            dgvClients.DataMember = "user";
            con.Close();
        }

        private void dgvClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            object value = dgvClients.Rows[e.RowIndex].Cells[0].Value;
            if (value != null)
            {
                txtClientID.Text = value.ToString();
            }
            value = dgvClients.Rows[e.RowIndex].Cells[1].Value;
            if (value != null)
            {
                txtClientName.Text = value.ToString();
            }
            value = dgvClients.Rows[e.RowIndex].Cells[2].Value;
            if (value != null)
            {
                txtPhoneNum.Text = value.ToString();
            }
            value = dgvClients.Rows[e.RowIndex].Cells[3].Value;
            if (value != null)
            {
                txtAddress.Text = value.ToString();
            }
            value = dgvClients.Rows[e.RowIndex].Cells[4].Value;
            if (value != null)
            {
                txtPassword.Text = value.ToString();
            }
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM ClientID";
            adap = new SqlDataAdapter(query, con);
            adap.SelectCommand.ExecuteNonQuery();
            DataSet ds = new DataSet();

            adap.Fill(ds, "User");
            dgvClients.DataSource = ds;
            dgvClients.DataMember = "user";
            con.Close();
        }
    }
}

