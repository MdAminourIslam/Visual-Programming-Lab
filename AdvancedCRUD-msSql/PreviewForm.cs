using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Lab4
{
    public partial class PreviewForm : Form
    {
        private SqlConnection connection;
        private List<string> allStudentIDs;

        public PreviewForm()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            LoadStudentIDs();
            SetupIDRangeFields();
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
                        allStudentIDs = new List<string>();
                        while (reader.Read())
                        {
                            allStudentIDs.Add(reader["id"].ToString());
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

        private void SetupIDRangeFields()
        {
            cmbIDFrom.Items.Clear();
            cmbIDFrom.Items.AddRange(allStudentIDs.ToArray());

            cmbIDTo.Items.Clear();
            cmbIDTo.Items.AddRange(allStudentIDs.ToArray());

            if (allStudentIDs.Count > 0)
            {
                cmbIDFrom.SelectedIndex = 0;
                cmbIDTo.SelectedIndex = allStudentIDs.Count - 1;
            }
        }

        private void btnPreviewOK_Click(object sender, EventArgs e)
        {
            if (cmbIDFrom.SelectedItem == null || cmbIDTo.SelectedItem == null)
            {
                MessageBox.Show("Please select both 'ID From' and 'ID To'.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idFrom = cmbIDFrom.SelectedItem.ToString();
            string idTo = cmbIDTo.SelectedItem.ToString();

            int fromIndex = allStudentIDs.IndexOf(idFrom);
            int toIndex = allStudentIDs.IndexOf(idTo);

            if (fromIndex > toIndex)
            {
                MessageBox.Show("'ID From' should be less than or equal to 'ID To'.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                List<string> selectedIDs = allStudentIDs
                    .Where(id => CompareIDs(id, idFrom) >= 0 && CompareIDs(id, idTo) <= 0)
                    .ToList();

                if (selectedIDs.Count == 0)
                {
                    MessageBox.Show("No students found in the selected ID range.", "No Data",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Save Student Range Report";
                saveFileDialog.FileName = $"Students_{idFrom}_to_{idTo}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string pdfFilePath = saveFileDialog.FileName;
                    GenerateSimplePDF(selectedIDs, idFrom, idTo, pdfFilePath);

                    MessageBox.Show($"PDF generated successfully!\n\n" +
                        $"ID Range: {idFrom} to {idTo}\n" +
                        $"Total Students: {selectedIDs.Count}\n" +
                        $"Saved at: {pdfFilePath}",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating PDF: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int CompareIDs(string id1, string id2)
        {
            if (int.TryParse(id1.Replace("CE", "").Replace("ce", ""), out int num1) &&
                int.TryParse(id2.Replace("CE", "").Replace("ce", ""), out int num2))
            {
                return num1.CompareTo(num2);
            }
            return string.Compare(id1, id2, StringComparison.OrdinalIgnoreCase);
        }

        private DataTable GetStudentsByIDRange(List<string> ids)
        {
            DataTable dataTable = new DataTable();

            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                string idList = string.Join(",", ids.Select(id => $"'{id.Replace("'", "''")}'"));
                string query = $"SELECT id, name, dept, gender FROM Students1 WHERE id IN ({idList}) ORDER BY id";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student data: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return dataTable;
        }

        private void GenerateSimplePDF(List<string> selectedIDs, string idFrom, string idTo, string filePath)
        {
            DataTable studentData = GetStudentsByIDRange(selectedIDs);

            if (studentData.Rows.Count == 0)
            {
                MessageBox.Show("No student data found for the selected ID range.",
                    "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Document document = new Document(PageSize.A4, 50, 50, 50, 50);

            try
            {
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();

                // **সংখ্যা ব্যবহার করে ফন্ট তৈরি করুন - কোনো error হবে না**
                // Font.BOLD = 1, Font.ITALIC = 2, Font.NORMAL = 0
                // Font.BOLDITALIC = 3

                BaseColor blueColor = new BaseColor(0, 0, 255);
                BaseColor greenColor = new BaseColor(0, 128, 0);
                BaseColor darkGrayColor = new BaseColor(64, 64, 64);

                // Title Font (size 20, BOLD, Blue)
                Font titleFont = new Font(Font.HELVETICA, 20, 1, blueColor);

                // Subtitle Font (size 14, BOLD, Green)
                Font subtitleFont = new Font(Font.HELVETICA, 14, 1, greenColor);

                // Normal Font (size 11, NORMAL)
                Font normalFont = new Font(Font.HELVETICA, 11, 0, BaseColor.BLACK);

                // Header Font (size 12, BOLD, White)
                Font headerFont = new Font(Font.HELVETICA, 12, 1, BaseColor.WHITE);

                // Info Font (size 10, ITALIC, DarkGray)
                Font infoFont = new Font(Font.HELVETICA, 10, 2, darkGrayColor);

                // Title
                Paragraph mainTitle = new Paragraph("STUDENT INFORMATION REPORT", titleFont);
                mainTitle.Alignment = Element.ALIGN_CENTER;
                mainTitle.SpacingAfter = 10f;
                document.Add(mainTitle);

                // Range Info
                Paragraph rangeInfo = new Paragraph($"ID Range: {idFrom} to {idTo}", subtitleFont);
                rangeInfo.Alignment = Element.ALIGN_CENTER;
                rangeInfo.SpacingAfter = 5f;
                document.Add(rangeInfo);

                // Summary
                Paragraph summary = new Paragraph(
                    $"Total Students: {studentData.Rows.Count} | " +
                    $"Generated on: {DateTime.Now:dd MMMM yyyy hh:mm:ss tt}",
                    infoFont);
                summary.Alignment = Element.ALIGN_CENTER;
                summary.SpacingAfter = 20f;
                document.Add(summary);

                // Create Table
                PdfPTable table = new PdfPTable(4);
                table.WidthPercentage = 100;
                table.SpacingBefore = 20f;

                // Table Headers - Blue background
                BaseColor headerBgColor = new BaseColor(70, 130, 180); // Steel Blue

                PdfPCell header1 = new PdfPCell(new Phrase("Student ID", headerFont));
                header1.BackgroundColor = headerBgColor;
                header1.Padding = 5;
                header1.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(header1);

                PdfPCell header2 = new PdfPCell(new Phrase("Name", headerFont));
                header2.BackgroundColor = headerBgColor;
                header2.Padding = 5;
                header2.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(header2);

                PdfPCell header3 = new PdfPCell(new Phrase("Department", headerFont));
                header3.BackgroundColor = headerBgColor;
                header3.Padding = 5;
                header3.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(header3);

                PdfPCell header4 = new PdfPCell(new Phrase("Gender", headerFont));
                header4.BackgroundColor = headerBgColor;
                header4.Padding = 5;
                header4.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(header4);

                // Add Data Rows with alternating colors
                BaseColor rowColor1 = new BaseColor(255, 255, 255); // White
                BaseColor rowColor2 = new BaseColor(240, 240, 240); // Light Gray

                int rowCounter = 0;
                foreach (DataRow row in studentData.Rows)
                {
                    BaseColor currentRowColor = (rowCounter % 2 == 0) ? rowColor1 : rowColor2;

                    PdfPCell cell1 = new PdfPCell(new Phrase(row["id"].ToString(), normalFont));
                    cell1.BackgroundColor = currentRowColor;
                    cell1.Padding = 5;
                    table.AddCell(cell1);

                    PdfPCell cell2 = new PdfPCell(new Phrase(row["name"].ToString(), normalFont));
                    cell2.BackgroundColor = currentRowColor;
                    cell2.Padding = 5;
                    table.AddCell(cell2);

                    PdfPCell cell3 = new PdfPCell(new Phrase(row["dept"].ToString(), normalFont));
                    cell3.BackgroundColor = currentRowColor;
                    cell3.Padding = 5;
                    table.AddCell(cell3);

                    PdfPCell cell4 = new PdfPCell(new Phrase(row["gender"].ToString(), normalFont));
                    cell4.BackgroundColor = currentRowColor;
                    cell4.Padding = 5;
                    table.AddCell(cell4);

                    rowCounter++;
                }

                document.Add(table);

                // Footer
                Paragraph footer = new Paragraph("\n\nReport generated by Student Management System", infoFont);
                footer.Alignment = Element.ALIGN_RIGHT;
                document.Add(footer);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating PDF: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                document.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmbIDFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIDFrom.SelectedItem != null)
            {
                string selectedFrom = cmbIDFrom.SelectedItem.ToString();
                int fromIndex = allStudentIDs.IndexOf(selectedFrom);

                cmbIDTo.Items.Clear();
                for (int i = fromIndex; i < allStudentIDs.Count; i++)
                {
                    cmbIDTo.Items.Add(allStudentIDs[i]);
                }

                if (cmbIDTo.Items.Count > 0)
                {
                    cmbIDTo.SelectedIndex = cmbIDTo.Items.Count - 1;
                }
            }
        }
    }
}