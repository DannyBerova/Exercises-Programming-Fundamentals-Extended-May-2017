
namespace _15.FastPrimeChecker
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int endNumber = int.Parse(Console.ReadLine());
            for (int currentNum = 2; currentNum <= endNumber; currentNum++)
            {
                bool isPrime = true;
                for (int num = 2; num <= Math.Sqrt(currentNum); num++)
                {
                    if (currentNum % num == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{currentNum} -> {isPrime}");
            }
        }
    }
}
