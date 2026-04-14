using System.Data;
using System.Linq.Expressions;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ResultBox.Text += "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResultBox.Text += "2";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResultBox.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ResultBox.Text += "4";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResultBox.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ResultBox.Text += "6";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ResultBox.Text += "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ResultBox.Text += "8";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ResultBox.Text += "9";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ResultBox.Text += "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ResultBox.Text += ".";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResultBox.Text += "-";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ResultBox.Text += "/";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ResultBox.Text += "*";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ResultBox.Text += "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = ResultBox.Text;
                var result = new DataTable().Compute(expression, null);
                ResultBox.Text = result.ToString();
            }
            catch (Exception ex)
            {
                ResultBox.Text = ex.Message;
            }
        }

        private void ResultBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
