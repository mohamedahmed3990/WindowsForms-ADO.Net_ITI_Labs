using System.Data;
using System.Linq.Expressions;

namespace Calculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string str = string.Empty;
        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            str += btn.Text;  

            if (btn != null)
            {
                txtResult.AppendText(btn.Text);
            }

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

            try
            {
                var result = new DataTable().Compute(str, null);
                txtResult.Text = result.ToString();
                str = string.Empty;
            }
            catch
            {
                txtResult.Text = "Error";
                str = string.Empty;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
        }
    }
}
