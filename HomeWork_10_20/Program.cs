namespace HomeWork_10_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int number2 = int.Parse(number);

            for(int i = 1; i<number2; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Dann");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Build");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("School");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
