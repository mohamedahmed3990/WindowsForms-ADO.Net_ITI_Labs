using System.Data;
using Microsoft.Data.SqlClient;

namespace Ado.NetConnectedMode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillAuthorsToGridView();
        }

        private void FillAuthorsToGridView()
        {
            // Connection String
            string connectionString = "Server=DESKTOP-8QITL5G\\SQLEXPRESS;Database=pubs;Trusted_Connection=True; TrustServerCertificate=True ";
            using SqlConnection sqlConnection = new SqlConnection(connectionString);

            // Command
            string query = "select * from Authors";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);


            try
            {
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                gridAuthors.DataSource = dt;
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
