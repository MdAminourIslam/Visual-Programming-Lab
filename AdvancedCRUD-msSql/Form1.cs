using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        private DataTable dataTable;
        private SqlDataAdapter adapter;

        public Form1()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            LoadDataToGridView();
            SetupDataGridView();
        }

        private void InitializeDatabaseConnection()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=DB2026;Integrated Security=True;";
            connection = new SqlConnection(connectionString);
        }

        private void SetupDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Clear();

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "id";
            idColumn.DataPropertyName = "id";
            idColumn.HeaderText = "ID";
            idColumn.Width = 100;
            dataGridView1.Columns.Add(idColumn);

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.Name = "name";
            nameColumn.DataPropertyName = "name";
            nameColumn.HeaderText = "Name";
            nameColumn.Width = 150;
            dataGridView1.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn deptColumn = new DataGridViewTextBoxColumn();
            deptColumn.Name = "dept";
            deptColumn.DataPropertyName = "dept";
            deptColumn.HeaderText = "Department";
            deptColumn.Width = 120;
            dataGridView1.Columns.Add(deptColumn);

            DataGridViewTextBoxColumn genderColumn = new DataGridViewTextBoxColumn();
            genderColumn.Name = "gender";
            genderColumn.DataPropertyName = "gender";
            genderColumn.HeaderText = "Gender";
            genderColumn.Width = 80;
            dataGridView1.Columns.Add(genderColumn);
        }

        private void LoadDataToGridView()
        {
            try
            {
                string query = "SELECT id, name, dept, gender FROM Students1 ORDER BY id";
                adapter = new SqlDataAdapter(query, connection);

                // Auto-generated commands তৈরি করুন
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

                dataTable = new DataTable();
                adapter.Fill(dataTable);

                // DataGridView-কে DataTable এর সাথে বাইন্ড করুন
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidatePassword(string password)
        {
            // Password validation: At least one uppercase, one lowercase, one digit, one special character
            Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$");
            return regex.IsMatch(password);
        }

        private bool ValidateInput()
        {
            // ID validation
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Please enter ID.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtID.Focus();
                return false;
            }

            // Name validation
            if (string.IsNullOrWhiteSpace(txtName.Text) || txtName.Text.Length < 3)
            {
                MessageBox.Show("Name must be at least 3 characters long.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            // Department validation
            if (string.IsNullOrWhiteSpace(txtDept.Text))
            {
                MessageBox.Show("Please enter department.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDept.Focus();
                return false;
            }

            // Gender validation
            if (!radioMale.Checked && !radioFemale.Checked)
            {
                MessageBox.Show("Please select gender.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Password validation
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password and Confirm Password do not match.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }

            if (!ValidatePassword(txtPassword.Text))
            {
                MessageBox.Show("Password must contain:\n\n" +
                    "• At least 8 characters\n" +
                    "• One uppercase letter (A-Z)\n" +
                    "• One lowercase letter (a-z)\n" +
                    "• One digit (0-9)\n" +
                    "• One special character (!@#$%^&* etc.)\n\n" +
                    "Examples: Test@1234, Hello#2024, MyP@ssw0rd!",
                    "Password Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Focus();
                return false;
            }

            return true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!checkBoxSubmit.Checked)
            {
                MessageBox.Show("Please check the 'Want to Submit' checkbox.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput())
                return;

            try
            {
                string gender = radioMale.Checked ? "Male" : "Female";

                // সরাসরি পাসওয়ার্ড insert করব (হ্যাশ না করে)
                string plainPassword = txtPassword.Text;

                string query = @"INSERT INTO Students1 (id, name, dept, gender, password) 
                                VALUES (@id, @name, @dept, @gender, @password)";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    if (connection.State != ConnectionState.Open)
                        connection.Open();

                    cmd.Parameters.AddWithValue("@id", txtID.Text.Trim());
                    cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@dept", txtDept.Text.Trim());
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@password", plainPassword); // সরাসরি পাসওয়ার্ড

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data inserted successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                        LoadDataToGridView();
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Primary key violation
                {
                    MessageBox.Show($"ID '{txtID.Text}' already exists. Please use a different ID.",
                        "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message, "SQL Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();
            deleteForm.ShowDialog();
            LoadDataToGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm();
            updateForm.ShowDialog();
            LoadDataToGridView();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            PreviewForm previewForm = new PreviewForm();
            previewForm.ShowDialog();
        }

        private void ClearForm()
        {
            txtID.Clear();
            txtName.Clear();
            txtDept.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            radioMale.Checked = false;
            radioFemale.Checked = false;
            checkBoxSubmit.Checked = false;
            txtID.Focus();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0] != null)
            {
                try
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // DataBoundItem থেকে ডাটা নিন
                    if (selectedRow.DataBoundItem != null)
                    {
                        DataRowView rowView = (DataRowView)selectedRow.DataBoundItem;

                        txtID.Text = rowView["id"]?.ToString() ?? "";
                        txtName.Text = rowView["name"]?.ToString() ?? "";
                        txtDept.Text = rowView["dept"]?.ToString() ?? "";

                        string gender = rowView["gender"]?.ToString() ?? "";
                        if (gender.Equals("Male", StringComparison.OrdinalIgnoreCase))
                        {
                            radioMale.Checked = true;
                            radioFemale.Checked = false;
                        }
                        else if (gender.Equals("Female", StringComparison.OrdinalIgnoreCase))
                        {
                            radioMale.Checked = false;
                            radioFemale.Checked = true;
                        }

                        txtPassword.Clear();
                        txtConfirmPassword.Clear();
                        checkBoxSubmit.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading selected data: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtID.Focus();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDataToGridView();
            MessageBox.Show("Data refreshed successfully!", "Refresh",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}