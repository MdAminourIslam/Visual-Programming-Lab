namespace Demo3
{
    partial class UpdateForm
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
            this.NameBtn = new System.Windows.Forms.TextBox();
            this.DeptBtn = new System.Windows.Forms.TextBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IdBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // NameBtn
            // 
            this.NameBtn.Location = new System.Drawing.Point(292, 113);
            this.NameBtn.Name = "NameBtn";
            this.NameBtn.Size = new System.Drawing.Size(195, 26);
            this.NameBtn.TabIndex = 1;
            // 
            // DeptBtn
            // 
            this.DeptBtn.Location = new System.Drawing.Point(292, 177);
            this.DeptBtn.Name = "DeptBtn";
            this.DeptBtn.Size = new System.Drawing.Size(100, 26);
            this.DeptBtn.TabIndex = 2;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(316, 257);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 44);
            this.UpdateBtn.TabIndex = 3;
            this.UpdateBtn.Text = "Ok";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dept";
            // 
            // IdBox
            // 
            this.IdBox.FormattingEnabled = true;
            this.IdBox.Location = new System.Drawing.Point(283, 47);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(182, 28);
            this.IdBox.TabIndex = 7;
            this.IdBox.SelectedIndexChanged += new System.EventHandler(this.IdBox_SelectedIndexChanged);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 594);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.DeptBtn);
            this.Controls.Add(this.NameBtn);
            this.Name = "UpdateForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NameBtn;
        private System.Windows.Forms.TextBox DeptBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox IdBox;
    }
}