using System;
using System.Windows.Forms;
using System.Configuration;

namespace CRUD
{
    public class UpdateForm : Form
    {
        private string connStr;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtDept;
        private ComboBox cmbDivision;
        private ComboBox cmbDistrict;
        private ComboBox cmbGender;
        private TextBox txtCgpa;
        private Button btnLoad;
        private Button btnSave;

        public UpdateForm(string connectionString)
        {
            connStr = connectionString;
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Text = "Update Student";
            this.ClientSize = new System.Drawing.Size(400, 350);
            txtId = new TextBox() { Location = new System.Drawing.Point(120, 20) };
            btnLoad = new Button() { Text = "Load", Location = new System.Drawing.Point(260, 20) };
            btnLoad.Click += BtnLoad_Click;

            txtName = new TextBox() { Location = new System.Drawing.Point(120, 60) };
            txtDept = new TextBox() { Location = new System.Drawing.Point(120, 100) };
            cmbDivision = new ComboBox() { Location = new System.Drawing.Point(120, 140), DropDownStyle=ComboBoxStyle.DropDownList };
            cmbDistrict = new ComboBox() { Location = new System.Drawing.Point(120, 180), DropDownStyle=ComboBoxStyle.DropDownList };
            cmbGender = new ComboBox() { Location = new System.Drawing.Point(120, 220), DropDownStyle=ComboBoxStyle.DropDownList };
            txtCgpa = new TextBox() { Location = new System.Drawing.Point(120, 260) };
            btnSave = new Button() { Text = "Save", Location = new System.Drawing.Point(120, 300) };
            btnSave.Click += BtnSave_Click;

            this.Controls.Add(new Label() { Text = "ID:", Location = new System.Drawing.Point(20, 20) });
            this.Controls.Add(txtId);
            this.Controls.Add(btnLoad);

            this.Controls.Add(new Label() { Text = "Name:", Location = new System.Drawing.Point(20, 60) });
            this.Controls.Add(txtName);
            this.Controls.Add(new Label() { Text = "Dept:", Location = new System.Drawing.Point(20, 100) });
            this.Controls.Add(txtDept);
            this.Controls.Add(new Label() { Text = "Division:", Location = new System.Drawing.Point(20, 140) });
            this.Controls.Add(cmbDivision);
            this.Controls.Add(new Label() { Text = "District:", Location = new System.Drawing.Point(20, 180) });
            this.Controls.Add(cmbDistrict);
            this.Controls.Add(new Label() { Text = "Gender:", Location = new System.Drawing.Point(20, 220) });
            this.Controls.Add(cmbGender);
            this.Controls.Add(new Label() { Text = "Cgpa:", Location = new System.Drawing.Point(20, 260) });
            this.Controls.Add(txtCgpa);
            this.Controls.Add(btnSave);

            cmbDivision.Items.AddRange(new object[] { "Dhaka", "Chittagong", "Khulna", "Rajshahi" });
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cmbDivision.SelectedIndexChanged += CmbDivision_SelectedIndexChanged;
        }

        private void CmbDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            var division = cmbDivision.SelectedItem?.ToString();
            cmbDistrict.Items.Clear();
            if (division == "Dhaka")
                cmbDistrict.Items.AddRange(new object[] { "Dhaka", "Gazipur", "Narsingdi", "Tangail", "Manikganj" });
            else if (division == "Chittagong")
                cmbDistrict.Items.AddRange(new object[] { "Chittagong", "Cox's Bazar", "Rangamati", "Bandarban", "Khagrachari" });
            else if (division == "Khulna")
                cmbDistrict.Items.AddRange(new object[] { "Khulna", "Jessore", "Satkhira", "Bagerhat", "Kushtia" });
            else if (division == "Rajshahi")
                cmbDistrict.Items.AddRange(new object[] { "Rajshahi", "Bogra", "Natore", "Pabna", "Naogaon" });
            if (cmbDistrict.Items.Count > 0) cmbDistrict.SelectedIndex = 0;
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            var id = txtId.Text.Trim();
            if (string.IsNullOrEmpty(id)) { MessageBox.Show("Enter ID"); return; }
            using (var conn = new System.Data.SqlClient.SqlConnection(connStr))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "SELECT Name, Dept, Division, District, Gender, Cgpa FROM Students WHERE Id=@Id";
                cmd.Parameters.AddWithValue("@Id", id);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Read values safely (handle DBNull and different numeric types)
                        txtName.Text = reader.IsDBNull(0) ? string.Empty : reader.GetValue(0).ToString();
                        txtDept.Text = reader.IsDBNull(1) ? string.Empty : reader.GetValue(1).ToString();

                        var division = reader.IsDBNull(2) ? string.Empty : reader.GetValue(2).ToString();
                        if (!string.IsNullOrEmpty(division) && cmbDivision.Items.Contains(division))
                            cmbDivision.SelectedItem = division;
                        else if (cmbDivision.Items.Count > 0)
                            cmbDivision.SelectedIndex = 0;

                        CmbDivision_SelectedIndexChanged(null, null);

                        var district = reader.IsDBNull(3) ? string.Empty : reader.GetValue(3).ToString();
                        if (!string.IsNullOrEmpty(district) && cmbDistrict.Items.Contains(district))
                            cmbDistrict.SelectedItem = district;
                        else if (cmbDistrict.Items.Count > 0)
                            cmbDistrict.SelectedIndex = 0;

                        var gender = reader.IsDBNull(4) ? string.Empty : reader.GetValue(4).ToString();
                        if (!string.IsNullOrEmpty(gender) && cmbGender.Items.Contains(gender))
                            cmbGender.SelectedItem = gender;
                        else if (cmbGender.Items.Count > 0)
                            cmbGender.SelectedIndex = 0;

                        if (reader.IsDBNull(5))
                        {
                            txtCgpa.Text = string.Empty;
                        }
                        else
                        {
                            var cgpaObj = reader.GetValue(5);
                            // handle decimal, double, float, int
                            if (cgpaObj is decimal) txtCgpa.Text = ((decimal)cgpaObj).ToString();
                            else if (cgpaObj is double) txtCgpa.Text = ((double)cgpaObj).ToString();
                            else if (cgpaObj is float) txtCgpa.Text = ((float)cgpaObj).ToString();
                            else txtCgpa.Text = cgpaObj.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("ID not found");
                    }
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var id = txtId.Text.Trim();
            if (string.IsNullOrEmpty(id)) { MessageBox.Show("ID required"); return; }
            double cgpa;
            if (!double.TryParse(txtCgpa.Text.Trim(), out cgpa)) { MessageBox.Show("Invalid CGPA"); return; }
            try
            {
                DataAccess.UpdateStudent(connStr, id, txtName.Text.Trim(), txtDept.Text.Trim(), cmbDivision.SelectedItem?.ToString(), cmbDistrict.SelectedItem?.ToString(), cmbGender.SelectedItem?.ToString(), cgpa);
                MessageBox.Show("Updated");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message);
            }
        }
    }
}
