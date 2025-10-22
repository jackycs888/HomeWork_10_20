namespace Thermometer
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(498, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(265, 30);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(246, 101);
            button1.Name = "button1";
            button1.Size = new Size(53, 56);
            button1.TabIndex = 2;
            button1.Text = "7";
            button1.UseVisualStyleBackColor = true;
            button1.Click += NumberButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(303, 101);
            button2.Name = "button2";
            button2.Size = new Size(53, 56);
            button2.TabIndex = 3;
            button2.Text = "8";
            button2.UseVisualStyleBackColor = true;
            button2.Click += NumberButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(365, 101);
            button3.Name = "button3";
            button3.Size = new Size(53, 56);
            button3.TabIndex = 4;
            button3.Text = "9";
            button3.UseVisualStyleBackColor = true;
            button3.Click += NumberButton_Click;
            // 
            // button4
            // 
            button4.Location = new Point(246, 167);
            button4.Name = "button4";
            button4.Size = new Size(53, 56);
            button4.TabIndex = 7;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += NumberButton_Click;
            // 
            // button5
            // 
            button5.Location = new Point(303, 167);
            button5.Name = "button5";
            button5.Size = new Size(53, 56);
            button5.TabIndex = 6;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += NumberButton_Click;
            // 
            // button6
            // 
            button6.Location = new Point(365, 167);
            button6.Name = "button6";
            button6.Size = new Size(53, 56);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += NumberButton_Click;
            // 
            // button7
            // 
            button7.Location = new Point(246, 233);
            button7.Name = "button7";
            button7.Size = new Size(53, 56);
            button7.TabIndex = 10;
            button7.Text = "1";
            button7.UseVisualStyleBackColor = true;
            button7.Click += NumberButton_Click;
            // 
            // button8
            // 
            button8.Location = new Point(303, 233);
            button8.Name = "button8";
            button8.Size = new Size(53, 56);
            button8.TabIndex = 9;
            button8.Text = "2";
            button8.UseVisualStyleBackColor = true;
            button8.Click += NumberButton_Click;
            // 
            // button9
            // 
            button9.Location = new Point(365, 233);
            button9.Name = "button9";
            button9.Size = new Size(53, 56);
            button9.TabIndex = 8;
            button9.Text = "3";
            button9.UseVisualStyleBackColor = true;
            button9.Click += NumberButton_Click;
            // 
            // button10
            // 
            button10.Location = new Point(246, 295);
            button10.Name = "button10";
            button10.Size = new Size(110, 56);
            button10.TabIndex = 11;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += NumberButton_Click;
            // 
            // button11
            // 
            button11.Location = new Point(365, 295);
            button11.Name = "button11";
            button11.Size = new Size(53, 56);
            button11.TabIndex = 12;
            button11.Text = ".";
            button11.UseVisualStyleBackColor = true;
            button11.Click += NumberButton_Click;
            // 
            // button12
            // 
            button12.Location = new Point(498, 167);
            button12.Name = "button12";
            button12.Size = new Size(95, 72);
            button12.TabIndex = 13;
            button12.Text = "轉換";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Location = new Point(668, 167);
            button13.Name = "button13";
            button13.Size = new Size(95, 72);
            button13.TabIndex = 14;
            button13.Text = "清除";
            button13.UseVisualStyleBackColor = true;
            button13.Click += Button_Clear;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 12F);
            label1.Location = new Point(498, 295);
            label1.Name = "label1";
            label1.Size = new Size(79, 30);
            label1.TabIndex = 16;
            label1.Text = "結果 : ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(12, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(208, 150);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(19, 94);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(143, 27);
            radioButton2.TabIndex = 22;
            radioButton2.TabStop = true;
            radioButton2.Text = "華氏轉成攝氏";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(19, 43);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(143, 27);
            radioButton1.TabIndex = 21;
            radioButton1.TabStop = true;
            radioButton1.Text = "攝氏轉成華氏";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(583, 295);
            label2.Name = "label2";
            label2.Size = new Size(0, 23);
            label2.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ControlDarkDark;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}
