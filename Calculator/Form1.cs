using NCalc;
using System.Text.RegularExpressions;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string current = txtDisplay.Text;
            if (current.Length > 0)
            {
                current = current.Remove(current.Length - 1);
            }
            else
            {
                current = "0";
            }
            txtDisplay.Text = current;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "+";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "-";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "×";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "÷";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "^";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "mod";
        }

        private void button33_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "sin(";
        }

        private void button35_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "cos(";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "tan(";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "√(";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "ln(";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "exp(";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "abs(";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "e";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "π";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "(";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ")";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ".";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "/100";
        }

        private void button34_Click(object sender, EventArgs e)
        {
            try
            {
                string exp = txtDisplay.Text;

                // Basic replacements (symbols → functions)
                exp = exp.Replace("×", "*")
                         .Replace("÷", "/")
                         .Replace("π", Math.PI.ToString())
                         .Replace("e", Math.E.ToString())
                         .Replace("√", "sqrt")
                         .Replace("ln", "log");

                // Replace "mod" → Mod(a,b)
                exp = Regex.Replace(exp, @"(\d+)\s*mod\s*(\d+)", "Mod($1,$2)");

                // Replace power a^b → Pow(a,b)
                exp = Regex.Replace(exp, @"(\d+)\s*\^\s*(\d+)", "Pow($1,$2)");

                // Replace n! or (expr)! → factorial(expr)
                exp = Regex.Replace(exp, @"(\([^\)]+\)|\d+)!", m => $"factorial({m.Groups[1].Value})");

                Expression expression = new Expression(exp);

                // Custom functions
                expression.EvaluateFunction += (name, args) =>
                {
                    double a, b;

                    switch (name.ToLower())   // Fix: lowercase comparison
                    {
                        case "sin":
                            a = Convert.ToDouble(args.Parameters[0].Evaluate());
                            args.Result = Math.Sin(a * Math.PI / 180.0); // Degree support
                            break;

                        case "cos":
                            a = Convert.ToDouble(args.Parameters[0].Evaluate());
                            args.Result = Math.Cos(a * Math.PI / 180.0);
                            break;

                        case "tan":
                            a = Convert.ToDouble(args.Parameters[0].Evaluate());
                            args.Result = Math.Tan(a * Math.PI / 180.0);
                            break;

                        case "sqrt":
                            a = Convert.ToDouble(args.Parameters[0].Evaluate());
                            args.Result = Math.Sqrt(a);
                            break;

                        case "exp":
                            a = Convert.ToDouble(args.Parameters[0].Evaluate());
                            args.Result = Math.Exp(a);
                            break;

                        case "abs":
                            a = Convert.ToDouble(args.Parameters[0].Evaluate());
                            args.Result = Math.Abs(a);
                            break;

                        case "pow":
                            a = Convert.ToDouble(args.Parameters[0].Evaluate());
                            b = Convert.ToDouble(args.Parameters[1].Evaluate());
                            args.Result = Math.Pow(a, b);
                            break;

                        case "mod":
                            a = Convert.ToDouble(args.Parameters[0].Evaluate());
                            b = Convert.ToDouble(args.Parameters[1].Evaluate());
                            args.Result = a % b;
                            break;

                        case "log":
                            a = Convert.ToDouble(args.Parameters[0].Evaluate());
                            args.Result = Math.Log(a);
                            break;

                        case "factorial":
                            a = Convert.ToDouble(args.Parameters[0].Evaluate());
                            args.Result = Factorial(a);
                            break;
                    }
                };

                var result = expression.Evaluate();
                txtDisplay.Text = result.ToString();
            }
            catch
            {
                txtDisplay.Text = "Error";
            }


        }
        private void button20_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "1/(" + txtDisplay.Text + ")";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "!";
        }
        private double Factorial(double n)
        {
            if (n < 0) throw new Exception("Invalid factorial");
            double result = 1;
            for (int i = 2; i <= n; i++) result *= i;
            return result;
        }

    }
}
