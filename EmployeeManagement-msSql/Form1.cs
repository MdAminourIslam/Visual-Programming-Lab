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

namespace Demo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IdBtn.Text == "")
            {
                MessageBox.Show("ID is Required");
                return;

            }

            if (NameBtn.Text == "")
            {
                MessageBox.Show("Name is Required");
                return;
            }
            
            if (DeptBtn.Text == "")
            {
                MessageBox.Show("Department is Required");
                return;
            }

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J8D78AR\SQLEXPRESS;Initial Catalog=DB2026;Integrated Security=True");

            SqlCommand cmd = new SqlCommand(
            "INSERT INTO demo VALUES ('" + IdBtn.Text + "','" + NameBtn.Text + "','" + DeptBtn.Text + "')", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Inserted Successfully!");
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J8D78AR\SQLEXPRESS;Initial Catalog=DB2026;Integrated Security=True");

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM demo", con);
            DataTable dt = new DataTable();

            da.Fill(dt);
            gridView1.DataSource = dt;
        }

        private void gridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (IdBtn.Text == "")
            {
                MessageBox.Show("Please enter ID to update data");
                return;

            }

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J8D78AR\SQLEXPRESS;Initial Catalog=DB2026;Integrated Security=True");

            string query = "UPDATE demo SET Name='" + NameBtn.Text +
                           "', Dept='" + DeptBtn.Text +
                           "' WHERE Id='" + IdBtn.Text + "'";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Updated Successfully!");
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (IdBtn.Text == "")
            {
                MessageBox.Show("Please enter ID to delete data");
                return;
            }

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J8D78AR\SQLEXPRESS;Initial Catalog=DB2026;Integrated Security=True");
            string query = "DELETE FROM demo WHERE Id='" + IdBtn.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Deleted Successfully!");

        }
    }
}
