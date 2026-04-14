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

namespace Demo5
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-J8D78AR\SQLEXPRESS;Initial Catalog=DB2026;Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from demo", conn);
            
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                IdBox.Items.Add(rdr["id"]);
            }
           
            conn.Close();
            rdr.Close();
        }

        private void IdBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = IdBox.SelectedItem.ToString();
            

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-J8D78AR\SQLEXPRESS;Initial Catalog=DB2026;Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from demo where id = '"+ id +"'", conn);

            SqlDataReader rdr = cmd.ExecuteReader();

            string name = "";
            string dept = "";

            while (rdr.Read())
            {
                name = rdr["name"].ToString();
                dept = rdr["dept"].ToString();
            }

            NameBox.Text = name;
            DeptBox.Text = dept;

            rdr.Close();
            conn.Close();
            

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string id = IdBox.SelectedItem.ToString();
            string name = NameBox.Text;
            string dept = DeptBox.Text;

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-J8D78AR\SQLEXPRESS;Initial Catalog=DB2026;Integrated Security=True");

            conn.Open();

            SqlCommand cmd = new SqlCommand("update demo set name = '" + name + "', dept = '" + dept + "' where id = '" + id + "'", conn);

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Record Udpated Successfully");
        }
    }
}
