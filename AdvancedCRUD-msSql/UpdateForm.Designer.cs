namespace Lab4
{
    partial class UpdateForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbUpdateID;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.TextBox txtUpdateDept;
        private System.Windows.Forms.TextBox txtUpdatePassword;
        private System.Windows.Forms.TextBox txtUpdateConfirmPassword;
        private System.Windows.Forms.RadioButton radioUpdateMale;
        private System.Windows.Forms.RadioButton radioUpdateFemale;
        private System.Windows.Forms.Button btnUpdateOK;
        private System.Windows.Forms.Button btnClear;

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbUpdateID = new System.Windows.Forms.ComboBox();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.txtUpdateDept = new System.Windows.Forms.TextBox();
            this.txtUpdatePassword = new System.Windows.Forms.TextBox();
            this.txtUpdateConfirmPassword = new System.Windows.Forms.TextBox();
            this.radioUpdateMale = new System.Windows.Forms.RadioButton();
            this.radioUpdateFemale = new System.Windows.Forms.RadioButton();
            this.btnUpdateOK = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Confirm Password:";
            // 
            // cmbUpdateID
            // 
            this.cmbUpdateID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUpdateID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUpdateID.FormattingEnabled = true;
            this.cmbUpdateID.Location = new System.Drawing.Point(140, 22);
            this.cmbUpdateID.Name = "cmbUpdateID";
            this.cmbUpdateID.Size = new System.Drawing.Size(150, 28);
            this.cmbUpdateID.TabIndex = 1;
            this.cmbUpdateID.SelectedIndexChanged += new System.EventHandler(this.cmbUpdateID_SelectedIndexChanged);
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateName.Location = new System.Drawing.Point(140, 52);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(200, 26);
            this.txtUpdateName.TabIndex = 2;
            // 
            // txtUpdateDept
            // 
            this.txtUpdateDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateDept.Location = new System.Drawing.Point(140, 82);
            this.txtUpdateDept.Name = "txtUpdateDept";
            this.txtUpdateDept.Size = new System.Drawing.Size(150, 26);
            this.txtUpdateDept.TabIndex = 3;
            // 
            // txtUpdatePassword
            // 
            this.txtUpdatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdatePassword.Location = new System.Drawing.Point(140, 173);
            this.txtUpdatePassword.Name = "txtUpdatePassword";
            this.txtUpdatePassword.PasswordChar = '*';
            this.txtUpdatePassword.Size = new System.Drawing.Size(150, 26);
            this.txtUpdatePassword.TabIndex = 5;
            // 
            // txtUpdateConfirmPassword
            // 
            this.txtUpdateConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateConfirmPassword.Location = new System.Drawing.Point(190, 215);
            this.txtUpdateConfirmPassword.Name = "txtUpdateConfirmPassword";
            this.txtUpdateConfirmPassword.PasswordChar = '*';
            this.txtUpdateConfirmPassword.Size = new System.Drawing.Size(150, 26);
            this.txtUpdateConfirmPassword.TabIndex = 6;
            // 
            // radioUpdateMale
            // 
            this.radioUpdateMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioUpdateMale.Location = new System.Drawing.Point(140, 133);
            this.radioUpdateMale.Name = "radioUpdateMale";
            this.radioUpdateMale.Size = new System.Drawing.Size(82, 34);
            this.radioUpdateMale.TabIndex = 4;
            this.radioUpdateMale.TabStop = true;
            this.radioUpdateMale.Text = "Male";
            this.radioUpdateMale.UseVisualStyleBackColor = true;
            // 
            // radioUpdateFemale
            // 
            this.radioUpdateFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioUpdateFemale.Location = new System.Drawing.Point(252, 133);
            this.radioUpdateFemale.Name = "radioUpdateFemale";
            this.radioUpdateFemale.Size = new System.Drawing.Size(88, 34);
            this.radioUpdateFemale.TabIndex = 5;
            this.radioUpdateFemale.TabStop = true;
            this.radioUpdateFemale.Text = "Female";
            this.radioUpdateFemale.UseVisualStyleBackColor = true;
            // 
            // btnUpdateOK
            // 
            this.btnUpdateOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdateOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateOK.ForeColor = System.Drawing.Color.White;
            this.btnUpdateOK.Location = new System.Drawing.Point(91, 262);
            this.btnUpdateOK.Name = "btnUpdateOK";
            this.btnUpdateOK.Size = new System.Drawing.Size(75, 30);
            this.btnUpdateOK.TabIndex = 7;
            this.btnUpdateOK.Text = "Update";
            this.btnUpdateOK.UseVisualStyleBackColor = false;
            this.btnUpdateOK.Click += new System.EventHandler(this.btnUpdateOK_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(215, 262);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 30);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(641, 441);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdateOK);
            this.Controls.Add(this.radioUpdateFemale);
            this.Controls.Add(this.radioUpdateMale);
            this.Controls.Add(this.txtUpdateConfirmPassword);
            this.Controls.Add(this.txtUpdatePassword);
            this.Controls.Add(this.txtUpdateDept);
            this.Controls.Add(this.txtUpdateName);
            this.Controls.Add(this.cmbUpdateID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Student Record";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}