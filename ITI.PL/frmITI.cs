using System.Data;
using ITI.BLL;

namespace ITI.PL
{
    public partial class frmITI : Form
    {
        public frmITI()
        {
            InitializeComponent();
            FillStudentsToGrid();
            FillStudentsToCombo();
        }

        private void FillStudentsToCombo()
        {
            comboStud.DataSource = StudentManager.GetAll();

            comboStud.DisplayMember = "st_fname";
            comboStud.ValueMember = "st_id";
        }

        private void FillStudentsToGrid()
        {
            gridResult.DataSource = StudentManager.GetAll();
        }

        private void comboStud_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (int.TryParse(comboStud.SelectedValue.ToString(), out int id))
            {
                var student = StudentManager.GetById(id);

                txtId.Text = student.St_id.ToString();
                txtFname.Text = student.St_Fname;
                txtLname.Text = student.St_Lname;
                txtAdd.Text = student.St_Address;
                txtAge.Text = student.St_Age.ToString();
                txtId.Enabled = false;
            }

        }

        private void btnIns_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtFname.Text) || string.IsNullOrWhiteSpace(txtLname.Text))
            {
                MessageBox.Show("Please Fill All Fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtId.Text, out int st_id) || !int.TryParse(txtAge.Text, out int st_age))
            {
                MessageBox.Show("ID and Age Must be A Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (st_age > 40 || st_age < 22)
            {
                MessageBox.Show("Age Must be in range 22-40", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var checkSt = StudentManager.GetById(int.Parse(txtId.Text));
            if (checkSt is not null)
            {
                MessageBox.Show("ID Must be Unique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Student student = new Student()
            {

                St_id = st_id,
                St_Fname = txtFname.Text,
                St_Lname = txtLname.Text,
                St_Address = txtAdd.Text,
                St_Age = st_age
            };

            int result = StudentManager.Add(student);
            lblRes.Text = $"{result} Rows Inserted";

            FillStudentsToGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFname.Text) || string.IsNullOrWhiteSpace(txtLname.Text))
            {
                MessageBox.Show("Please Fill All Fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtId.Text, out int st_id) || !int.TryParse(txtAge.Text, out int st_age))
            {
                MessageBox.Show("ID and Age Must be A Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (st_age > 40 || st_age < 22)
            {
                MessageBox.Show("Age Must be in range 22-40", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Student student = new Student()
            {
                St_id = st_id,
                St_Fname = txtFname.Text,
                St_Lname = txtLname.Text,
                St_Address = txtAdd.Text,
                St_Age = st_age
            };

            var result = StudentManager.Update(student);
            lblRes.Text = $"{result} Rows Updated";

            FillStudentsToGrid();

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are You Sure To Delete {txtFname.Text} {txtLname.Text}", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int.TryParse(comboStud.SelectedValue.ToString(), out int id);

                var result = StudentManager.Delete(id);

                lblRes.Text = $"{result} Rows Deleted";

                FillStudentsToGrid(); 
            }
        }
    }
}
