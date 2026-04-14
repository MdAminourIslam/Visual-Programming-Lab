using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OracleConn
{
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            string conStr = "Data Source=localhost:1521;User Id=system;Password=1234;";
            OracleConnection conn = new OracleConnection(conStr);


            OracleCommand cmd = new OracleCommand("select * from demo", conn);
            conn.Open();


            OracleDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                IdBox.Items.Add(reader["id"]);
            }

            reader.Close();

            conn.Close();
        }

        private void IdBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = IdBox.SelectedItem.ToString();

            string conStr = "Data Source=localhost:1521;User Id=system;Password=1234;";
            OracleConnection conn = new OracleConnection(conStr);

            conn.Open();

            OracleCommand cmd = new OracleCommand("select * from demo where id = '" + id + "'", conn);



            OracleDataReader reader = cmd.ExecuteReader();

            string name = "";

            while (reader.Read())
            {
                name = reader["name"].ToString();
            }

            NameBox.Text = name;

            reader.Close();
            conn.Close();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string id = IdBox.SelectedItem.ToString();
            

            string conStr = "Data Source=localhost:1521;User Id=system;Password=1234;";
            OracleConnection conn = new OracleConnection(conStr);

            conn.Open();

            OracleCommand cmd = new OracleCommand("Delete from demo where id = '" + id + "'", conn);

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Record Deleted Successfully");
        }
    }
}
