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
    public partial class frmInsert : Form
    {
        public frmInsert()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var connectionString = "server=DESKTOP-8QITL5G\\SQLEXPRESS;database=pubs;trusted_connection=true; TrustServerCertificate = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            var query = "insert into authors (au_id,au_fname, au_lname, address) values (@id,@fname,@lname,@address)";

            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@id", txtId.Text);
            command.Parameters.AddWithValue("@fname", txtFname.Text);
            command.Parameters.AddWithValue("@lname", txtLname.Text);
            command.Parameters.AddWithValue("@address", txtAddress.Text);


            try
            {
                sqlConnection.Open();

                lblResult.Text = $"{command.ExecuteNonQuery()} rows affected";
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

        private void frmInsert_Load(object sender, EventArgs e)
        {

        }
    }
}
