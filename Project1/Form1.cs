namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = (string)textBox1.Text;
            MessageBox.Show("My name is " + name);
        }
    }
}
