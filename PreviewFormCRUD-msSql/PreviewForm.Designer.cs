namespace dbConnection
{
    partial class PreviewForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblNameLabel;
        private System.Windows.Forms.Label lblNameValue;
        private System.Windows.Forms.Label lblDivisionLabel;
        private System.Windows.Forms.Label lblDivisionValue;
        private System.Windows.Forms.Label lblDistrictLabel;
        private System.Windows.Forms.Label lblDistrictValue;
        private System.Windows.Forms.Label lblGenderLabel;
        private System.Windows.Forms.Label lblGenderValue;
        private System.Windows.Forms.Label lblPhoneLabel;
        private System.Windows.Forms.Label lblPhoneValue;
        private System.Windows.Forms.Label lblHobbyLabel;
        private System.Windows.Forms.Label lblHobbyValue;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNameLabel = new System.Windows.Forms.Label();
            this.lblNameValue = new System.Windows.Forms.Label();
            this.lblDivisionLabel = new System.Windows.Forms.Label();
            this.lblDivisionValue = new System.Windows.Forms.Label();
            this.lblDistrictLabel = new System.Windows.Forms.Label();
            this.lblDistrictValue = new System.Windows.Forms.Label();
            this.lblGenderLabel = new System.Windows.Forms.Label();
            this.lblGenderValue = new System.Windows.Forms.Label();
            this.lblPhoneLabel = new System.Windows.Forms.Label();
            this.lblPhoneValue = new System.Windows.Forms.Label();
            this.lblHobbyLabel = new System.Windows.Forms.Label();
            this.lblHobbyValue = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Size = new System.Drawing.Size(360, 168);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblNameLabel
            // 
            this.lblNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNameLabel.AutoSize = true;
            this.lblNameLabel.Location = new System.Drawing.Point(3, 7);
            this.lblNameLabel.Name = "lblNameLabel";
            this.lblNameLabel.Size = new System.Drawing.Size(80, 13);
            this.lblNameLabel.TabIndex = 0;
            this.lblNameLabel.Text = "Customer Name:";
            // 
            // lblNameValue
            // 
            this.lblNameValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNameValue.AutoSize = true;
            this.lblNameValue.Location = new System.Drawing.Point(147, 7);
            this.lblNameValue.Name = "lblNameValue";
            this.lblNameValue.Size = new System.Drawing.Size(35, 13);
            this.lblNameValue.TabIndex = 1;
            this.lblNameValue.Text = "-";
            // 
            // lblDivisionLabel
            // 
            this.lblDivisionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDivisionLabel.AutoSize = true;
            this.lblDivisionLabel.Location = new System.Drawing.Point(3, 35);
            this.lblDivisionLabel.Name = "lblDivisionLabel";
            this.lblDivisionLabel.Size = new System.Drawing.Size(43, 13);
            this.lblDivisionLabel.TabIndex = 2;
            this.lblDivisionLabel.Text = "Division:";
            // 
            // lblDivisionValue
            // 
            this.lblDivisionValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDivisionValue.AutoSize = true;
            this.lblDivisionValue.Location = new System.Drawing.Point(147, 35);
            this.lblDivisionValue.Name = "lblDivisionValue";
            this.lblDivisionValue.Size = new System.Drawing.Size(35, 13);
            this.lblDivisionValue.TabIndex = 3;
            this.lblDivisionValue.Text = "-";
            // 
            // lblDistrictLabel
            // 
            this.lblDistrictLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDistrictLabel.AutoSize = true;
            this.lblDistrictLabel.Location = new System.Drawing.Point(3, 63);
            this.lblDistrictLabel.Name = "lblDistrictLabel";
            this.lblDistrictLabel.Size = new System.Drawing.Size(44, 13);
            this.lblDistrictLabel.TabIndex = 4;
            this.lblDistrictLabel.Text = "District:";
            // 
            // lblDistrictValue
            // 
            this.lblDistrictValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDistrictValue.AutoSize = true;
            this.lblDistrictValue.Location = new System.Drawing.Point(147, 63);
            this.lblDistrictValue.Name = "lblDistrictValue";
            this.lblDistrictValue.Size = new System.Drawing.Size(35, 13);
            this.lblDistrictValue.TabIndex = 5;
            this.lblDistrictValue.Text = "-";
            // 
            // lblGenderLabel
            // 
            this.lblGenderLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGenderLabel.AutoSize = true;
            this.lblGenderLabel.Location = new System.Drawing.Point(3, 91);
            this.lblGenderLabel.Name = "lblGenderLabel";
            this.lblGenderLabel.Size = new System.Drawing.Size(42, 13);
            this.lblGenderLabel.TabIndex = 6;
            this.lblGenderLabel.Text = "Gender:";
            // 
            // lblGenderValue
            // 
            this.lblGenderValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGenderValue.AutoSize = true;
            this.lblGenderValue.Location = new System.Drawing.Point(147, 91);
            this.lblGenderValue.Name = "lblGenderValue";
            this.lblGenderValue.Size = new System.Drawing.Size(35, 13);
            this.lblGenderValue.TabIndex = 7;
            this.lblGenderValue.Text = "-";
            // 
            // lblHobbyLabel
            // 
            this.lblHobbyLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHobbyLabel.AutoSize = true;
            this.lblHobbyLabel.Location = new System.Drawing.Point(3, 119);
            this.lblHobbyLabel.Name = "lblHobbyLabel";
            this.lblHobbyLabel.Size = new System.Drawing.Size(39, 13);
            this.lblHobbyLabel.TabIndex = 8;
            this.lblHobbyLabel.Text = "Hobby:";
            // 
            // lblHobbyValue
            // 
            this.lblHobbyValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHobbyValue.AutoSize = true;
            this.lblHobbyValue.Location = new System.Drawing.Point(147, 119);
            this.lblHobbyValue.Name = "lblHobbyValue";
            this.lblHobbyValue.Size = new System.Drawing.Size(35, 13);
            this.lblHobbyValue.TabIndex = 9;
            this.lblHobbyValue.Text = "-";
            // 
            // lblPhoneLabel
            // 
            this.lblPhoneLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPhoneLabel.AutoSize = true;
            this.lblPhoneLabel.Location = new System.Drawing.Point(3, 147);
            this.lblPhoneLabel.Name = "lblPhoneLabel";
            this.lblPhoneLabel.Size = new System.Drawing.Size(41, 13);
            this.lblPhoneLabel.TabIndex = 8;
            this.lblPhoneLabel.Text = "Phone:";
            // 
            // lblPhoneValue
            // 
            this.lblPhoneValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPhoneValue.AutoSize = true;
            this.lblPhoneValue.Location = new System.Drawing.Point(147, 147);
            this.lblPhoneValue.Name = "lblPhoneValue";
            this.lblPhoneValue.Size = new System.Drawing.Size(35, 13);
            this.lblPhoneValue.TabIndex = 9;
            this.lblPhoneValue.Text = "-";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(216, 190);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 25);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(297, 190);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PreviewForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 231);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreviewForm";
            this.Text = "Preview Customer";
            // add controls to table
            this.tableLayoutPanel1.Controls.Add(this.lblNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNameValue, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDivisionLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDivisionValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDistrictLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDistrictValue, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblGenderLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblGenderValue, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblHobbyLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblHobbyValue, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblPhoneLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblPhoneValue, 1, 5);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
