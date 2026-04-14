using System;
using System.Windows.Forms;

namespace CRUD
{
    public class DeleteForm : Form
    {
        private string connStr;
        private TextBox txtId;
        private Button btnDelete;

        public DeleteForm(string connectionString)
        {
            connStr = connectionString;
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Text = "Delete Student";
            this.ClientSize = new System.Drawing.Size(300, 150);
            txtId = new TextBox() { Location = new System.Drawing.Point(120, 20) };
            btnDelete = new Button() { Text = "Delete", Location = new System.Drawing.Point(120, 60) };
            btnDelete.Click += BtnDelete_Click;

            this.Controls.Add(new Label() { Text = "ID:", Location = new System.Drawing.Point(20, 20) });
            this.Controls.Add(txtId);
            this.Controls.Add(btnDelete);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var id = txtId.Text.Trim();
            if (string.IsNullOrEmpty(id)) { MessageBox.Show("ID required"); return; }
            try
            {
                DataAccess.DeleteStudent(connStr, id);
                MessageBox.Show("Deleted");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed: " + ex.Message);
            }
        }
    }
}
