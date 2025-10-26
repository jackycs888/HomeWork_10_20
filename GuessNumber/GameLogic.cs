using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    internal class GameLogic
    {
        private string answer;
        private Random random;
        private int attempts;

        public GameLogic()
        {
            random = new Random();
            StartNewGame();

        }

        public void StartNewGame()
        {
            answer = GenerateNumber();
            attempts = 0;
        }
        public int Attempts => attempts;

        public string GetAnswer() => answer;

        public string MakeGuess(string guess)
        {
            if (!IsValid(guess))
            {
                return "Invalid";
            }

            attempts++;
            return CheckAns(answer, guess);
        }

        public string GenerateNumber()
        {
            string result = "";
            while (result.Length < 4)
            {
                string numbers = random.Next(0,10).ToString();
                if (!result.Contains(numbers))
                {
                    result += numbers;
                }
            }
            return result;
        }

        public bool IsValid(string guess)
        {
            if (guess.Length != 4) return false;
            foreach (char c in guess)
            {
                if(!char.IsDigit(c)) return false;
            }
            for (int i = 0; i < guess.Length; i++)
            {
                for (int j = i + 1; j < guess.Length; j++)
                {
                    if (guess[i] == guess[j]) return false;
                }
            }
            return true;
        }

        public string CheckAns(string answer, string guess)
        {
            int A = 0, B = 0;
            for(int i = 0; i < 4; i++)
            {
                if (guess[i] == answer[i])
                {
                    A++;
                }
                else if (answer.Contains(guess[i]))
                {
                    B++;
                }
            }
            return $"{A}A{B}B";
        }
    }
}
