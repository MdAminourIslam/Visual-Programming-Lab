using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab3Task1
{
    public partial class Form1 : Form
    {
        // Database connection string - using your provided string
        private string connectionString = @"Data Source=DESKTOP-J8D78AR\SQLEXPRESS;Initial Catalog=DB2026;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        private string tableName = "AnswerTable";

        public Form1()
        {
            InitializeComponent();
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string createTableQuery = $@"
                        IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='{tableName}' AND xtype='U')
                        CREATE TABLE {tableName} (
                            Id INT IDENTITY(1,1) PRIMARY KEY,
                            Number INT NOT NULL,
                            OperationType VARCHAR(50) NOT NULL,
                            Result VARCHAR(MAX) NOT NULL,
                            CalculationDate DATETIME DEFAULT GETDATE()
                        )";
                    using (SqlCommand cmd = new SqlCommand(createTableQuery, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                //MessageBox.Show("Database initialized successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL Error: {sqlEx.Message}\n\nPlease check your SQL Server configuration:\n1. Make sure SQL Server is running\n2. Verify instance name: DESKTOP-J8D78AR\\SQLEXPRESS\n3. Check database name: DB2026\n4. Ensure Windows Authentication is enabled",
                    "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database initialization failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validate input
            if (!ValidateInput())
                return;

            int number = int.Parse(txtInputNumber.Text);
            string result = "";

            if (rdbPrime.Checked)
            {
                result = IsPrime(number) ? "Prime" : "Not Prime";
            }
            else if (rdbOddEven.Checked)
            {
                result = number % 2 == 0 ? "Even" : "Odd";
            }
            else if (rdbFactorial.Checked)
            {
                try
                {
                    result = CalculateFactorial(number).ToString();
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Factorial result is too large! Please enter a smaller number.", "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            txtAnswer.Text = result;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // Validate all fields before insertion
            if (!ValidateAllFields())
                return;

            try
            {
                int number = int.Parse(txtInputNumber.Text);
                string operationType = "";
                string result = txtAnswer.Text;

                if (rdbPrime.Checked)
                    operationType = "Prime Check";
                else if (rdbOddEven.Checked)
                    operationType = "Odd/Even Check";
                else if (rdbFactorial.Checked)
                    operationType = "Factorial";

                // Insert into database
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string insertQuery = $"INSERT INTO {tableName} (Number, OperationType, Result) VALUES (@Number, @OperationType, @Result)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Number", number);
                        cmd.Parameters.AddWithValue("@OperationType", operationType);
                        cmd.Parameters.AddWithValue("@Result", result);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Data inserted successfully!\nNumber: {number}\nOperation: {operationType}\nResult: {result}",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}", "Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Insertion failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Validation methods
        private bool ValidateInput()
        {
            // Check if number is entered
            if (string.IsNullOrWhiteSpace(txtInputNumber.Text))
            {
                MessageBox.Show("Please enter a number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInputNumber.Focus();
                return false;
            }

            // Check if number is valid integer
            if (!int.TryParse(txtInputNumber.Text, out int number))
            {
                MessageBox.Show("Please enter a valid integer", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInputNumber.Focus();
                return false;
            }

            // Check if radio button is selected
            if (!rdbPrime.Checked && !rdbOddEven.Checked && !rdbFactorial.Checked)
            {
                MessageBox.Show("Please select an operation type", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // For factorial, check if number is not too large
            if (rdbFactorial.Checked)
            {
                if (number < 0)
                {
                    MessageBox.Show("For factorial, please enter a non-negative number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else if (number > 20)
                {
                    MessageBox.Show("For factorial, please enter a number less than or equal to 20", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            // For prime check
            if (rdbPrime.Checked && number < 2)
            {
                MessageBox.Show("For prime check, please enter a number greater than 1", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool ValidateAllFields()
        {
            if (!ValidateInput())
                return false;

            if (string.IsNullOrWhiteSpace(txtAnswer.Text))
            {
                MessageBox.Show("Please calculate the answer first by clicking Submit", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Calculation methods
        private bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        private long CalculateFactorial(int number)
        {
            if (number < 0) throw new ArgumentException("Number must be non-negative");
            if (number == 0 || number == 1) return 1;

            long result = 1;
            checked // This will throw OverflowException if result exceeds long.MaxValue
            {
                for (int i = 2; i <= number; i++)
                {
                    result *= i;
                }
            }
            return result;
        }

        private void ClearFields()
        {
            txtInputNumber.Clear();
            txtAnswer.Clear();
            rdbPrime.Checked = false;
            rdbOddEven.Checked = false;
            rdbFactorial.Checked = false;
            txtInputNumber.Focus();
        }

        // Allow only numbers in input textbox
        private void txtInputNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits, backspace, and negative sign (for flexibility)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // Only allow one minus sign at the beginning
            if (e.KeyChar == '-' && (txtInputNumber.Text.Contains("-") || txtInputNumber.SelectionStart > 0))
            {
                e.Handled = true;
            }
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    MessageBox.Show("Database connection successful!", "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection failed: {ex.Message}", "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}