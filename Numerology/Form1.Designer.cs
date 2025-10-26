namespace Numerology
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
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(51, 105);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 30);
            dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 64);
            label1.Name = "label1";
            label1.Size = new Size(136, 23);
            label1.TabIndex = 1;
            label1.Text = "請選擇你的生日";
            // 
            // button1
            // 
            button1.Location = new Point(51, 217);
            button1.Name = "button1";
            button1.Size = new Size(162, 75);
            button1.TabIndex = 2;
            button1.Text = "分析";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCalculate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(532, 64);
            label2.Name = "label2";
            label2.Size = new Size(96, 23);
            label2.TabIndex = 3;
            label2.Text = "分析結果 : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(533, 111);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 4;
            label3.Text = "你的星座是";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(650, 111);
            label4.Name = "label4";
            label4.Size = new Size(0, 23);
            label4.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(532, 170);
            label5.Name = "label5";
            label5.Size = new Size(118, 23);
            label5.TabIndex = 6;
            label5.Text = "你的生命靈數";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(656, 170);
            label6.Name = "label6";
            label6.Size = new Size(0, 23);
            label6.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
