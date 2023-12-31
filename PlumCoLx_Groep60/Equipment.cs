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
    public partial class Equipment : Form
    {

        SqlConnection con = new SqlConnection();
        SqlCommand cmd;
        SqlDataAdapter adap;

        public Equipment()
        {
            InitializeComponent();

            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PlumCoLX.mdf;Integrated Security=True";
        }

        private void btnAddSup_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = $"INSERT INTO Equipment VALUES('{Convert.ToInt32(txtEquipmentID.Text)}','{Convert.ToDouble(txtEquipmentPrice.Text)}','{txtEquipmentDesc.Text}','{txtEquipmentName.Text}','{txtEquipmentStatus.Text}')";
                con.Open();

                cmd = new SqlCommand(sql, con);
                adap.InsertCommand = cmd;
                adap.InsertCommand.ExecuteNonQuery();

                con.Close();

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
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemoveSup_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = "DELETE FROM Equipment WHERE EquipmentId = " + Convert.ToInt32(txtEquipmentID.Text);
                con.Open();

                cmd = new SqlCommand(sql, con);
                adap.DeleteCommand = cmd;
                adap.DeleteCommand.ExecuteNonQuery();

                con.Close();

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
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditSup_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = $"UPDATE Equipment SET EquipmentId = @ID, eqPrice = @Price, eqDescription = @Desc, eqName = @Name, eqStatus = @Status WHERE EquipmentId = " + Convert.ToInt32(txtEquipmentID.Text);
                con.Open();

                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtEquipmentID.Text));
                cmd.Parameters.AddWithValue("@Price", Convert.ToDouble(txtEquipmentPrice.Text));
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

        private void dgvEquipment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            object value = dgvEquipment.Rows[e.RowIndex].Cells[0].Value;
            if (value != null)
            {
                txtEquipmentID.Text = value.ToString();
            }
            value = dgvEquipment.Rows[e.RowIndex].Cells[1].Value;
            if (value != null)
            {
                txtEquipmentPrice.Text = value.ToString();
            }
            value = dgvEquipment.Rows[e.RowIndex].Cells[2].Value;
            if (value != null)
            {
                txtEquipmentDesc.Text = value.ToString();
            }
            value = dgvEquipment.Rows[e.RowIndex].Cells[3].Value;
            if (value != null)
            {
                txtEquipmentName.Text = value.ToString();
            }
            value = dgvEquipment.Rows[e.RowIndex].Cells[4].Value;
            if (value != null)
            {
                txtEquipmentStatus.Text = value.ToString();
            }
        }

        private void Equipment_Load(object sender, EventArgs e)
        {
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
    }
}
