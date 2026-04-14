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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Demo3
{
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = IdBox.SelectedItem.ToString();



            if (id == "")
            {
                MessageBox.Show("ID cannot be empty");
                return;
            }

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-J8D78AR\SQLEXPRESS;Initial Catalog=DB2026;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("delete from demo where id = '" + id + "'", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            
            MessageBox.Show("Record Deleted Successfully");
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-J8D78AR\SQLEXPRESS;Initial Catalog=DB2026;Integrated Security=True");

            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT id FROM demo", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                IdBox.Items.Add(reader["id"].ToString());
            }

            reader.Close();
            conn.Close();
        }
    }
}
