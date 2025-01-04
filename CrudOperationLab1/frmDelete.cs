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

namespace CrudOperationLab1
{
    public partial class frmDelete : Form
    {
        public frmDelete()
        {
            InitializeComponent();
            FillStudentToComboBox();
        }

        private void FillStudentToComboBox()
        {
            var connectionString = "server = DESKTOP-8QITL5G\\SQLEXPRESS; database = ITI; trusted_Connection = true; TrustServerCertificate = true";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                var query = "select *, CONCAT(St_Fname,' ', St_Lname) as fullName from Student";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                sqlConnection.Open();

                SqlDataReader reader = sqlCommand.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                comboStudents.DataSource = dt;
                comboStudents.DisplayMember = "fullName";
                comboStudents.ValueMember = "St_Id";
            }
        }

        private void comboStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            var connectionString = "server = DESKTOP-8QITL5G\\SQLEXPRESS; database = ITI; trusted_Connection = true; TrustServerCertificate = true";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                var query = "select * from Student";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                sqlConnection.Open();

                SqlDataReader reader = sqlCommand.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                txtId.Text = dt.Rows[comboStudents.SelectedIndex]["St_Id"].ToString();
                txtId.Enabled = false;

                txtFname.Text = dt.Rows[comboStudents.SelectedIndex]["St_Fname"].ToString();
                txtFname.Enabled = false;

                txtLname.Text = dt.Rows[comboStudents.SelectedIndex]["St_Lname"].ToString();
                txtLname.Enabled = false;

                txtAddress.Text = dt.Rows[comboStudents.SelectedIndex]["St_Address"].ToString();
                txtAddress.Enabled = false;

                txtAge.Text = dt.Rows[comboStudents.SelectedIndex]["St_Age"].ToString();
                txtAge.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var connectionString = "server = DESKTOP-8QITL5G\\SQLEXPRESS; database = ITI; trusted_Connection = true; TrustServerCertificate = true";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                var query = "delete from student where st_id = @id";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@id", txtId.Text);

                sqlConnection.Open();

                lblResult.Text = $"{sqlCommand.ExecuteNonQuery()} rows affected";
            }
        }
    }
}
