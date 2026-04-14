namespace Demo2
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
            this.EvenBtn = new System.Windows.Forms.RadioButton();
            this.OddBtn = new System.Windows.Forms.RadioButton();
            this.PositiveBtn = new System.Windows.Forms.RadioButton();
            this.NumberBtn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckBtn = new System.Windows.Forms.Button();
            this.AnswerBtn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBtn = new System.Windows.Forms.TextBox();
            this.Bold = new System.Windows.Forms.CheckBox();
            this.Italic = new System.Windows.Forms.CheckBox();
            this.Underline = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ShowBtn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OkBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EvenBtn
            // 
            this.EvenBtn.AutoSize = true;
            this.EvenBtn.Location = new System.Drawing.Point(143, 115);
            this.EvenBtn.Name = "EvenBtn";
            this.EvenBtn.Size = new System.Drawing.Size(70, 24);
            this.EvenBtn.TabIndex = 0;
            this.EvenBtn.TabStop = true;
            this.EvenBtn.Text = "Even";
            this.EvenBtn.UseVisualStyleBackColor = true;
            // 
            // OddBtn
            // 
            this.OddBtn.AutoSize = true;
            this.OddBtn.Location = new System.Drawing.Point(234, 115);
            this.OddBtn.Name = "OddBtn";
            this.OddBtn.Size = new System.Drawing.Size(64, 24);
            this.OddBtn.TabIndex = 1;
            this.OddBtn.TabStop = true;
            this.OddBtn.Text = "Odd";
            this.OddBtn.UseVisualStyleBackColor = true;
            // 
            // PositiveBtn
            // 
            this.PositiveBtn.AutoSize = true;
            this.PositiveBtn.Location = new System.Drawing.Point(314, 115);
            this.PositiveBtn.Name = "PositiveBtn";
            this.PositiveBtn.Size = new System.Drawing.Size(88, 24);
            this.PositiveBtn.TabIndex = 2;
            this.PositiveBtn.TabStop = true;
            this.PositiveBtn.Text = "Positive";
            this.PositiveBtn.UseVisualStyleBackColor = true;
            // 
            // NumberBtn
            // 
            this.NumberBtn.Location = new System.Drawing.Point(277, 53);
            this.NumberBtn.Name = "NumberBtn";
            this.NumberBtn.Size = new System.Drawing.Size(100, 26);
            this.NumberBtn.TabIndex = 3;
            this.NumberBtn.TextChanged += new System.EventHandler(this.NumberBtn_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter a Number";
            // 
            // CheckBtn
            // 
            this.CheckBtn.Location = new System.Drawing.Point(184, 179);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(75, 43);
            this.CheckBtn.TabIndex = 5;
            this.CheckBtn.Text = "Check";
            this.CheckBtn.UseVisualStyleBackColor = true;
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // AnswerBtn
            // 
            this.AnswerBtn.Location = new System.Drawing.Point(218, 268);
            this.AnswerBtn.Name = "AnswerBtn";
            this.AnswerBtn.Size = new System.Drawing.Size(95, 26);
            this.AnswerBtn.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Answer";
            // 
            // TextBtn
            // 
            this.TextBtn.Location = new System.Drawing.Point(804, 34);
            this.TextBtn.Name = "TextBtn";
            this.TextBtn.Size = new System.Drawing.Size(100, 26);
            this.TextBtn.TabIndex = 8;
            // 
            // Bold
            // 
            this.Bold.AutoSize = true;
            this.Bold.Location = new System.Drawing.Point(615, 98);
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(67, 24);
            this.Bold.TabIndex = 9;
            this.Bold.Text = "Bold";
            this.Bold.UseVisualStyleBackColor = true;
            // 
            // Italic
            // 
            this.Italic.AutoSize = true;
            this.Italic.Location = new System.Drawing.Point(697, 98);
            this.Italic.Name = "Italic";
            this.Italic.Size = new System.Drawing.Size(68, 24);
            this.Italic.TabIndex = 10;
            this.Italic.Text = "Italic";
            this.Italic.UseVisualStyleBackColor = true;
            // 
            // Underline
            // 
            this.Underline.AutoSize = true;
            this.Underline.Location = new System.Drawing.Point(791, 98);
            this.Underline.Name = "Underline";
            this.Underline.Size = new System.Drawing.Size(103, 24);
            this.Underline.TabIndex = 11;
            this.Underline.Text = "Underline";
            this.Underline.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(657, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Enter Your Text";
            // 
            // ShowBtn
            // 
            this.ShowBtn.Location = new System.Drawing.Point(735, 217);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(95, 26);
            this.ShowBtn.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(620, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Answer";
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(717, 147);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 43);
            this.OkBtn.TabIndex = 15;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 450);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ShowBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Underline);
            this.Controls.Add(this.Italic);
            this.Controls.Add(this.Bold);
            this.Controls.Add(this.TextBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AnswerBtn);
            this.Controls.Add(this.CheckBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberBtn);
            this.Controls.Add(this.PositiveBtn);
            this.Controls.Add(this.OddBtn);
            this.Controls.Add(this.EvenBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton EvenBtn;
        private System.Windows.Forms.RadioButton OddBtn;
        private System.Windows.Forms.RadioButton PositiveBtn;
        private System.Windows.Forms.TextBox NumberBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CheckBtn;
        private System.Windows.Forms.TextBox AnswerBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBtn;
        private System.Windows.Forms.CheckBox Bold;
        private System.Windows.Forms.CheckBox Italic;
        private System.Windows.Forms.CheckBox Underline;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ShowBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button OkBtn;
    }
}

