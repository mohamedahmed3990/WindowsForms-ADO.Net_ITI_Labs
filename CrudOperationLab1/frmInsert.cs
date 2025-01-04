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
    public partial class frmInsert : Form
    {
        public frmInsert()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var connectionString = "server = DESKTOP-8QITL5G\\SQLEXPRESS; database = ITI; trusted_Connection = true; TrustServerCertificate = true";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                var query = "insert into student (st_id, st_fname, st_lname, st_address, st_age) values (@id, @fname, @lname, @address,@age)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@id", txtId.Text);
                sqlCommand.Parameters.AddWithValue("@fname", txtFname.Text);
                sqlCommand.Parameters.AddWithValue("@lname", txtLname.Text);
                sqlCommand.Parameters.AddWithValue("@address", txtAddress.Text);
                sqlCommand.Parameters.AddWithValue("@age", txtAge.Text);



                sqlConnection.Open();

                lblResult.Text = $"{sqlCommand.ExecuteNonQuery()} Rows affected";


            }
        }
    }
}
