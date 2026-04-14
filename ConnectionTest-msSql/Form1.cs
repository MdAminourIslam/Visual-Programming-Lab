using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace DB_Connection1
{
    public partial class Form1 : Form
    {
        private DataTable table;
        private string selectedImagePath = null;

        public Form1()
        {
            InitializeComponent();
            InitializeGrid();
        }

        private void InitializeGrid()
        {
            table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Columns.Add("Country");
            table.Columns.Add("Gender");
            table.Columns.Add("Mobile");
            table.Columns.Add("ImagePath");
            dataGridView1.DataSource = table;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string id = textBoxId.Text.Trim();
            string name = textBoxName.Text.Trim();
            string country = comboBoxCountry.SelectedItem == null ? "" : comboBoxCountry.SelectedItem.ToString();
            string gender = radioMale.Checked ? "Male" : (radioFemale.Checked ? "Female" : "");
            string mobile = textBoxMobile.Text.Trim();

            // Add to DataGridView (in-memory)
            table.Rows.Add(id, name, country, gender, mobile, selectedImagePath);

            // Insert to SQL Server DB
            string connectionString = @"Data Source=DESKTOP-J8D78AR\SQLEXPRESS;Initial Catalog=DB2026;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Modify table: expect a varbinary(max) Image column named Photo
                string sql = "INSERT INTO info (Id, Name, Country, Gender, Mobile, Photo) VALUES (@Id, @Name, @Country, @Gender, @Mobile, @Photo)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Country", country);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Mobile", mobile);

                    if (!string.IsNullOrEmpty(selectedImagePath) && File.Exists(selectedImagePath))
                    {
                        byte[] imgData = File.ReadAllBytes(selectedImagePath);
                        cmd.Parameters.Add("@Photo", SqlDbType.VarBinary, imgData.Length).Value = imgData;
                    }
                    else
                    {
                        cmd.Parameters.Add("@Photo", SqlDbType.VarBinary, -1).Value = DBNull.Value;
                    }

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record inserted into database.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Error inserting into database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonBrowseImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog1.FileName;
                try
                {
                    pictureBoxImage.Image = Image.FromFile(selectedImagePath);
                }
                catch
                {
                    pictureBoxImage.Image = null;
                }
            }
        }

        private void TestConnection()
        {
            string cs = @"Data Source=DESKTOP-J8D78AR\SQLEXPRESS;Initial Catalog=DB2026;Integrated Security=True;Connect Timeout=5";
            try
            {
                using (var conn = new SqlConnection(cs))
                {
                    conn.Open();
                    MessageBox.Show("Connection OK");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonTestConnection_Click(object sender, EventArgs e)
        {
            TestConnection();
        }
    }
}
