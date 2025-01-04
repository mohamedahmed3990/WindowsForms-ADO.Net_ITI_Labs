namespace WindowsForms_ITI_Labs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Welcome {txtFname.Text} {txtLname.Text}");
        }
    }
}
