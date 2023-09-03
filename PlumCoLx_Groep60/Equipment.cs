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
    public partial class Equipment : Form
    {

        SqlConnection con = new SqlConnection();
        SqlCommand cmd;
        SqlDataAdapter adap;

        public Equipment()
        {
            InitializeComponent();

            con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\PlumCo.mdf; Integrated Security = True";
        }

        private void btnAddSup_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = $"INSERT INTO Equipment VALUES('{txtEquipmentID.Text}','{txtEquipmentPrice.Text}','{txtEquipmentType.Text}','{txtEquipmentDesc.Text}','{txtEquipmentName.Text}','{txtEquipmentStatus.Text}')";
                con.Open();

                cmd = new SqlCommand(sql, con);
                adap.InsertCommand = cmd;
                adap.InsertCommand.ExecuteNonQuery();

                con.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemoveSup_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = "DELETE FROM Equipment WHERE EquipmentId = '" + dgvEquipment.SelectedRows + "'";
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

                string sql = $"UPDATE Equipment SET EquipmentId = @ID AND eqPrice = @Price AND eqType = @Type AND eqDescription = @Desc AND eqName = @Name AND eqStatus = @Status WHERE '"+ dgvEquipment.SelectedRows +"'";
                con.Open();

                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ID", txtEquipmentID.Text);
                cmd.Parameters.AddWithValue("@Price", txtEquipmentPrice.Text);
                cmd.Parameters.AddWithValue("@Type", txtEquipmentType.Text);
                cmd.Parameters.AddWithValue("@Desc", txtEquipmentDesc.Text);
                cmd.Parameters.AddWithValue("@Name", txtEquipmentName.Text);
                cmd.Parameters.AddWithValue("@Status", txtEquipmentStatus.Text);
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Open();
            string query = "SELECT * FROM Equipment";
            adap = new SqlDataAdapter(query, con);
            adap.SelectCommand.ExecuteNonQuery();
            DataSet ds = new DataSet();

            adap.Fill(ds, "User");
            dgvEquipment.DataSource = ds;
            dgvEquipment.DataMember = "user";
            con.Close();


        }

        private void txtEquipmentDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEquipmentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEquipmentStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEquipmentPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEquipmentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEquipmentType_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvEquipment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                object value = dgvEquipment.Rows[e.RowIndex].Cells[0].Value;

                if (value != null)
                {
                    txtEquipmentID.Text = value.ToString();
                }
                else
                {
                    txtEquipmentID.Text = string.Empty; 
                }

                object value2 = dgvEquipment.Rows[e.RowIndex].Cells[1].Value;

                if (value != null)
                {
                    txtEquipmentPrice.Text = value.ToString();
                }
                else
                {
                    txtEquipmentPrice.Text = string.Empty;
                }

                object value3 = dgvEquipment.Rows[e.RowIndex].Cells[2].Value;

                if (value != null)
                {
                    txtEquipmentType.Text = value.ToString();
                }
                else
                {
                    txtEquipmentType.Text = string.Empty;
                }

                object value4 = dgvEquipment.Rows[e.RowIndex].Cells[3].Value;

                if (value != null)
                {
                    txtEquipmentDesc.Text = value.ToString();
                }
                else
                {
                    txtEquipmentDesc.Text = string.Empty;
                }

                object value5 = dgvEquipment.Rows[e.RowIndex].Cells[4].Value;

                if (value != null)
                {
                    txtEquipmentName.Text = value.ToString();
                }
                else
                {
                    txtEquipmentName.Text = string.Empty;
                }

                object value6 = dgvEquipment.Rows[e.RowIndex].Cells[5].Value;

                if (value != null)
                {
                    txtEquipmentStatus.Text = value.ToString();
                }
                else
                {
                    txtEquipmentStatus.Text = string.Empty;
                }
            }
        }
    }
}
