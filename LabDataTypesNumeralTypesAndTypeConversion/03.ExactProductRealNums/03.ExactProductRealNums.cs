
namespace _03.ExactProductRealNums
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 1m;

            for (int i = 0; i < n; i++)
            {
                decimal currentNumber = decimal.Parse(Console.ReadLine());
                sum *= currentNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
