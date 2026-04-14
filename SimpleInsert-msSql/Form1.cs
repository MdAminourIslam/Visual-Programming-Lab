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

namespace Demo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string id = IdBtn.Text;
            string name = NameBtn.Text;
            string dept = DeptBtn.Text;

            if (id == "") {
                MessageBox.Show("Please enter an ID.", "Input Error");
                IdBtn.Focus();
                return;
            }
            if (name == "") {
                MessageBox.Show("Please enter a Name.", "Input Error");
                NameBtn.Focus();
                return;
            }

            if (dept == "") {
                MessageBox.Show("Please enter a Department.", "Input Error");
                DeptBtn.Focus();
                return;
            }

            

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-J8D78AR\SQLEXPRESS;Initial Catalog=DB2026;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into demo values('"+ id + "', '"+ name + "', '"+ dept +"')", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();


            MessageBox.Show("ID: " + id + "\nName: " + name + "\nDepartment: " + dept, "Employee Details");
        }

        
    }
}
