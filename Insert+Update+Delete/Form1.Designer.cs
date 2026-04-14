namespace CRUD
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.ComboBox cmbDivision;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.ComboBox cmbDistrict;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblCgpa;
        private System.Windows.Forms.TextBox txtCgpa;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";

            // Initialize controls
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.lblDivision = new System.Windows.Forms.Label();
            this.cmbDivision = new System.Windows.Forms.ComboBox();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.cmbDistrict = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblCgpa = new System.Windows.Forms.Label();
            this.txtCgpa = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();

            // Labels and positions
            this.lblId.Text = "ID:";
            this.lblId.Location = new System.Drawing.Point(20, 20);
            this.txtId.Location = new System.Drawing.Point(120, 20);

            this.lblName.Text = "Name:";
            this.lblName.Location = new System.Drawing.Point(20, 60);
            this.txtName.Location = new System.Drawing.Point(120, 60);

            this.lblDept.Text = "Dept:";
            this.lblDept.Location = new System.Drawing.Point(20, 100);
            this.txtDept.Location = new System.Drawing.Point(120, 100);

            this.lblDivision.Text = "Division:";
            this.lblDivision.Location = new System.Drawing.Point(20, 140);
            this.cmbDivision.Location = new System.Drawing.Point(120, 140);
            this.cmbDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblDistrict.Text = "District:";
            this.lblDistrict.Location = new System.Drawing.Point(20, 180);
            this.cmbDistrict.Location = new System.Drawing.Point(120, 180);
            this.cmbDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblGender.Text = "Gender:";
            this.lblGender.Location = new System.Drawing.Point(20, 220);
            this.cmbGender.Location = new System.Drawing.Point(120, 220);
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblCgpa.Text = "CGPA:";
            this.lblCgpa.Location = new System.Drawing.Point(20, 260);
            this.txtCgpa.Location = new System.Drawing.Point(120, 260);

            this.btnInsert.Text = "Insert";
            this.btnInsert.Location = new System.Drawing.Point(20, 320);
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);

            this.btnUpdate.Text = "Update";
            this.btnUpdate.Location = new System.Drawing.Point(120, 320);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.Text = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(220, 320);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // Add controls to form
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.lblDivision);
            this.Controls.Add(this.cmbDivision);
            this.Controls.Add(this.lblDistrict);
            this.Controls.Add(this.cmbDistrict);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.lblCgpa);
            this.Controls.Add(this.txtCgpa);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);

            // Populate division and gender
            this.cmbDivision.Items.AddRange(new object[] {"Dhaka", "Chittagong", "Khulna", "Rajshahi"});
            this.cmbGender.Items.AddRange(new object[] {"Male", "Female", "Other"});

            this.cmbDivision.SelectedIndexChanged += new System.EventHandler(this.cmbDivision_SelectedIndexChanged);

        }

        #endregion
    }
}

