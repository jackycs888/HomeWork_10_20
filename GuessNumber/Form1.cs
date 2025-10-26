namespace GuessNumber
{
    public partial class Form1 : Form
    {
        private GameLogic game;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void BtnGuess_Click(object sender, EventArgs e)
        {
            string guess = textGuess.Text.Trim();
            string result = game.MakeGuess(guess);

            if (result == "Invalid")
            {
                MessageBox.Show("請輸入四位不重複的數字 !");
                return;
            }

            GuessHistory.Items.Add($"第{game.Attempts}次 : {guess} --> {result}");

            if (result == "4A0B")
            {
                MessageBox.Show($"答對了 ! 共猜了 {game.Attempts} 次");
            }
            else
            {
                LabelResult.Text = $"結果 : {result}";
            }

            textGuess.Clear();
            textGuess.Focus();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            game = new GameLogic();
            MessageBox.Show("已生成新數字，開始猜吧");
            BtnStart.Enabled = false;
        }
        private void BtnRestart_Click(object sender, EventArgs e)
        {
            game.StartNewGame();
            GuessHistory.Items.Clear();
            LabelResult.Text = "已重新開始";
            textGuess.Clear();
            textGuess.Focus();
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            string ans = game.GetAnswer();
            MessageBox.Show($"目前的答案是 {ans}, 僅供測試用");
        }
    }
}
