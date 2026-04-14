namespace dbConnection
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelDivision;
        private System.Windows.Forms.ComboBox cbDivision;
        private System.Windows.Forms.Label labelDistrict;
        private System.Windows.Forms.ComboBox cbDistrict;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.GroupBox groupGender;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label labelHobby;
        private System.Windows.Forms.CheckBox chkReading;
        private System.Windows.Forms.CheckBox chkTraveling;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnPreview;

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
            this.labelName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelDivision = new System.Windows.Forms.Label();
            this.cbDivision = new System.Windows.Forms.ComboBox();
            this.labelDistrict = new System.Windows.Forms.Label();
            this.cbDistrict = new System.Windows.Forms.ComboBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.groupGender = new System.Windows.Forms.GroupBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.labelHobby = new System.Windows.Forms.Label();
            this.chkReading = new System.Windows.Forms.CheckBox();
            this.chkTraveling = new System.Windows.Forms.CheckBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(30, 30);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 1;
            // 
            // labelDivision
            // 
            this.labelDivision.AutoSize = true;
            this.labelDivision.Location = new System.Drawing.Point(30, 70);
            this.labelDivision.Name = "labelDivision";
            this.labelDivision.Size = new System.Drawing.Size(50, 13);
            this.labelDivision.TabIndex = 2;
            this.labelDivision.Text = "Division:";
            // 
            // cbDivision
            // 
            this.cbDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDivision.FormattingEnabled = true;
            this.cbDivision.Location = new System.Drawing.Point(120, 67);
            this.cbDivision.Name = "cbDivision";
            this.cbDivision.Size = new System.Drawing.Size(200, 21);
            this.cbDivision.TabIndex = 3;
            this.cbDivision.SelectedIndexChanged += new System.EventHandler(this.cbDivision_SelectedIndexChanged);
            // 
            // labelDistrict
            // 
            this.labelDistrict.AutoSize = true;
            this.labelDistrict.Location = new System.Drawing.Point(30, 110);
            this.labelDistrict.Name = "labelDistrict";
            this.labelDistrict.Size = new System.Drawing.Size(44, 13);
            this.labelDistrict.TabIndex = 4;
            this.labelDistrict.Text = "District:";
            // 
            // cbDistrict
            // 
            this.cbDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDistrict.FormattingEnabled = true;
            this.cbDistrict.Location = new System.Drawing.Point(120, 107);
            this.cbDistrict.Name = "cbDistrict";
            this.cbDistrict.Size = new System.Drawing.Size(200, 21);
            this.cbDistrict.TabIndex = 5;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(30, 150);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(45, 13);
            this.labelGender.TabIndex = 6;
            this.labelGender.Text = "Gender:";
            // 
            // groupGender
            // 
            this.groupGender.Location = new System.Drawing.Point(120, 140);
            this.groupGender.Name = "groupGender";
            this.groupGender.Size = new System.Drawing.Size(200, 40);
            this.groupGender.TabIndex = 7;
            this.groupGender.TabStop = false;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(10, 15);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(80, 15);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // add radio buttons to group
            this.groupGender.Controls.Add(this.rbMale);
            this.groupGender.Controls.Add(this.rbFemale);
            // 
            // labelHobby
            // 
            this.labelHobby.AutoSize = true;
            this.labelHobby.Location = new System.Drawing.Point(30, 190);
            this.labelHobby.Name = "labelHobby";
            this.labelHobby.Size = new System.Drawing.Size(39, 13);
            this.labelHobby.TabIndex = 8;
            this.labelHobby.Text = "Hobby:";
            // 
            // chkReading
            // 
            this.chkReading.AutoSize = true;
            this.chkReading.Location = new System.Drawing.Point(120, 187);
            this.chkReading.Name = "chkReading";
            this.chkReading.Size = new System.Drawing.Size(67, 17);
            this.chkReading.TabIndex = 9;
            this.chkReading.Text = "Reading";
            this.chkReading.UseVisualStyleBackColor = true;
            // 
            // chkTraveling
            // 
            this.chkTraveling.AutoSize = true;
            this.chkTraveling.Location = new System.Drawing.Point(200, 187);
            this.chkTraveling.Name = "chkTraveling";
            this.chkTraveling.Size = new System.Drawing.Size(68, 17);
            this.chkTraveling.TabIndex = 10;
            this.chkTraveling.Text = "Traveling";
            this.chkTraveling.UseVisualStyleBackColor = true;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(30, 220);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(41, 13);
            this.labelPhone.TabIndex = 11;
            this.labelPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(120, 217);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 20);
            this.txtPhone.TabIndex = 12;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(120, 255);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(100, 30);
            this.btnPreview.TabIndex = 13;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 320);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelDivision);
            this.Controls.Add(this.cbDivision);
            this.Controls.Add(this.labelDistrict);
            this.Controls.Add(this.cbDistrict);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.groupGender);
            this.Controls.Add(this.labelHobby);
            this.Controls.Add(this.chkReading);
            this.Controls.Add(this.chkTraveling);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.btnPreview);
            this.Name = "Form1";
            this.Text = "Customer Entry";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}

