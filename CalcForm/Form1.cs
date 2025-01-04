namespace CalcForm
{
    public partial class Form1 : Form
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public string Oper { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumOne_Click(object sender, EventArgs e)
        {
            txtScreenResult.AppendText("1");
        }

        private void btnNumTwo_Click(object sender, EventArgs e)
        {
            txtScreenResult.AppendText("2");
        }
    }
}
