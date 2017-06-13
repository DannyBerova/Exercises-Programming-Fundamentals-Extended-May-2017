
namespace _05.FibonacciNumbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int fibonacciNumber = PrintNthFibonaacciNumber(n);
            Console.WriteLine(fibonacciNumber);
        }

        private static int PrintNthFibonaacciNumber(int n)
        {
            int a = 1;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}
