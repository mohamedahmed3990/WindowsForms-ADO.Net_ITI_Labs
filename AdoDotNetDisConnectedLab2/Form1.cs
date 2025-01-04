using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace AdoDotNetDisConnectedLab2
{
    public partial class Form1 : Form
    {

        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;
        public Form1()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ITI_db"].ConnectionString);
            sqlCommand = new SqlCommand();
            sqlDataAdapter = new SqlDataAdapter();
            dataTable = new DataTable();

            InitializeComponent();

            FillStudentToGridView();
        }

        private void FillStudentToGridView()
        {
            sqlCommand.CommandText = "select * from Student";
            sqlCommand.Connection = sqlConnection;

            sqlDataAdapter.SelectCommand = sqlCommand;


            try
            {
                sqlDataAdapter.Fill(dataTable);

                gridResult.DataSource = dataTable;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtFname.Text) 
                || string.IsNullOrWhiteSpace(txtlname.Text) || string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            DataRow dr = dataTable.NewRow();

            dr["st_id"] = txtId.Text;
            dr["st_fname"] = txtFname.Text;
            dr["st_lname"] = txtlname.Text;
            dr["st_address"] = txtAddress.Text;

            dataTable.Rows.Add(dr);

        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            SqlCommand insertCommand = new SqlCommand();
            insertCommand.CommandText = "insert into student(st_id, st_fname, st_lname, st_address) values (@id, @fname, @lname, @address)";
            insertCommand.Connection = sqlConnection;
            insertCommand.Parameters.Add("@id", SqlDbType.Int, 8, "st_id");
            insertCommand.Parameters.Add("@fname", SqlDbType.VarChar, 10, "st_fname");
            insertCommand.Parameters.Add("@lname", SqlDbType.VarChar, 10, "st_lname");
            insertCommand.Parameters.Add("@address", SqlDbType.VarChar, 50, "st_address");

            sqlDataAdapter.InsertCommand = insertCommand;


            SqlCommand updateCommand = new SqlCommand();
            updateCommand.CommandText = "update student set st_fname = @fname, st_lname = @lname, st_address = @address where st_id = @id  ";
            updateCommand.Connection = sqlConnection;
            updateCommand.Parameters.Add("@id", SqlDbType.Int, 8, "st_id");
            updateCommand.Parameters.Add("@fname", SqlDbType.VarChar, 10, "st_fname");
            updateCommand.Parameters.Add("@lname", SqlDbType.VarChar, 10, "st_lname");
            updateCommand.Parameters.Add("@address", SqlDbType.VarChar, 50, "st_address");

            sqlDataAdapter.UpdateCommand = updateCommand;



            SqlCommand deleteCommand = new SqlCommand();
            deleteCommand.CommandText = "delete student where st_id = @id  ";
            deleteCommand.Connection = sqlConnection;
            deleteCommand.Parameters.Add("@id", SqlDbType.Int, 8, "st_id");
            deleteCommand.Parameters.Add("@fname", SqlDbType.VarChar, 10, "st_fname");
            deleteCommand.Parameters.Add("@lname", SqlDbType.VarChar, 10, "st_lname");
            deleteCommand.Parameters.Add("@address", SqlDbType.VarChar, 50, "st_address");

            sqlDataAdapter.DeleteCommand = deleteCommand;

            try
            {
                sqlDataAdapter.Update(dataTable);
                MessageBox.Show("Sync Successfully", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            FillStudentToGridView();
        }
    }
}
