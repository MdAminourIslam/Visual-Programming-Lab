using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.Data.SqlClient;

namespace CRUD
{
    public partial class Form1 : Form
    {
        private string connStr;

        public Form1()
        {
            InitializeComponent();
            // Try to read connection string named "StudentDb" from the application's config file.
            // This avoids needing a project reference to System.Configuration.
            try
            {
                var cs = GetConnectionStringFromConfig("StudentDb");
                if (!string.IsNullOrEmpty(cs)) connStr = cs;
                else connStr = @"Data Source=DESKTOP-J8D78AR\\SQLEXPRESS;Initial Catalog=DB2026;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;MultipleActiveResultSets=True";
            }
            catch
            {
                connStr = @"Data Source=DESKTOP-J8D78AR\\SQLEXPRESS;Initial Catalog=DB2026;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;MultipleActiveResultSets=True";
            }

            // Test DB connection and provide actionable message if it fails
            try
            {
                using (var conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                // try fallback without encryption in case server doesn't support client encryption settings
                var alt = connStr.Replace("Encrypt=True;TrustServerCertificate=True;", "Encrypt=False;");
                try
                {
                    using (var conn = new SqlConnection(alt))
                    {
                        conn.Open();
                        conn.Close();
                    }
                    connStr = alt; // use working fallback
                    MessageBox.Show("Initial connection succeeded using non-encrypted fallback.\nUsing fallback connection string. If you prefer encryption, enable server cert or adjust settings.", "Connection fallback", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex2)
                {
                    var msg = new StringBuilder();
                    msg.AppendLine("Unable to connect to SQL Server using the configured connection string.");
                    msg.AppendLine();
                    msg.AppendLine("Error:");
                    msg.AppendLine(ex.Message);
                    if (ex.InnerException != null) msg.AppendLine(ex.InnerException.Message);
                    msg.AppendLine();
                    msg.AppendLine("Check:");
                    msg.AppendLine("- SQL Server service is running");
                    msg.AppendLine("- The instance name is correct: DESKTOP-J8D78AR\\SQLEXPRESS");
                    msg.AppendLine("- TCP/IP is enabled in SQL Server Configuration Manager");
                    msg.AppendLine("- SQL Server Browser service is running for named instances");
                    msg.AppendLine("- Windows Firewall is not blocking SQL Server ports");
                    msg.AppendLine("- Database 'DB2026' exists and your Windows account has access");
                    MessageBox.Show(msg.ToString(), "Database connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // initialize district for default division
            PopulateDistricts("Dhaka");
        }

        private string GetConnectionStringFromConfig(string name)
        {
            try
            {
                var configPath = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile; // path to exe.config
                if (string.IsNullOrEmpty(configPath) || !File.Exists(configPath))
                {
                    // fallback to App.config beside project (useful in designer scenarios)
                    var exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                    configPath = exePath + ".config";
                    if (!File.Exists(configPath)) return null;
                }

                var doc = XDocument.Load(configPath);
                var connElem = doc.Root?.Element("connectionStrings");
                if (connElem == null) return null;
                var add = connElem.Elements("add").FirstOrDefault(e => (string)e.Attribute("name") == name);
                return add?.Attribute("connectionString")?.Value;
            }
            catch
            {
                return null;
            }
        }

        private void cmbDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            var division = cmbDivision.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(division))
                PopulateDistricts(division);
        }

        private void PopulateDistricts(string division)
        {
            cmbDistrict.Items.Clear();
            switch (division)
            {
                case "Dhaka":
                    cmbDistrict.Items.AddRange(new object[] { "Dhaka", "Gazipur", "Narsingdi", "Tangail", "Manikganj" });
                    break;
                case "Chittagong":
                    cmbDistrict.Items.AddRange(new object[] { "Chittagong", "Cox's Bazar", "Rangamati", "Bandarban", "Khagrachari" });
                    break;
                case "Khulna":
                    cmbDistrict.Items.AddRange(new object[] { "Khulna", "Jessore", "Satkhira", "Bagerhat", "Kushtia" });
                    break;
                case "Rajshahi":
                    cmbDistrict.Items.AddRange(new object[] { "Rajshahi", "Bogra", "Natore", "Pabna", "Naogaon" });
                    break;
                default:
                    break;
            }
            if (cmbDistrict.Items.Count > 0)
                cmbDistrict.SelectedIndex = 0;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("ID is required");
                return;
            }

            var id = txtId.Text.Trim();
            var name = txtName.Text.Trim();
            var dept = txtDept.Text.Trim();
            var division = cmbDivision.SelectedItem?.ToString();
            var district = cmbDistrict.SelectedItem?.ToString();
            var gender = cmbGender.SelectedItem?.ToString();
            double cgpa;
            if (!double.TryParse(txtCgpa.Text.Trim(), out cgpa))
            {
                MessageBox.Show("Invalid CGPA");
                return;
            }

            using (var conn = new SqlConnection(connStr))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "INSERT INTO Students (Id, Name, Dept, Division, District, Gender, Cgpa) VALUES (@Id,@Name,@Dept,@Division,@District,@Gender,@Cgpa)";
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Dept", dept);
                cmd.Parameters.AddWithValue("@Division", division ?? string.Empty);
                cmd.Parameters.AddWithValue("@District", district ?? string.Empty);
                cmd.Parameters.AddWithValue("@Gender", gender ?? string.Empty);
                cmd.Parameters.AddWithValue("@Cgpa", cgpa);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Inserted successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insert failed: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Open update form
            var uf = new UpdateForm(connStr);
            uf.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var df = new DeleteForm(connStr);
            df.ShowDialog();
        }
    }
}
