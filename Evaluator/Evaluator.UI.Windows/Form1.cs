using Evaluator.Core;

namespace Evaluator.UI.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ".";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "-";
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "*";
        }

        private void btnDivition_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "/";
        }

        private void btnPhow_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "^";
        }

        private void btnOpenPharentesis_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "(";
        }

        private void btnClosedPharentesis_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ")";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += $"={ExpresionEvaluator.Evaluate(txtDisplay.Text)}";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            // Terminar el Del Y clear
        }
    }
}
