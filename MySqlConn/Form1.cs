using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace MySqlConn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TestBtn_Click(object sender, EventArgs e)
        {
            string conStr = "server=localhost;user=root;password=;database=db2026";
            MySqlConnection conn = new MySqlConnection(conStr);
            conn.Open();
            MessageBox.Show("MySQL Connected from XAMPP");
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
