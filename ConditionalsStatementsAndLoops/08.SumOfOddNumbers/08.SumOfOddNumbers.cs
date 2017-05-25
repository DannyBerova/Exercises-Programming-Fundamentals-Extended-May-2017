
namespace _08.SumOfOddNumbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var sum = 0;
            var currentNumber = 1;

            for (int i = 0; i < n; i++)
            {
                sum += currentNumber;
                currentNumber += 2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
