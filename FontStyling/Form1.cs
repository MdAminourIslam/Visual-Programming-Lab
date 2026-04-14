using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string inputText = textBoxInput.Text;

            // Start with regular font style
            FontStyle style = FontStyle.Regular;

            // Check each checkbox and combine styles
            if (checkBoxBold.Checked)
                style |= FontStyle.Bold;

            if (checkBoxItalic.Checked)
                style |= FontStyle.Italic;

            if (checkBoxUnderline.Checked)
                style |= FontStyle.Underline;

            // Apply the combined style to result textbox
            textBoxResult.Font = new Font(textBoxResult.Font, style);
            textBoxResult.Text = inputText;
        }

        private void checkBoxUnderline_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxItalic_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}