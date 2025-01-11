using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ITI.DAL
{
    public static class DbManager
    {
        // disConnected mode
        public static DataTable ExecuteQuery(string query)
        {
            var connectionString = "Server=DESKTOP-8QITL5G\\SQLEXPRESS;Database=ITI;Trusted_Connection=True;TrustServerCertificate=True;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(query, sqlConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            return dt;


        }

        // connected mode
        public static int ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            var connectionString = "Server=DESKTOP-8QITL5G\\SQLEXPRESS;Database=ITI;Trusted_Connection=True;TrustServerCertificate=True;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddRange(parameters);

            int affected = -1;
            try
            {
                sqlConnection.Open();
                affected = sqlCommand.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally 
            {
                sqlConnection.Close();
            }

            return affected;

        }

    }
}
