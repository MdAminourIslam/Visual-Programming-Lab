namespace DbInsert
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IdBtn = new System.Windows.Forms.TextBox();
            this.NameBtn = new System.Windows.Forms.TextBox();
            this.DeptBtn = new System.Windows.Forms.TextBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dept";
            // 
            // IdBtn
            // 
            this.IdBtn.Location = new System.Drawing.Point(226, 30);
            this.IdBtn.Name = "IdBtn";
            this.IdBtn.Size = new System.Drawing.Size(100, 26);
            this.IdBtn.TabIndex = 3;
            this.IdBtn.TextChanged += new System.EventHandler(this.IdBtn_TextChanged);
            // 
            // NameBtn
            // 
            this.NameBtn.Location = new System.Drawing.Point(226, 92);
            this.NameBtn.Name = "NameBtn";
            this.NameBtn.Size = new System.Drawing.Size(100, 26);
            this.NameBtn.TabIndex = 4;
            // 
            // DeptBtn
            // 
            this.DeptBtn.Location = new System.Drawing.Point(226, 156);
            this.DeptBtn.Name = "DeptBtn";
            this.DeptBtn.Size = new System.Drawing.Size(100, 26);
            this.DeptBtn.TabIndex = 5;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(226, 239);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(75, 40);
            this.SubmitBtn.TabIndex = 6;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(612, 412);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.DeptBtn);
            this.Controls.Add(this.NameBtn);
            this.Controls.Add(this.IdBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IdBtn;
        private System.Windows.Forms.TextBox NameBtn;
        private System.Windows.Forms.TextBox DeptBtn;
        private System.Windows.Forms.Button SubmitBtn;
    }
}

