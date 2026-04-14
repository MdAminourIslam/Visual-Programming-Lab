using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NumberBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            string s = NumberBtn.Text;

            Boolean ok = true;

            foreach (char c in s)
            {
                if (!Char.IsDigit(c))
                {
                    ok = false;
                }
            }

            if (!ok || s == "")
            {
                MessageBox.Show("The input is NOT a number");
            }

            int n = Convert.ToInt32(s);

            if (EvenBtn.Checked)
            {
                if (n % 2 == 0)
                {
                    AnswerBtn.Text = "Yes";
                }
                else
                {
                   AnswerBtn.Text = "No";
                }
            }

            if (OddBtn.Checked)
            {
                if (n % 2 != 0)
                {
                    AnswerBtn.Text = "Yes";
                }
                else
                {
                    AnswerBtn.Text = "No";
                }
            }

            if (PositiveBtn.Checked)
            {
                if (n >= 0)
                {
                    AnswerBtn.Text = "Yes";
                }
                else
                {
                    AnswerBtn.Text = "No";
                }
            }

        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            ShowBtn.Text = TextBtn.Text;

            // Default style
            FontStyle style = FontStyle.Regular;

            // Checkbox অনুযায়ী style add করা
            if (Bold.Checked)
                style |= FontStyle.Bold;
            if (Italic.Checked)
                style |= FontStyle.Italic;
            if (Underline.Checked)
                style |= FontStyle.Underline;

            // ShowBtn এর Font apply করা
            ShowBtn.Font = new Font(ShowBtn.Font.FontFamily, ShowBtn.Font.Size, style);
        }
    }
}
