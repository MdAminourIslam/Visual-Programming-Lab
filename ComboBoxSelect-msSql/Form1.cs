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

namespace Demo4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-J8D78AR\SQLEXPRESS;Initial Catalog=DB2026;Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("select id from demo", conn);
            SqlDataReader reader = cmd.ExecuteReader();
                

            while (reader.Read())
            {
                comboBox1.Items.Add(reader["id"].ToString());
            }

            reader.Close();
            conn.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = comboBox1.SelectedItem.ToString();

            ResultBtn.Text = id;
        }
    }
}
