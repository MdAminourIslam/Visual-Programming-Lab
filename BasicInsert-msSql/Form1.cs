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

namespace DbInsert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void IdBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string id = IdBtn.Text;
            string name = NameBtn.Text;
            string dept = DeptBtn.Text;

            if (IdBtn.Text == "")
            {
                MessageBox.Show("ID required!");
                IdBtn.Focus();
                return;
            }

            if (NameBtn.Text == "")
            {
                MessageBox.Show("Name required!");
                NameBtn.Focus();
                return;
            }

            if (DeptBtn.Text == "")
            {
                MessageBox.Show("Department required!");
                DeptBtn.Focus();
                return;
            }

            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-J8D78AR\SQLEXPRESS;Initial Catalog=DB2026;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("INSERT INTO demo VALUES ('"+ id + "', '"+ name + "', '"+ dept +"')", connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Record Inserted:\nID: " + id + "\nName: " + name + "\nDepartment: " + dept, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
