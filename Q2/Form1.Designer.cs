namespace studentinfo
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            monthCalendar1 = new MonthCalendar();
            label5 = new Label();
            button1 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label6 = new Label();
            checkBox3 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(261, 37);
            label1.Name = "label1";
            label1.Size = new Size(198, 25);
            label1.TabIndex = 0;
            label1.Text = "ONLINE REGISTRATION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 95);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 1;
            label2.Text = "NAME:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(229, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 31);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(229, 162);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(53, 29);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "M";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(330, 162);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(46, 29);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "F";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 162);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 5;
            label3.Text = "GENDER:";
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "science";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Science", "Commerce", "Arts" });
            comboBox1.Location = new Point(213, 222);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 6;
            comboBox1.ValueMember = "science";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 226);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 7;
            label4.Text = "Stream:";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(213, 291);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 8;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(113, 297);
            label5.Name = "label5";
            label5.Size = new Size(53, 25);
            label5.TabIndex = 9;
            label5.Text = "DOB:";
            // 
            // button1
            // 
            button1.Location = new Point(654, 593);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 10;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(213, 579);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(87, 29);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Maths";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(316, 579);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(95, 29);
            checkBox2.TabIndex = 12;
            checkBox2.Text = "Physics";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(118, 577);
            label6.Name = "label6";
            label6.Size = new Size(74, 25);
            label6.TabIndex = 13;
            label6.Text = "Subject:";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(437, 582);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(114, 29);
            checkBox3.TabIndex = 14;
            checkBox3.Text = "chemistry";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 657);
            Controls.Add(checkBox3);
            Controls.Add(label6);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(monthCalendar1);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private MonthCalendar monthCalendar1;
        private Label label5;
        private Button button1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label6;
        private CheckBox checkBox3;
    }
}
