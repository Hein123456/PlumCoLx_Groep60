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
    public partial class Plumbers : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd;
        SqlDataAdapter adap;

        public Plumbers()
        {
            InitializeComponent();

            con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\PlumCo.mdf; Integrated Security = True";
        }

        private void btnAddSup_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = $"INSERT INTO Employee VALUES('{Convert.ToInt32(txtEmployeeID.Text)}','{txtEmployeeName.Text}','{txtEmpSurname.Text}','{txtEmpNum.Text},'{txtEmpEmail.Text}','{txtDriverLicense.Text}','{txtMedicalHis.Text}','{txtEmergencyContact.Text}','{txtPosition.Text}'')";
                con.Open();

                cmd = new SqlCommand(sql, con);
                adap.InsertCommand = cmd;
                adap.InsertCommand.ExecuteNonQuery();

                con.Close();

                con.Open();
                string query = "SELECT * FROM Employee";
                adap = new SqlDataAdapter(query, con);
                adap.SelectCommand.ExecuteNonQuery();
                DataSet ds = new DataSet();

                adap.Fill(ds, "User");
                dgvPlumbers.DataSource = ds;
                dgvPlumbers.DataMember = "user";
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

                string sql = "DELETE FROM Employee WHERE JobId = '" + dgvPlumbers.SelectedRows + "'";
                con.Open();

                cmd = new SqlCommand(sql, con);
                adap.DeleteCommand = cmd;
                adap.DeleteCommand.ExecuteNonQuery();

                con.Close();

                con.Open();
                string query = "SELECT * FROM Employee";
                adap = new SqlDataAdapter(query, con);
                adap.SelectCommand.ExecuteNonQuery();
                DataSet ds = new DataSet();

                adap.Fill(ds, "User");
                dgvPlumbers.DataSource = ds;
                dgvPlumbers.DataMember = "user";
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

                string sql = $"UPDATE Employee SET employeeId = @ID, Name = @Name, Surname = @Surname, phoneNum = @Number, Email_address = @Email, Driverse_lisense = @Drivers, Medical_History = @Medical, Emergency_Contact = @Emergency, Position = @Position WHERE '" + dgvPlumbers.SelectedRows + "'";
                con.Open();

                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtEmployeeID.Text));
                cmd.Parameters.AddWithValue("@Name", txtEmployeeName.Text);
                cmd.Parameters.AddWithValue("@Surname", txtEmpSurname.Text);
                cmd.Parameters.AddWithValue("@Number", txtEmpNum.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmpEmail.Text);
                cmd.Parameters.AddWithValue("@Drivers", txtDriverLicense.Text);
                cmd.Parameters.AddWithValue("@Medical", txtMedicalHis.Text);
                cmd.Parameters.AddWithValue("@Emergency", txtEmergencyContact.Text);
                cmd.Parameters.AddWithValue("@Position", txtPosition.Text);
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Open();
            string query = "SELECT * FROM Employee";
            adap = new SqlDataAdapter(query, con);
            adap.SelectCommand.ExecuteNonQuery();
            DataSet ds = new DataSet();

            adap.Fill(ds, "User");
            dgvPlumbers.DataSource = ds;
            dgvPlumbers.DataMember = "user";
            con.Close();
        }

        private void dgvPlumbers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            object value = dgvPlumbers.Rows[e.RowIndex].Cells[0].Value;
            if (value != null)
            {
                txtEmployeeID.Text = value.ToString();
            }
            value = dgvPlumbers.Rows[e.RowIndex].Cells[1].Value;
            if (value != null)
            {
                txtEmployeeName.Text = value.ToString();
            }
            value = dgvPlumbers.Rows[e.RowIndex].Cells[2].Value;
            if (value != null)
            {
                txtEmpSurname.Text = value.ToString();
            }
            value = dgvPlumbers.Rows[e.RowIndex].Cells[3].Value;
            if (value != null)
            {
                txtEmpNum.Text = value.ToString();
            }
            value = dgvPlumbers.Rows[e.RowIndex].Cells[4].Value;
            if (value != null)
            {
                txtEmpEmail.Text = value.ToString();
            }
            value = dgvPlumbers.Rows[e.RowIndex].Cells[5].Value;
            if (value != null)
            {
                txtDriverLicense.Text = value.ToString();
            }
            value = dgvPlumbers.Rows[e.RowIndex].Cells[6].Value;
            if (value != null)
            {
                txtMedicalHis.Text = value.ToString();
            }
            value = dgvPlumbers.Rows[e.RowIndex].Cells[7].Value;
            if (value != null)
            {
                txtEmergencyContact.Text = value.ToString();
            }
            value = dgvPlumbers.Rows[e.RowIndex].Cells[8].Value;
            if (value != null)
            {
                txtPosition.Text = value.ToString();
            }
        }

        private void Plumbers_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM Employee";
            adap = new SqlDataAdapter(query, con);
            adap.SelectCommand.ExecuteNonQuery();
            DataSet ds = new DataSet();

            adap.Fill(ds, "User");
            dgvPlumbers.DataSource = ds;
            dgvPlumbers.DataMember = "user";
            con.Close();
        }
    }
}
