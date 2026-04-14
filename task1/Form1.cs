using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// NOTE: Install the MySql.Data NuGet package for MySQL/MariaDB support.
// In Visual Studio: Tools > NuGet Package Manager > Package Manager Console
// Run: Install-Package MySql.Data

namespace task1
{
    public partial class Form1 : Form
    {
        // Example connection string — update values for your environment.
        // Use server 127.0.0.1 and port 3306 for typical local XAMPP/WAMP setups.
        private const string ConnectionString = "Server=127.0.0.1;Port=3306;Database=test;Uid=root;Pwd=your_password;SslMode=none;";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            var preview = BuildPreviewText();
            MessageBox.Show(preview, "Preview Customer");
        }

        private string BuildPreviewText()
        {
            var name = tbName.Text.Trim();
            var country = cbCountry.SelectedItem?.ToString() ?? "";
            var gender = rbMale.Checked ? "Male" : (rbFemale.Checked ? "Female" : "");
            var hobbiesList = new List<string>();
            if (cbReading.Checked) hobbiesList.Add("Reading");
            if (cbPainting.Checked) hobbiesList.Add("Painting");
            var hobbies = string.Join(", ", hobbiesList);
            var status = rbMarried.Checked ? "Married" : (rbUnmarried.Checked ? "Unmarried" : "");

            var sb = new StringBuilder();
            sb.AppendLine($"Customer Name: {name}");
            sb.AppendLine($"Country Name: {country}");
            sb.AppendLine($"Sex: {gender}");
            sb.AppendLine($"Hobbies: {hobbies}");
            sb.AppendLine($"Status: {status}");
            return sb.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var name = tbName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter customer name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var country = cbCountry.SelectedItem?.ToString() ?? "";
            var gender = rbMale.Checked ? "Male" : (rbFemale.Checked ? "Female" : "");
            var hobbiesList = new List<string>();
            if (cbReading.Checked) hobbiesList.Add("Reading");
            if (cbPainting.Checked) hobbiesList.Add("Painting");
            var hobbies = string.Join(",", hobbiesList);
            var status = rbMarried.Checked ? "Married" : (rbUnmarried.Checked ? "Unmarried" : "");

            try
            {
                // Prefer compile-time usage: install MySql.Data and then uncomment the following lines
                // using MySql.Data.MySqlClient;
                // using (var conn = new MySqlConnection(ConnectionString)) { ... }

                // Reflection fallback: look for MySqlConnection type in MySql.Data assembly.
                var connType = Type.GetType("MySql.Data.MySqlClient.MySqlConnection, MySql.Data");
                if (connType == null)
                {
                    MessageBox.Show(
                        "MySql.Data provider not found.\n\nSteps:\n1) Install the MySql.Data NuGet package.\n2) Update ConnectionString in Form1.cs to match database name and password.\n3) Create the 'customers' table (see create_customers.sql).\n\nAfter installation you can uncomment direct MySql usage for simpler code.",
                        "Provider Missing",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                using (var conn = (IDbConnection)Activator.CreateInstance(connType, ConnectionString))
                {
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO customers (name, country, gender, hobbies, status) VALUES (@name, @country, @gender, @hobbies, @status)";

                        var p1 = cmd.CreateParameter(); p1.ParameterName = "@name"; p1.Value = name; cmd.Parameters.Add(p1);
                        var p2 = cmd.CreateParameter(); p2.ParameterName = "@country"; p2.Value = country; cmd.Parameters.Add(p2);
                        var p3 = cmd.CreateParameter(); p3.ParameterName = "@gender"; p3.Value = gender; cmd.Parameters.Add(p3);
                        var p4 = cmd.CreateParameter(); p4.ParameterName = "@hobbies"; p4.Value = hobbies; cmd.Parameters.Add(p4);
                        var p5 = cmd.CreateParameter(); p5.ParameterName = "@status"; p5.Value = status; cmd.Parameters.Add(p5);

                        var affected = cmd.ExecuteNonQuery();
                        MessageBox.Show($"Saved. Rows affected: {affected}", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving to database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
