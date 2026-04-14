namespace OracleConn
{
    partial class DeleteForm
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
            this.IdBox = new System.Windows.Forms.ComboBox();
            this.IDbtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IdBox
            // 
            this.IdBox.FormattingEnabled = true;
            this.IdBox.Location = new System.Drawing.Point(220, 49);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(175, 28);
            this.IdBox.TabIndex = 0;
            this.IdBox.SelectedIndexChanged += new System.EventHandler(this.IdBox_SelectedIndexChanged);
            // 
            // IDbtn
            // 
            this.IDbtn.AutoSize = true;
            this.IDbtn.Location = new System.Drawing.Point(145, 57);
            this.IDbtn.Name = "IDbtn";
            this.IDbtn.Size = new System.Drawing.Size(26, 20);
            this.IDbtn.TabIndex = 1;
            this.IDbtn.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(220, 97);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(245, 26);
            this.NameBox.TabIndex = 3;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(274, 177);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 60);
            this.DeleteBtn.TabIndex = 4;
            this.DeleteBtn.Text = "Ok";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 698);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDbtn);
            this.Controls.Add(this.IdBox);
            this.Name = "DeleteForm";
            this.Text = "DeleteForm";
            this.Load += new System.EventHandler(this.DeleteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox IdBox;
        private System.Windows.Forms.Label IDbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button DeleteBtn;
    }
}