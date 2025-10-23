using System.Runtime.CompilerServices;

namespace Char_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入一段文字 : ");
            string input = Console.ReadLine();

            string lowerInput = input.ToLower();

            string[] words = lowerInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
             
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            var result = wordCount.OrderByDescending(w => w.Value);

            foreach (var pair in result)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }

        }
    }
}
