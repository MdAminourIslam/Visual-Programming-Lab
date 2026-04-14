using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab4
{
    public partial class UpdateForm : Form
    {
        private SqlConnection connection;

        public UpdateForm()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            LoadStudentIDs();
        }

        private void InitializeDatabaseConnection()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=DB2026;Integrated Security=True;";
            connection = new SqlConnection(connectionString);
        }

        private void LoadStudentIDs()
        {
            try
            {
                string query = "SELECT id FROM Students1 ORDER BY id";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    if (connection.State != ConnectionState.Open)
                        connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        cmbUpdateID.Items.Clear();
                        while (reader.Read())
                        {
                            cmbUpdateID.Items.Add(reader["id"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading IDs: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void cmbUpdateID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUpdateID.SelectedItem != null)
            {
                try
                {
                    string query = "SELECT name, dept, gender FROM Students1 WHERE id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        if (connection.State != ConnectionState.Open)
                            connection.Open();

                        cmd.Parameters.AddWithValue("@id", cmbUpdateID.SelectedItem.ToString());

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtUpdateName.Text = reader["name"].ToString();
                                txtUpdateDept.Text = reader["dept"].ToString();

                                string gender = reader["gender"].ToString();
                                if (gender.Equals("Male", StringComparison.OrdinalIgnoreCase))
                                {
                                    radioUpdateMale.Checked = true;
                                    radioUpdateFemale.Checked = false;
                                }
                                else if (gender.Equals("Female", StringComparison.OrdinalIgnoreCase))
                                {
                                    radioUpdateMale.Checked = false;
                                    radioUpdateFemale.Checked = true;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
        }

        private bool ValidatePassword(string password)
        {
            if (string.IsNullOrEmpty(password))
                return true; // Password optional in update

            Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$");
            return regex.IsMatch(password);
        }

        private bool ValidateUpdateInput()
        {
            if (cmbUpdateID.SelectedItem == null)
            {
                MessageBox.Show("Please select an ID to update.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUpdateName.Text) || txtUpdateName.Text.Length < 3)
            {
                MessageBox.Show("Name must be at least 3 characters long.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUpdateName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUpdateDept.Text))
            {
                MessageBox.Show("Please enter department.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUpdateDept.Focus();
                return false;
            }

            if (!radioUpdateMale.Checked && !radioUpdateFemale.Checked)
            {
                MessageBox.Show("Please select gender.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!string.IsNullOrEmpty(txtUpdatePassword.Text))
            {
                if (txtUpdatePassword.Text != txtUpdateConfirmPassword.Text)
                {
                    MessageBox.Show("Password and Confirm Password do not match.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUpdatePassword.Focus();
                    return false;
                }

                if (!ValidatePassword(txtUpdatePassword.Text))
                {
                    MessageBox.Show("Password must contain:\n\n" +
                        "• At least 8 characters\n" +
                        "• One uppercase letter (A-Z)\n" +
                        "• One lowercase letter (a-z)\n" +
                        "• One digit (0-9)\n" +
                        "• One special character (!@#$%^&* etc.)\n\n" +
                        "Examples: Test@1234, Hello#2024, MyP@ssw0rd!\n\n" +
                        "Note: If you don't want to change password, leave password fields empty.",
                        "Password Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUpdatePassword.Focus();
                    return false;
                }
            }

            return true;
        }

        private void btnUpdateOK_Click(object sender, EventArgs e)
        {
            if (!ValidateUpdateInput())
                return;

            try
            {
                string gender = radioUpdateMale.Checked ? "Male" : "Female";
                string query;

                if (!string.IsNullOrEmpty(txtUpdatePassword.Text))
                {
                    // সরাসরি পাসওয়ার্ড update করব
                    query = @"UPDATE Students1 
                             SET name = @name, dept = @dept, gender = @gender, 
                                 password = @password 
                             WHERE id = @id";
                }
                else
                {
                    query = @"UPDATE Students1 
                             SET name = @name, dept = @dept, gender = @gender 
                             WHERE id = @id";
                }

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    if (connection.State != ConnectionState.Open)
                        connection.Open();

                    cmd.Parameters.AddWithValue("@id", cmbUpdateID.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@name", txtUpdateName.Text.Trim());
                    cmd.Parameters.AddWithValue("@dept", txtUpdateDept.Text.Trim());
                    cmd.Parameters.AddWithValue("@gender", gender);

                    if (!string.IsNullOrEmpty(txtUpdatePassword.Text))
                    {
                        cmd.Parameters.AddWithValue("@password", txtUpdatePassword.Text);
                    }

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Record with ID '{cmbUpdateID.SelectedItem}' updated successfully!",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No record found with the selected ID.", "Not Found",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating record: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUpdateName.Clear();
            txtUpdateDept.Clear();
            txtUpdatePassword.Clear();
            txtUpdateConfirmPassword.Clear();
            radioUpdateMale.Checked = false;
            radioUpdateFemale.Checked = false;
            cmbUpdateID.SelectedIndex = -1;
            cmbUpdateID.Focus();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {

        }
    }
}