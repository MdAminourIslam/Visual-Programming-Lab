namespace task1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.groupGender = new System.Windows.Forms.GroupBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.groupHobbies = new System.Windows.Forms.GroupBox();
            this.cbReading = new System.Windows.Forms.CheckBox();
            this.cbPainting = new System.Windows.Forms.CheckBox();
            this.groupStatus = new System.Windows.Forms.GroupBox();
            this.rbMarried = new System.Windows.Forms.RadioButton();
            this.rbUnmarried = new System.Windows.Forms.RadioButton();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupGender.SuspendLayout();
            this.groupHobbies.SuspendLayout();
            this.groupStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(124, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Customer Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(150, 17);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(200, 26);
            this.tbName.TabIndex = 1;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(20, 50);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(64, 20);
            this.lblCountry.TabIndex = 2;
            this.lblCountry.Text = "Country";
            // 
            // cbCountry
            // 
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.Items.AddRange(new object[] {
            "Bangladesh",
            "India",
            "USA",
            "UK",
            "Other"});
            this.cbCountry.Location = new System.Drawing.Point(120, 47);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(200, 28);
            this.cbCountry.TabIndex = 3;
            // 
            // groupGender
            // 
            this.groupGender.Controls.Add(this.rbMale);
            this.groupGender.Controls.Add(this.rbFemale);
            this.groupGender.Location = new System.Drawing.Point(20, 80);
            this.groupGender.Name = "groupGender";
            this.groupGender.Size = new System.Drawing.Size(300, 50);
            this.groupGender.TabIndex = 4;
            this.groupGender.TabStop = false;
            this.groupGender.Text = "Gender";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(10, 20);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(68, 24);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(80, 20);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(87, 24);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.Text = "Female";
            // 
            // groupHobbies
            // 
            this.groupHobbies.Controls.Add(this.cbReading);
            this.groupHobbies.Controls.Add(this.cbPainting);
            this.groupHobbies.Location = new System.Drawing.Point(20, 140);
            this.groupHobbies.Name = "groupHobbies";
            this.groupHobbies.Size = new System.Drawing.Size(300, 60);
            this.groupHobbies.TabIndex = 5;
            this.groupHobbies.TabStop = false;
            this.groupHobbies.Text = "Hobbies";
            // 
            // cbReading
            // 
            this.cbReading.AutoSize = true;
            this.cbReading.Location = new System.Drawing.Point(10, 25);
            this.cbReading.Name = "cbReading";
            this.cbReading.Size = new System.Drawing.Size(95, 24);
            this.cbReading.TabIndex = 0;
            this.cbReading.Text = "Reading";
            // 
            // cbPainting
            // 
            this.cbPainting.AutoSize = true;
            this.cbPainting.Location = new System.Drawing.Point(100, 25);
            this.cbPainting.Name = "cbPainting";
            this.cbPainting.Size = new System.Drawing.Size(92, 24);
            this.cbPainting.TabIndex = 1;
            this.cbPainting.Text = "Painting";
            // 
            // groupStatus
            // 
            this.groupStatus.Controls.Add(this.rbMarried);
            this.groupStatus.Controls.Add(this.rbUnmarried);
            this.groupStatus.Location = new System.Drawing.Point(20, 210);
            this.groupStatus.Name = "groupStatus";
            this.groupStatus.Size = new System.Drawing.Size(300, 50);
            this.groupStatus.TabIndex = 6;
            this.groupStatus.TabStop = false;
            this.groupStatus.Text = "Status";
            // 
            // rbMarried
            // 
            this.rbMarried.AutoSize = true;
            this.rbMarried.Location = new System.Drawing.Point(10, 20);
            this.rbMarried.Name = "rbMarried";
            this.rbMarried.Size = new System.Drawing.Size(87, 24);
            this.rbMarried.TabIndex = 0;
            this.rbMarried.Text = "Married";
            // 
            // rbUnmarried
            // 
            this.rbUnmarried.AutoSize = true;
            this.rbUnmarried.Checked = true;
            this.rbUnmarried.Location = new System.Drawing.Point(103, 20);
            this.rbUnmarried.Name = "rbUnmarried";
            this.rbUnmarried.Size = new System.Drawing.Size(108, 24);
            this.rbUnmarried.TabIndex = 1;
            this.rbUnmarried.TabStop = true;
            this.rbUnmarried.Text = "Unmarried";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(20, 295);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 54);
            this.btnPreview.TabIndex = 7;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(120, 306);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 54);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.groupGender);
            this.Controls.Add(this.groupHobbies);
            this.Controls.Add(this.groupStatus);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.Text = "Customer Data Entry Screen";
            this.groupGender.ResumeLayout(false);
            this.groupGender.PerformLayout();
            this.groupHobbies.ResumeLayout(false);
            this.groupHobbies.PerformLayout();
            this.groupStatus.ResumeLayout(false);
            this.groupStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // New control fields
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ComboBox cbCountry;

        private System.Windows.Forms.GroupBox groupGender;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;

        private System.Windows.Forms.GroupBox groupHobbies;
        private System.Windows.Forms.CheckBox cbReading;
        private System.Windows.Forms.CheckBox cbPainting;

        private System.Windows.Forms.GroupBox groupStatus;
        private System.Windows.Forms.RadioButton rbMarried;
        private System.Windows.Forms.RadioButton rbUnmarried;

        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnSave;
    }
}

