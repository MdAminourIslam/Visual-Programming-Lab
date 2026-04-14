namespace DB_Connection
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBoxID = new Label();
            textBoxName = new Label();
            label3 = new Label();
            label4 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            comboBox1 = new ComboBox();
            label5 = new Label();
            textBoxMobile = new Label();
            comboBoxCountry = new Label();
            radioButtonMale = new RadioButton();
            radioButton2 = new RadioButton();
            folderBrowserDialog2 = new FolderBrowserDialog();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(299, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(299, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(299, 224);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 0;
            // 
            // textBoxID
            // 
            textBoxID.AutoSize = true;
            textBoxID.Location = new Point(209, 63);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(30, 25);
            textBoxID.TabIndex = 1;
            textBoxID.Text = "ID";
            // 
            // textBoxName
            // 
            textBoxName.AutoSize = true;
            textBoxName.Location = new Point(209, 112);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(59, 25);
            textBoxName.TabIndex = 1;
            textBoxName.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(209, 171);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 1;
            label3.Text = "Country";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(217, 227);
            label4.Name = "label4";
            label4.Size = new Size(67, 25);
            label4.TabIndex = 1;
            label4.Text = "Mobile";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bangladesh", "Pakistan", "India", "Nepal" });
            comboBox1.Location = new Point(299, 171);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(209, 282);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 1;
            label5.Text = "Gender";
            // 
            // textBoxMobile
            // 
            textBoxMobile.AutoSize = true;
            textBoxMobile.Location = new Point(209, 227);
            textBoxMobile.Name = "textBoxMobile";
            textBoxMobile.Size = new Size(67, 25);
            textBoxMobile.TabIndex = 1;
            textBoxMobile.Text = "Mobile";
            // 
            // comboBoxCountry
            // 
            comboBoxCountry.AutoSize = true;
            comboBoxCountry.Location = new Point(209, 171);
            comboBoxCountry.Name = "comboBoxCountry";
            comboBoxCountry.Size = new Size(75, 25);
            comboBoxCountry.TabIndex = 1;
            comboBoxCountry.Text = "Country";
            comboBoxCountry.Click += label3_Click;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Location = new Point(299, 282);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(75, 29);
            radioButtonMale.TabIndex = 3;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(388, 282);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(93, 29);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(313, 456);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(313, 338);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 75);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(195, 363);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 6;
            button2.Text = "Upload";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 532);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(radioButton2);
            Controls.Add(radioButtonMale);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(textBoxMobile);
            Controls.Add(label4);
            Controls.Add(comboBoxCountry);
            Controls.Add(label3);
            Controls.Add(textBoxName);
            Controls.Add(textBoxID);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private Label textBoxID;
        private Label textBoxName;
        private Label label3;
        private Label label4;
        private FolderBrowserDialog folderBrowserDialog1;
        private ComboBox comboBox1;
        private Label label5;
        private Label textBoxMobile;
        private Label comboBoxCountry;
        private RadioButton radioButtonMale;
        private RadioButton radioButton2;
        private FolderBrowserDialog folderBrowserDialog2;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
    }
}
