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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm();
            updateForm.Show();
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            string id = Id.Text;
            string name = NameBtn.Text;
            string dept = Dept.Text;
            
            if (id == "")
            {
                MessageBox.Show("ID cannot be empty");
                return;
            }

            if(name == "")
            {
                MessageBox.Show("Name cannot be empty");
                return;
            }

            if(dept == "")
            {
                MessageBox.Show("Department cannot be empty");
                return;
            }

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-J8D78AR\SQLEXPRESS;Initial Catalog=DB2026;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into demo values('" + id + "', '" + name + "', '" + dept + "')", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Record Inserted Successfully");
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();
            deleteForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-J8D78AR\SQLEXPRESS;Initial Catalog=DB2026;Integrated Security=True");

            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT id FROM demo", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader["id"]);
            }

            reader.Close();
            conn.Close();
        }
    }
}
