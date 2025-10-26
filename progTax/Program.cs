

namespace progTax
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("請輸入年收入計算累進稅率 : ");
            decimal income = decimal.Parse(Console.ReadLine());

            decimal tax_Result = CalculateTax(income);

            Console.WriteLine($"應繳稅額 : {tax_Result:C}");
        }

        private static decimal CalculateTax(decimal income)
        {
            decimal[] thresholds = {540000m, 1210000m, 2420000m
            ,4530000m, 10310000m };
            decimal[] rates = {0.05m, 0.12m, 0.20m,
                0.30m, 0.40m, 0.50m};

            return CalculateRecursive(income, thresholds, rates, 0);
        }

        private static decimal CalculateRecursive(decimal income, decimal[] thresholds, decimal[] rates, int level)
        {
            if (level == thresholds.Length)
            {
                decimal previous = thresholds[level - 1];
                return (income - previous) * rates[level];
            }

            if (income <= thresholds[level])
            {
                decimal previous;
                if (level == 0)
                {
                    previous = 0;
                }
                else
                {
                    previous = thresholds[level - 1];
                }
                return (income - previous) * rates[level];
            }
            else
            {
                decimal previous;
                if (level == 0)
                {
                    previous = 0;
                }
                else
                {
                    previous = thresholds[level - 1];
                }
                decimal currentTax = (thresholds[level] - previous) * rates[level];
                return currentTax + CalculateRecursive(income, thresholds, rates, level + 1);
            }
        }
    }
}
