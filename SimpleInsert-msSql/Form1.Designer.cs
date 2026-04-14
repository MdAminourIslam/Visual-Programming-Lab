namespace Demo1
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
            this.IdBtn = new System.Windows.Forms.TextBox();
            this.NameBtn = new System.Windows.Forms.TextBox();
            this.DeptBtn = new System.Windows.Forms.TextBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.my = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IdBtn
            // 
            this.IdBtn.Location = new System.Drawing.Point(253, 42);
            this.IdBtn.Name = "IdBtn";
            this.IdBtn.Size = new System.Drawing.Size(100, 26);
            this.IdBtn.TabIndex = 0;
            // 
            // NameBtn
            // 
            this.NameBtn.Location = new System.Drawing.Point(253, 119);
            this.NameBtn.Name = "NameBtn";
            this.NameBtn.Size = new System.Drawing.Size(100, 26);
            this.NameBtn.TabIndex = 1;
            // 
            // DeptBtn
            // 
            this.DeptBtn.Location = new System.Drawing.Point(253, 201);
            this.DeptBtn.Name = "DeptBtn";
            this.DeptBtn.Size = new System.Drawing.Size(100, 26);
            this.DeptBtn.TabIndex = 2;
            this.DeptBtn.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(264, 285);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(75, 43);
            this.SubmitBtn.TabIndex = 3;
            this.SubmitBtn.Text = "Ok";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id";
            // 
            // my
            // 
            this.my.AutoSize = true;
            this.my.Location = new System.Drawing.Point(167, 119);
            this.my.Name = "my";
            this.my.Size = new System.Drawing.Size(51, 20);
            this.my.TabIndex = 5;
            this.my.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dept";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.my);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.DeptBtn);
            this.Controls.Add(this.NameBtn);
            this.Controls.Add(this.IdBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IdBtn;
        private System.Windows.Forms.TextBox NameBtn;
        private System.Windows.Forms.TextBox DeptBtn;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label my;
        private System.Windows.Forms.Label label3;

    }
}

