namespace Simple_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button5 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button16 = new Button();
            ResultBox = new TextBox();
            label1 = new Label();
            button15 = new Button();
            button17 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Location = new Point(43, 168);
            button5.Name = "button5";
            button5.Size = new Size(122, 60);
            button5.TabIndex = 0;
            button5.Text = "1";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.Location = new Point(171, 168);
            button1.Name = "button1";
            button1.Size = new Size(122, 60);
            button1.TabIndex = 0;
            button1.Text = "2";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(299, 168);
            button2.Name = "button2";
            button2.Size = new Size(122, 60);
            button2.TabIndex = 0;
            button2.Text = "3";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(427, 168);
            button3.Name = "button3";
            button3.Size = new Size(122, 60);
            button3.TabIndex = 0;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(171, 234);
            button4.Name = "button4";
            button4.Size = new Size(122, 60);
            button4.TabIndex = 0;
            button4.Text = "5";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.Location = new Point(43, 234);
            button6.Name = "button6";
            button6.Size = new Size(122, 60);
            button6.TabIndex = 0;
            button6.Text = "4";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(299, 234);
            button7.Name = "button7";
            button7.Size = new Size(122, 60);
            button7.TabIndex = 0;
            button7.Text = "6";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(427, 234);
            button8.Name = "button8";
            button8.Size = new Size(122, 60);
            button8.TabIndex = 0;
            button8.Text = "/";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(171, 300);
            button9.Name = "button9";
            button9.RightToLeft = RightToLeft.No;
            button9.Size = new Size(122, 60);
            button9.TabIndex = 0;
            button9.Text = "8";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(43, 300);
            button10.Name = "button10";
            button10.Size = new Size(122, 60);
            button10.TabIndex = 0;
            button10.Text = "7";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(427, 300);
            button11.Name = "button11";
            button11.Size = new Size(122, 60);
            button11.TabIndex = 0;
            button11.Text = "*";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Location = new Point(299, 300);
            button12.Name = "button12";
            button12.Size = new Size(122, 60);
            button12.TabIndex = 0;
            button12.Text = "9";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Location = new Point(171, 366);
            button13.Name = "button13";
            button13.Size = new Size(122, 60);
            button13.TabIndex = 0;
            button13.Text = "0";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Location = new Point(43, 366);
            button14.Name = "button14";
            button14.Size = new Size(122, 126);
            button14.TabIndex = 0;
            button14.Text = "C";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button16
            // 
            button16.Location = new Point(299, 366);
            button16.Name = "button16";
            button16.Size = new Size(122, 60);
            button16.TabIndex = 0;
            button16.Text = ".";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // ResultBox
            // 
            ResultBox.Location = new Point(43, 85);
            ResultBox.Multiline = true;
            ResultBox.Name = "ResultBox";
            ResultBox.ReadOnly = true;
            ResultBox.Size = new Size(506, 81);
            ResultBox.TabIndex = 1;
            ResultBox.Text = "0";
            ResultBox.TextAlign = HorizontalAlignment.Right;
            ResultBox.TextChanged += ResultBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(442, 45);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 2;
            // 
            // button15
            // 
            button15.Location = new Point(156, 432);
            button15.Name = "button15";
            button15.Size = new Size(250, 60);
            button15.TabIndex = 0;
            button15.Text = "=";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button17
            // 
            button17.Location = new Point(427, 366);
            button17.Name = "button17";
            button17.Size = new Size(122, 126);
            button17.TabIndex = 0;
            button17.Text = "+";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(490, 45);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 3;
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 589);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ResultBox);
            Controls.Add(button16);
            Controls.Add(button12);
            Controls.Add(button17);
            Controls.Add(button11);
            Controls.Add(button7);
            Controls.Add(button14);
            Controls.Add(button8);
            Controls.Add(button10);
            Controls.Add(button3);
            Controls.Add(button15);
            Controls.Add(button13);
            Controls.Add(button6);
            Controls.Add(button9);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(button5);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button16;
        private TextBox ResultBox;
        private Label label1;
        private Button button15;
        private Button button17;
        private Label label2;
    }
}
