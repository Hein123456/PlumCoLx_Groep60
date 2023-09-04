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

            con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\PlumCoLX.mdf; Integrated Security = True";
        }

        private void btnAddSup_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = $"INSERT INTO Employee VALUES('{txtEmployeeID.Text}','{txtEmployeeName.Text}','{txtEmpSurname.Text}','{txtEmpNum.Text},'{txtEmpEmail.Text}','{txtDriverLicense.Text}','{txtAllergies.Text}','{txtCriminalRec.Text}','{txtMedicalHis.Text}','{txtMaritalStatus.Text}','{txtEmergencyContact.Text}','{txtPosition.Text}'')";
                con.Open();

                cmd = new SqlCommand(sql, con);
                adap.InsertCommand = cmd;
                adap.InsertCommand.ExecuteNonQuery();

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

                string sql = $"UPDATE Employee SET employeeId = @ID AND Name = @Name AND Surname = @Surname AND phoneNum = @Number AND Email_address = @Email AND Driverse_lisense = @Drivers AND Allergies = @Allergies AND Criminal_Record = @Criminal AND Medical_History = @Medical AND Maritial_Status = @Married AND Emergency_Contact = @Emergency AND Position = @Position WHERE '" + dgvPlumbers.SelectedRows + "'";
                con.Open();

                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ID", txtEmployeeID.Text);
                cmd.Parameters.AddWithValue("@Name", txtEmployeeName.Text);
                cmd.Parameters.AddWithValue("@Surname", txtEmpSurname.Text);
                cmd.Parameters.AddWithValue("@Number", txtEmpNum.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmpEmail.Text);
                cmd.Parameters.AddWithValue("@Drivers", txtDriverLicense.Text);
                cmd.Parameters.AddWithValue("@Allergies", txtAllergies.Text);
                cmd.Parameters.AddWithValue("@Criminal", txtCriminalRec.Text);
                cmd.Parameters.AddWithValue("@Medical", txtMedicalHis.Text);
                cmd.Parameters.AddWithValue("@Married", txtMaritalStatus.Text);
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
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                object value = dgvPlumbers.Rows[e.RowIndex].Cells[0].Value;

                if (value != null)
                {
                    txtEmployeeID.Text = value.ToString();
                }
                else
                {
                    txtEmployeeID.Text = string.Empty;
                }

                object value2 = dgvPlumbers.Rows[e.RowIndex].Cells[1].Value;

                if (value != null)
                {
                    txtEmployeeName.Text = value.ToString();
                }
                else
                {
                    txtEmployeeName.Text = string.Empty;
                }

                object value3 = dgvPlumbers.Rows[e.RowIndex].Cells[2].Value;

                if (value != null)
                {
                    txtEmpSurname.Text = value.ToString();
                }
                else
                {
                    txtEmpSurname.Text = string.Empty;
                }

                object value4 = dgvPlumbers.Rows[e.RowIndex].Cells[3].Value;

                if (value != null)
                {
                    txtEmpNum.Text = value.ToString();
                }
                else
                {
                    txtEmpNum.Text = string.Empty;
                }

                object value5 = dgvPlumbers.Rows[e.RowIndex].Cells[4].Value;

                if (value != null)
                {
                    txtEmpEmail.Text = value.ToString();
                }
                else
                {
                    txtEmpEmail.Text = string.Empty;
                }

                object value6 = dgvPlumbers.Rows[e.RowIndex].Cells[5].Value;

                if (value != null)
                {
                    txtDriverLicense.Text = value.ToString();
                }
                else
                {
                    txtDriverLicense.Text = string.Empty;
                }

                object value7 = dgvPlumbers.Rows[e.RowIndex].Cells[6].Value;

                if (value != null)
                {
                    txtAllergies.Text = value.ToString();
                }
                else
                {
                    txtAllergies.Text = string.Empty;
                }

                object value8 = dgvPlumbers.Rows[e.RowIndex].Cells[7].Value;

                if (value != null)
                {
                    txtCriminalRec.Text = value.ToString();
                }
                else
                {
                    txtCriminalRec.Text = string.Empty;
                }

                object value9 = dgvPlumbers.Rows[e.RowIndex].Cells[8].Value;

                if (value != null)
                {
                    txtMedicalHis.Text = value.ToString();
                }
                else
                {
                    txtMedicalHis.Text = string.Empty;
                }

                object value10 = dgvPlumbers.Rows[e.RowIndex].Cells[9].Value;

                if (value != null)
                {
                    txtMaritalStatus.Text = value.ToString();
                }
                else
                {
                    txtMaritalStatus.Text = string.Empty;
                }

                object value11 = dgvPlumbers.Rows[e.RowIndex].Cells[10].Value;

                if (value != null)
                {
                    txtEmergencyContact.Text = value.ToString();
                }
                else
                {
                    txtEmergencyContact.Text = string.Empty;
                }

                object value12 = dgvPlumbers.Rows[e.RowIndex].Cells[11].Value;

                if (value != null)
                {
                    txtPosition.Text = value.ToString();
                }
                else
                {
                    txtPosition.Text = string.Empty;
                }
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
