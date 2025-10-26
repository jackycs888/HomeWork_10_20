namespace GuessNumber
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
            GuessHistory = new ListBox();
            label1 = new Label();
            BtnStart = new Button();
            label2 = new Label();
            textGuess = new TextBox();
            BtnGuess = new Button();
            BtnRestart = new Button();
            LabelResult = new Label();
            BtnTest = new Button();
            SuspendLayout();
            // 
            // GuessHistory
            // 
            GuessHistory.FormattingEnabled = true;
            GuessHistory.Location = new Point(480, 89);
            GuessHistory.Name = "GuessHistory";
            GuessHistory.Size = new Size(247, 280);
            GuessHistory.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(480, 63);
            label1.Name = "label1";
            label1.Size = new Size(82, 23);
            label1.TabIndex = 1;
            label1.Text = "遊戲歷程";
            // 
            // BtnStart
            // 
            BtnStart.Location = new Point(64, 63);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(170, 76);
            BtnStart.TabIndex = 2;
            BtnStart.Text = "開始遊戲";
            BtnStart.UseVisualStyleBackColor = true;
            BtnStart.Click += BtnStart_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 223);
            label2.Name = "label2";
            label2.Size = new Size(46, 23);
            label2.TabIndex = 3;
            label2.Text = "輸入";
            // 
            // textGuess
            // 
            textGuess.Location = new Point(64, 249);
            textGuess.Name = "textGuess";
            textGuess.Size = new Size(252, 30);
            textGuess.TabIndex = 4;
            // 
            // BtnGuess
            // 
            BtnGuess.Location = new Point(64, 315);
            BtnGuess.Name = "BtnGuess";
            BtnGuess.Size = new Size(104, 54);
            BtnGuess.TabIndex = 5;
            BtnGuess.Text = "猜";
            BtnGuess.UseVisualStyleBackColor = true;
            BtnGuess.Click += BtnGuess_Click;
            // 
            // BtnRestart
            // 
            BtnRestart.Location = new Point(204, 315);
            BtnRestart.Name = "BtnRestart";
            BtnRestart.Size = new Size(112, 54);
            BtnRestart.TabIndex = 6;
            BtnRestart.Text = "重來";
            BtnRestart.UseVisualStyleBackColor = true;
            BtnRestart.Click += BtnRestart_Click;
            // 
            // LabelResult
            // 
            LabelResult.AutoSize = true;
            LabelResult.Location = new Point(116, 223);
            LabelResult.Name = "LabelResult";
            LabelResult.Size = new Size(0, 23);
            LabelResult.TabIndex = 7;
            // 
            // BtnTest
            // 
            BtnTest.Location = new Point(349, 249);
            BtnTest.Name = "BtnTest";
            BtnTest.Size = new Size(112, 34);
            BtnTest.TabIndex = 8;
            BtnTest.Text = "test";
            BtnTest.UseVisualStyleBackColor = true;
            BtnTest.Click += BtnTest_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnTest);
            Controls.Add(LabelResult);
            Controls.Add(BtnRestart);
            Controls.Add(BtnGuess);
            Controls.Add(textGuess);
            Controls.Add(label2);
            Controls.Add(BtnStart);
            Controls.Add(label1);
            Controls.Add(GuessHistory);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox GuessHistory;
        private Label label1;
        private Button BtnStart;
        private Label label2;
        private TextBox textGuess;
        private Button BtnGuess;
        private Button BtnRestart;
        private Label LabelResult;
        private Button BtnTest;
    }
}
