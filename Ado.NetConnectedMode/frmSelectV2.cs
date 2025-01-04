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
    public partial class frmSelectV2 : Form
    {
        public frmSelectV2()
        {
            InitializeComponent();
            FillAuthorsToComboBox();
        }

        private void FillAuthorsToComboBox()
        {
            var connectionString = "server=DESKTOP-8QITL5G\\SQLEXPRESS;database=pubs;trusted_connection=true; TrustServerCertificate = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            var query = "select *, CONCAT(au_fname,' ', au_lname) as fullName from authors";

            SqlCommand command = new SqlCommand(query, sqlConnection);

            try
            {
                sqlConnection.Open();

                SqlDataReader reader = command.ExecuteReader();

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
            var query = $"select t.* from titles t, authors a, titleauthor ta where a.au_id = ta.au_id and t.title_id = ta.title_id and a.au_id ='{id}'";

            SqlCommand command = new SqlCommand(query, sqlConnection);

            try
            {
                sqlConnection.Open();

                SqlDataReader reader = command.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                gridAuthor.DataSource = dt;

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
    }
}
