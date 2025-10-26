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
                MessageBox.Show("�п�J�|�줣���ƪ��Ʀr !");
                return;
            }

            GuessHistory.Items.Add($"��{game.Attempts}�� : {guess} --> {result}");

            if (result == "4A0B")
            {
                MessageBox.Show($"����F ! �@�q�F {game.Attempts} ��");
            }
            else
            {
                LabelResult.Text = $"���G : {result}";
            }

            textGuess.Clear();
            textGuess.Focus();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            game = new GameLogic();
            MessageBox.Show("�w�ͦ��s�Ʀr�A�}�l�q�a");
            BtnStart.Enabled = false;
        }
        private void BtnRestart_Click(object sender, EventArgs e)
        {
            game.StartNewGame();
            GuessHistory.Items.Clear();
            LabelResult.Text = "�w���s�}�l";
            textGuess.Clear();
            textGuess.Focus();
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            string ans = game.GetAnswer();
            MessageBox.Show($"�ثe�����׬O {ans}, �ȨѴ��ե�");
        }
    }
}
