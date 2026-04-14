using System;
using Oracle.ManagedDataAccess.Client;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OracleConn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            string conStr ="Data Source=localhost:1521;User Id=system;Password=1234;";

            OracleConnection conn = new OracleConnection(conStr);

            conn.Open();
            MessageBox.Show("Oracle Connected Successfully");
            conn.Close();

            LoadData();
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            string id = IdBtn.Text;
            string name = NameBtn.Text;
            string dept = DeptBtn.Text;

            if (id == "")
            {
                MessageBox.Show("ID is required");
                return;
            }

            if (name == "")
            {
                MessageBox.Show("Name is required");
                return;
            }

            if (dept == "")
            {
                MessageBox.Show("Dept is required");
                return;
            }

            string conStr = "Data Source=localhost:1521;User Id=system;Password=1234;";
            OracleConnection conn = new OracleConnection(conStr);
            conn.Open();

            OracleCommand cmd = new OracleCommand("insert into demo values('"+ id +"', '"+ name +"', '"+ dept +"')", conn);

            cmd.ExecuteNonQuery();
            conn.Close();

            LoadData();
            MessageBox.Show("Data Inserted Successfully");

        }

        public void LoadData()
        {
            string conStr = "Data Source=localhost:1521;User Id=system;Password=1234;";
            OracleConnection conn = new OracleConnection(conStr);

            OracleCommand cmd = new OracleCommand("select * from demo", conn);

            OracleDataAdapter adapter = new OracleDataAdapter(cmd);

            DataTable dt = new DataTable();

            adapter.Fill(dt);  

            dataGridView1.DataSource = dt;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateForm a = new UpdateForm();
            a.ShowDialog();
            LoadData();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteForm a = new DeleteForm();
            a.ShowDialog();
            LoadData();
        }
    }
}
