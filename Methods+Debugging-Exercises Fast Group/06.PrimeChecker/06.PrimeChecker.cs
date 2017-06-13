
namespace _06.PrimeChecker
{
    using System;

    public class Program
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());

            bool isPrime = IsPrime(number);
            Console.WriteLine(isPrime);
        }

        private static bool IsPrime(long number)
        {
            if (number == 0 || number == 1)
            {
                return false;
            }

            if (number == 2)
            {
                return true;
            }

            for (int currentNum = 2; currentNum <= Math.Sqrt(number); currentNum++)
            {
                if (number % currentNum == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
