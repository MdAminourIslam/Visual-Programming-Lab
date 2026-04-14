using System;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DB_Connection
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDialog1 = new OpenFileDialog();

        public Form1()
        {
            InitializeComponent();
        }

        // Handles the Image Upload (Button2)
        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Load image into memory to avoid locking the file on disk
                using (var fs = File.OpenRead(openFileDialog1.FileName))
                {
                    using (var img = Image.FromStream(fs))
                    {
                        // Dispose previous image if any
                        if (pictureBox1.Image != null)
                        {
                            var old = pictureBox1.Image;
                            pictureBox1.Image = null;
                            old.Dispose();
                        }

                        // Create a copy of the image so the stream can be closed
                        pictureBox1.Image = new Bitmap(img);
                    }
                }
            }
        }

        // Handles the form data submission (Button1)
        private void button1_Click(object sender, EventArgs e)
        {
            // Added TrustServerCertificate=True to avoid SSL certificate trust errors during development.
            // For production, install a trusted certificate and remove TrustServerCertificate or set Encrypt appropriately.
            string connectionString = "Server=DESKTOP-J8D78AR\\SQLEXPRESS; Database=DB2026; Integrated Security=True; TrustServerCertificate=True;";

            // Validate input fields
            if (string.IsNullOrEmpty(textBoxID.Text) || string.IsNullOrEmpty(textBoxName.Text) ||
                string.IsNullOrEmpty(textBoxMobile.Text) || comboBoxCountry.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Prepare the SQL query
            string query = "INSERT INTO Users (ID, Name, Country, Mobile, Gender, ImageData) VALUES (@ID, @Name, @Country, @Mobile, @Gender, @ImageData)";

            // Create a connection to the database
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Open connection
                    conn.Open();

                    // Create a SqlCommand object
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Add parameters to the command
                    cmd.Parameters.AddWithValue("@ID", textBoxID.Text);
                    cmd.Parameters.AddWithValue("@Name", textBoxName.Text);
                    cmd.Parameters.AddWithValue("@Country", comboBoxCountry.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Mobile", textBoxMobile.Text);
                    cmd.Parameters.AddWithValue("@Gender", radioButtonMale.Checked ? "Male" : "Female");

                    // Convert image to byte array if it's not null
                    byte[] imageBytes = null;
                    if (pictureBox1.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                            imageBytes = ms.ToArray();
                        }
                    }

                    // Add the image data parameter (nullable if no image uploaded)
                    cmd.Parameters.AddWithValue("@ImageData", imageBytes ?? (object)DBNull.Value);

                    // Execute the command
                    cmd.ExecuteNonQuery();

                    // Show a message indicating success
                    MessageBox.Show("Data inserted successfully!");
                }
                catch (Exception ex)
                {
                    // Handle error
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // Placeholder method for label3 click event
        private void label3_Click(object sender, EventArgs e)
        {

        }

        // Placeholder method for radioButton2 checked change event
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
