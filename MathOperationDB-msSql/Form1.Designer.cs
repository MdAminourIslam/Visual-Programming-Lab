namespace Lab3Task1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblInputNumber;
        private System.Windows.Forms.TextBox txtInputNumber;
        private System.Windows.Forms.GroupBox groupBoxOperations;
        private System.Windows.Forms.RadioButton rdbPrime;
        private System.Windows.Forms.RadioButton rdbOddEven;
        private System.Windows.Forms.RadioButton rdbFactorial;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnInsert;

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
            this.lblInputNumber = new System.Windows.Forms.Label();
            this.txtInputNumber = new System.Windows.Forms.TextBox();
            this.groupBoxOperations = new System.Windows.Forms.GroupBox();
            this.rdbFactorial = new System.Windows.Forms.RadioButton();
            this.rdbOddEven = new System.Windows.Forms.RadioButton();
            this.rdbPrime = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.groupBoxOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInputNumber
            // 
            this.lblInputNumber.AutoSize = true;
            this.lblInputNumber.Location = new System.Drawing.Point(45, 46);
            this.lblInputNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInputNumber.Name = "lblInputNumber";
            this.lblInputNumber.Size = new System.Drawing.Size(110, 20);
            this.lblInputNumber.TabIndex = 0;
            this.lblInputNumber.Text = "Input Number:";
            // 
            // txtInputNumber
            // 
            this.txtInputNumber.Location = new System.Drawing.Point(180, 42);
            this.txtInputNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInputNumber.Name = "txtInputNumber";
            this.txtInputNumber.Size = new System.Drawing.Size(298, 26);
            this.txtInputNumber.TabIndex = 1;
            this.txtInputNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInputNumber_KeyPress);
            // 
            // groupBoxOperations
            // 
            this.groupBoxOperations.Controls.Add(this.rdbFactorial);
            this.groupBoxOperations.Controls.Add(this.rdbOddEven);
            this.groupBoxOperations.Controls.Add(this.rdbPrime);
            this.groupBoxOperations.Location = new System.Drawing.Point(50, 92);
            this.groupBoxOperations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxOperations.Name = "groupBoxOperations";
            this.groupBoxOperations.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxOperations.Size = new System.Drawing.Size(430, 169);
            this.groupBoxOperations.TabIndex = 2;
            this.groupBoxOperations.TabStop = false;
            this.groupBoxOperations.Text = "Select Operation";
            // 
            // rdbFactorial
            // 
            this.rdbFactorial.AutoSize = true;
            this.rdbFactorial.Location = new System.Drawing.Point(30, 115);
            this.rdbFactorial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbFactorial.Name = "rdbFactorial";
            this.rdbFactorial.Size = new System.Drawing.Size(141, 24);
            this.rdbFactorial.TabIndex = 2;
            this.rdbFactorial.TabStop = true;
            this.rdbFactorial.Text = "Factorial (0-20)";
            this.rdbFactorial.UseVisualStyleBackColor = true;
            // 
            // rdbOddEven
            // 
            this.rdbOddEven.AutoSize = true;
            this.rdbOddEven.Location = new System.Drawing.Point(30, 77);
            this.rdbOddEven.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbOddEven.Name = "rdbOddEven";
            this.rdbOddEven.Size = new System.Drawing.Size(108, 24);
            this.rdbOddEven.TabIndex = 1;
            this.rdbOddEven.TabStop = true;
            this.rdbOddEven.Text = "Odd/Even ";
            this.rdbOddEven.UseVisualStyleBackColor = true;
            // 
            // rdbPrime
            // 
            this.rdbPrime.AutoSize = true;
            this.rdbPrime.Location = new System.Drawing.Point(30, 38);
            this.rdbPrime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbPrime.Name = "rdbPrime";
            this.rdbPrime.Size = new System.Drawing.Size(74, 24);
            this.rdbPrime.TabIndex = 0;
            this.rdbPrime.TabStop = true;
            this.rdbPrime.Text = "Prime";
            this.rdbPrime.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(159, 271);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(180, 54);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(45, 377);
            this.lblAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(66, 20);
            this.lblAnswer.TabIndex = 4;
            this.lblAnswer.Text = "Answer:";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(180, 372);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ReadOnly = true;
            this.txtAnswer.Size = new System.Drawing.Size(298, 26);
            this.txtAnswer.TabIndex = 5;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(50, 440);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(225, 54);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert ";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 508);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBoxOperations);
            this.Controls.Add(this.txtInputNumber);
            this.Controls.Add(this.lblInputNumber);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Number Operations - Lab3 Task1";
            this.groupBoxOperations.ResumeLayout(false);
            this.groupBoxOperations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}