﻿using System;
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

            con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\PlumCo.mdf; Integrated Security = True";
        }

        private void btnAddSup_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = $"INSERT INTO Product VALUES('{txtProductID.Text}','{txtSupplierID.Text}','{txtProductDesc.Text}','{txtProductName.Text}','{txtProductCategory.Text}','{txtProductPrice.Text}','{txtQuantity.Text}','{txtDateTime.Text}')";
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

                string sql = "DELETE FROM Product WHERE productId = '" + dgvProducts.SelectedRows + "'";
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

                string sql = $"UPDATE Product SET productId = @ID AND SupplierID = @Supplier AND Description = @Desc AND name = @Name AND plumbing_category = @Category AND Price = @Price AND quantity = @Quantity AND dateTime = @DateTime WHERE '" + dgvProducts.SelectedRows + "'";
                con.Open();

                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ID", txtProductID.Text);
                cmd.Parameters.AddWithValue("@Supplier", txtSupplierID.Text);
                cmd.Parameters.AddWithValue("@Desc", txtProductDesc.Text);
                cmd.Parameters.AddWithValue("@Name", txtProductName.Text);
                cmd.Parameters.AddWithValue("@Category", txtProductCategory.Text);
                cmd.Parameters.AddWithValue("@Price", txtProductPrice.Text);
                cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text);
                cmd.Parameters.AddWithValue("@DateTime", txtDateTime.Text);
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
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                object value = dgvProducts.Rows[e.RowIndex].Cells[0].Value;

                if (value != null)
                {
                    txtProductID.Text = value.ToString();
                }
                else
                {
                    txtProductID.Text = string.Empty;
                }

                object value2 = dgvProducts.Rows[e.RowIndex].Cells[1].Value;

                if (value != null)
                {
                    txtSupplierID.Text = value.ToString();
                }
                else
                {
                    txtSupplierID.Text = string.Empty;
                }

                object value3 = dgvProducts.Rows[e.RowIndex].Cells[2].Value;

                if (value != null)
                {
                    txtProductDesc.Text = value.ToString();
                }
                else
                {
                    txtProductDesc.Text = string.Empty;
                }

                object value4 = dgvProducts.Rows[e.RowIndex].Cells[3].Value;

                if (value != null)
                {
                    txtProductName.Text = value.ToString();
                }
                else
                {
                    txtProductName.Text = string.Empty;
                }

                object value5 = dgvProducts.Rows[e.RowIndex].Cells[4].Value;

                if (value != null)
                {
                    txtProductCategory.Text = value.ToString();
                }
                else
                {
                    txtProductCategory.Text = string.Empty;
                }

                object value6 = dgvProducts.Rows[e.RowIndex].Cells[5].Value;

                if (value != null)
                {
                    txtProductPrice.Text = value.ToString();
                }
                else
                {
                    txtProductPrice.Text = string.Empty;
                }

                object value7 = dgvProducts.Rows[e.RowIndex].Cells[6].Value;

                if (value != null)
                {
                    txtQuantity.Text = value.ToString();
                }
                else
                {
                    txtQuantity.Text = string.Empty;
                }

                object value8 = dgvProducts.Rows[e.RowIndex].Cells[7].Value;

                if (value != null)
                {
                    txtDateTime.Text = value.ToString();
                }
                else
                {
                    txtDateTime.Text = string.Empty;
                }
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
