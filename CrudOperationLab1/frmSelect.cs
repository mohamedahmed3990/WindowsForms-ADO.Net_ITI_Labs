using System.Data;
using Microsoft.Data.SqlClient;

namespace CrudOperationLab1
{
    public partial class frmSelect : Form
    {
        public frmSelect()
        {
            InitializeComponent();
            FillStudentsToComboBox();
        }

        private void FillStudentsToComboBox()
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

                var query = "select c.* from Student s, stud_course sc, course c where s.st_id = sc.st_id and c.crs_id = sc.crs_id and s.st_id = @id";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@id", comboStudents.SelectedValue);


                sqlConnection.Open();

                SqlDataReader reader = sqlCommand.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

               gridView.DataSource = dt;
               
            }
        }
    }
}
