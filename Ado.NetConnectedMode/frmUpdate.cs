using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Ado.NetConnectedMode
{
    public partial class frmUpdate : Form
    {
        public frmUpdate()
        {
            InitializeComponent();
            FillAuthorsToComboBox();
        }

        private void FillAuthorsToComboBox()
        {
            var connectionString = "server=DESKTOP-8QITL5G\\SQLEXPRESS;database=pubs;trusted_connection=true; TrustServerCertificate = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand sqlCommand = new SqlCommand("SELECT *, CONCAT(au_fname,' ', au_lname) as fullName FROM authors", sqlConnection);

            try
            {
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                comboAuthors.DataSource = dt;
                comboAuthors.DisplayMember = "fullName";
                comboAuthors.ValueMember = "au_id";
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void comboAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            var connectionString = "server=DESKTOP-8QITL5G\\SQLEXPRESS;database=pubs;trusted_connection=true; TrustServerCertificate = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            var id = comboAuthors.SelectedValue;
            SqlCommand sqlCommand = new SqlCommand($"select * from authors where au_id = '{id}'", sqlConnection);

            try
            {
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                txtId.Text = dt.Rows[0]["au_id"].ToString();
                txtFname.Text = dt.Rows[0]["au_fname"].ToString();
                txtLname.Text = dt.Rows[0]["au_lname"].ToString();
                txtAddress.Text = dt.Rows[0]["address"].ToString();
                txtId.Enabled = false;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var connectionString = "server=DESKTOP-8QITL5G\\SQLEXPRESS;database=pubs;trusted_connection=true; TrustServerCertificate = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand sqlCommand = new SqlCommand("update authors set au_fname = @fname, au_lname = @lname, address = @address where au_id = @id", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@id", txtId.Text);
            sqlCommand.Parameters.AddWithValue("@fname", txtFname.Text);
            sqlCommand.Parameters.AddWithValue("@lname", txtLname.Text);
            sqlCommand.Parameters.AddWithValue("@address", txtAddress.Text);

            try
            {
                sqlConnection.Open();
               

                lblResult.Text = $"{sqlCommand.ExecuteNonQuery()} rows affected";
            }
            catch (Exception)
            {

                throw;
            }
        
        
        }
    }
}
