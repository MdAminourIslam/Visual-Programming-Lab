using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace dbConnection
{
    public partial class PreviewForm : Form
    {
        private CustomerData data;

        // Update this connection string if your server or authentication differs
        private const string ConnectionString = @"Data Source=DESKTOP-J8D78AR\SQLEXPRESS;Initial Catalog=DB2026;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public PreviewForm(CustomerData data)
        {
            InitializeComponent();
            this.data = data;
            ShowData();
        }

        private void ShowData()
        {
            lblNameValue.Text = data?.Name ?? string.Empty;
            lblDivisionValue.Text = data?.Division ?? string.Empty;
            lblDistrictValue.Text = data?.District ?? string.Empty;
            lblGenderValue.Text = data?.Gender ?? string.Empty;
            lblPhoneValue.Text = data?.Phone ?? string.Empty;
            lblHobbyValue.Text = data?.Hobby ?? string.Empty;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    // Assumes you created dbo.customer table manually with appropriate columns
                    var cmd = new SqlCommand("INSERT INTO dbo.customer([name],[division],[district],[gender],[phone]) VALUES(@name,@division,@district,@gender,@phone)", conn);
                    cmd.Parameters.AddWithValue("@name", data.Name ?? string.Empty);
                    cmd.Parameters.AddWithValue("@division", data.Division ?? string.Empty);
                    cmd.Parameters.AddWithValue("@district", data.District ?? string.Empty);
                    cmd.Parameters.AddWithValue("@gender", data.Gender ?? string.Empty);
                    cmd.Parameters.AddWithValue("@phone", data.Phone ?? string.Empty);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Customer inserted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting into database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
