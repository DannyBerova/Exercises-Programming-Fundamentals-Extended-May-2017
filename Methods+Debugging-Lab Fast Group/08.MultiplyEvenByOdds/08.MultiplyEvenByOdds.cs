
namespace _08.MultiplyEvenByOdds
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));

            int product = GetMultipleOfEvenAndOdds(num);
            Console.WriteLine(product);
        }

        private static int GetMultipleOfEvenAndOdds(int num)
        {
            int sumEvens = GetSumOfEvenDigits(num);
            int sumOdds = GetSumOfOddDigits(num);
            return sumEvens * sumOdds;
        }

        private static int GetSumOfEvenDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int lastDigit = num % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                num /= 10;
            }
            return sum;
        }

        private static int GetSumOfOddDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int lastDigit = num % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                num /= 10;
            }
            return sum;
        }
    }
}
