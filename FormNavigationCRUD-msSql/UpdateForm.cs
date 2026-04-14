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

namespace Demo3
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string id = IdBox.SelectedItem.ToString();
            string name = NameBtn.Text;
            string dept = DeptBtn.Text;

            if (id == "")
            {
                MessageBox.Show("ID cannot be empty");
                return;
            }


            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-J8D78AR\SQLEXPRESS;Initial Catalog=DB2026;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("update demo set name = '" + name + "', dept = '" + dept + "' where id = '"+ id + "'", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Record Updated Successfully");
        }

        private void UpdateForm_Load(object sender, EventArgs e)
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

        private void IdBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = IdBox.SelectedItem.ToString();

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-J8D78AR\SQLEXPRESS;Initial Catalog=DB2026;Integrated Security=True");

            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM demo where id = '"+ id +"'", conn);

            SqlDataReader reader = cmd.ExecuteReader();

            string name = "";
            string dept = "";

            while (reader.Read())
            {
                name = reader["name"].ToString();
                dept = reader["dept"].ToString();
            }

            reader.Close();
            conn.Close();

            NameBtn.Text = name;
            DeptBtn.Text = dept;
        }
    }
}
