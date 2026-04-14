using System.Windows.Forms.VisualStyles;

namespace GridAddItem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> values = new List<string>();

            // Loop through all controls on the form
            foreach (Control c in this.Controls)
            {
                // TextBox values
                if (c is TextBox tb)
                {
                    values.Add(tb.Text);
                }

                // RadioButton checked value (Gender)
                else if (c is RadioButton rb && rb.Checked)
                {
                    values.Add(rb.Text); // Adds "M" or "F"
                }

                // CheckBox (Confirm)
                else if (c is CheckBox cb)
                {
                    values.Add(cb.Checked ? "YES" : "NO");
             
                }
            }

            // Add all collected values to DataGridView
            dataGridView1.Rows.Add(values.ToArray());

        }
    }
}
