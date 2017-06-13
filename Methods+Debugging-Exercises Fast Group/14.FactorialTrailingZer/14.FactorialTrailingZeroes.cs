
namespace _14.FactorialTrailingZer
{
    using System;
    using System.Numerics;

    public class Program
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            BigInteger factorial = CalculateFactorial(num);
            CalculateTrailingZeroesOfFactorial(num, factorial);
        }

        private static void CalculateTrailingZeroesOfFactorial(int num, BigInteger factorial)
        {
            string factorialToString = Convert.ToString(factorial);
            int zeroesCount = 0;
            char previousDigit = '0';
            for (int i = factorialToString.Length -1; i >= 0; i--)
            {
                if (factorialToString[i] == '0')
                {
                    zeroesCount++;
                    previousDigit = factorialToString[i];
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(zeroesCount);

        }

        private static BigInteger CalculateFactorial(int num)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
