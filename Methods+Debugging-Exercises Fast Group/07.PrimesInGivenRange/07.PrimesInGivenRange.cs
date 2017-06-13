
namespace _07.PrimesInGivenRange
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var startNum = int.Parse(Console.ReadLine());
            var endNum = int.Parse(Console.ReadLine());
            var primes = FindPrimesInRange(startNum, endNum);

            Console.WriteLine((string.Join(", ", primes)));
        }

        private static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            var primes = new List<int>();
            for (int currentNum = startNum; currentNum <= endNum; currentNum++)
            {
                if (IsPrime(currentNum))
                {
                    primes.Add(currentNum);
                }

            }
            return primes;
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

            var maxNumber = Math.Sqrt(number);
            for (int currentNum = 2; currentNum <= maxNumber ; currentNum++)
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
