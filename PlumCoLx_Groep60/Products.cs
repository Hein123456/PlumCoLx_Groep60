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
    public partial class Products : Form
    {

        SqlConnection con = new SqlConnection();
        SqlCommand cmd;
        SqlDataAdapter adap;

        public Products()
        {
            InitializeComponent();

            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\37419935\Desktop\Hein123456\PlumCoLx_Groep60\PlumCoLx_Groep60\PlumCoLX.mdf;Integrated Security=True";
        }

        private void btnAddSup_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = $"INSERT INTO Product VALUES('{Convert.ToInt32(txtProductID.Text)}','{Convert.ToInt32(txtSupplierID.Text)}','{txtProductDesc.Text}','{txtProductName.Text}','{txtProductCategory.Text}','{Convert.ToDouble(txtProductPrice.Text)}','{Convert.ToInt32(txtQuantity.Text)}','{Convert.ToDateTime(txtDateTime.Text)}')";
                con.Open();

                cmd = new SqlCommand(sql, con);
                adap.InsertCommand = cmd;
                adap.InsertCommand.ExecuteNonQuery();

                con.Close();

                con.Open();
                string query = "SELECT * FROM Product";
                adap = new SqlDataAdapter(query, con);
                adap.SelectCommand.ExecuteNonQuery();
                DataSet ds = new DataSet();

                adap.Fill(ds, "User");
                dgvProducts.DataSource = ds;
                dgvProducts.DataMember = "user";
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

                string sql = "DELETE FROM Product WHERE productId = '" + dgvProducts.SelectedRows + "'";
                con.Open();

                cmd = new SqlCommand(sql, con);
                adap.DeleteCommand = cmd;
                adap.DeleteCommand.ExecuteNonQuery();

                con.Close();

                con.Open();
                string query = "SELECT * FROM Product";
                adap = new SqlDataAdapter(query, con);
                adap.SelectCommand.ExecuteNonQuery();
                DataSet ds = new DataSet();

                adap.Fill(ds, "User");
                dgvProducts.DataSource = ds;
                dgvProducts.DataMember = "user";
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

                string sql = $"UPDATE Product SET productId = @ID, SupplierID = @Supplier, Description = @Desc, name = @Name, plumbing_category = @Category, Price = @Price, quantity = @Quantity, dateTime = @DateTime WHERE '" + dgvProducts.SelectedRows + "'";
                con.Open();

                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtProductID.Text));
                cmd.Parameters.AddWithValue("@Supplier", Convert.ToInt32(txtSupplierID.Text));
                cmd.Parameters.AddWithValue("@Desc", txtProductDesc.Text);
                cmd.Parameters.AddWithValue("@Name", txtProductName.Text);
                cmd.Parameters.AddWithValue("@Category", txtProductCategory.Text);
                cmd.Parameters.AddWithValue("@Price", Convert.ToDouble(txtProductPrice.Text));
                cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txtQuantity.Text));
                cmd.Parameters.AddWithValue("@DateTime", Convert.ToDateTime(txtDateTime.Text));
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Open();
            string query = "SELECT * FROM Product";
            adap = new SqlDataAdapter(query, con);
            adap.SelectCommand.ExecuteNonQuery();
            DataSet ds = new DataSet();

            adap.Fill(ds, "User");
            dgvProducts.DataSource = ds;
            dgvProducts.DataMember = "user";
            con.Close();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            object value = dgvProducts.Rows[e.RowIndex].Cells[0].Value;
            if (value != null)
            {
                txtProductID.Text = value.ToString();
            }
            value = dgvProducts.Rows[e.RowIndex].Cells[1].Value;
            if (value != null)
            {
                txtSupplierID.Text = value.ToString();
            }
            value = dgvProducts.Rows[e.RowIndex].Cells[2].Value;
            if (value != null)
            {
                txtProductDesc.Text = value.ToString();
            }
            value = dgvProducts.Rows[e.RowIndex].Cells[3].Value;
            if (value != null)
            {
                txtProductName.Text = value.ToString();
            }
            value = dgvProducts.Rows[e.RowIndex].Cells[4].Value;
            if (value != null)
            {
                txtProductCategory.Text = value.ToString();
            }
            value = dgvProducts.Rows[e.RowIndex].Cells[5].Value;
            if (value != null)
            {
                txtProductPrice.Text = value.ToString();
            }
            value = dgvProducts.Rows[e.RowIndex].Cells[6].Value;
            if (value != null)
            {
                txtQuantity.Text = value.ToString();
            }
            value = dgvProducts.Rows[e.RowIndex].Cells[7].Value;
            if (value != null)
            {
                txtDateTime.Text = value.ToString();
            }
        }

        private void Products_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM Product";
            adap = new SqlDataAdapter(query, con);
            adap.SelectCommand.ExecuteNonQuery();
            DataSet ds = new DataSet();

            adap.Fill(ds, "User");
            dgvProducts.DataSource = ds;
            dgvProducts.DataMember = "user";
            con.Close();
        }
    }
}
