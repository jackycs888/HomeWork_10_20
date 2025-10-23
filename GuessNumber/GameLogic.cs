using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    internal class GameLogic
    {
        public string Answer { get; private set; } //private set，使外部只能讀取，不能修改答案

        public GameLogic()
        {
            GenerateNumber();
        }

        public void GenerateNumber()
        {
            Random random = new Random();
            string result = "";
            while (result.Length < 4)
            {
                string numbers = random.Next(0,10).ToString();
                if (!result.Contains(numbers))
                {
                    result += numbers;
                }
            }
            Answer = result;
        }
    }
}
