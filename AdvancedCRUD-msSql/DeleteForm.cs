using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab4
{
    public partial class DeleteForm : Form
    {
        private SqlConnection connection;

        public DeleteForm()
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
                        cmbDeleteID.Items.Clear();
                        while (reader.Read())
                        {
                            cmbDeleteID.Items.Add(reader["id"].ToString());
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

        private void cmbDeleteID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDeleteID.SelectedItem != null)
            {
                try
                {
                    string query = "SELECT name FROM Students1 WHERE id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        if (connection.State != ConnectionState.Open)
                            connection.Open();

                        cmd.Parameters.AddWithValue("@id", cmbDeleteID.SelectedItem.ToString());
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            txtDeleteName.Text = result.ToString();
                        }
                        else
                        {
                            txtDeleteName.Text = "";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading name: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbDeleteID.SelectedItem == null)
            {
                MessageBox.Show("Please select an ID to delete.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to delete record with ID: {cmbDeleteID.SelectedItem}?\n" +
                $"Name: {txtDeleteName.Text}",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM Students1 WHERE id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        if (connection.State != ConnectionState.Open)
                            connection.Open();

                        cmd.Parameters.AddWithValue("@id", cmbDeleteID.SelectedItem.ToString());
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Record with ID '{cmbDeleteID.SelectedItem}' deleted successfully!",
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
                    MessageBox.Show("Error deleting record: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
        }
    }
}