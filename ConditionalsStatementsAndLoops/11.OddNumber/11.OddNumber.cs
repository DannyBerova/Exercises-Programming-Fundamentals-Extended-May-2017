
namespace _11.OddNumber
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var currentNumber = int.Parse(Console.ReadLine());

            while (currentNumber % 2 == 0)
            {
                Console.WriteLine("Please write an odd number.");
                currentNumber = int.Parse(Console.ReadLine());
            }

            var absoluteValueNumber = Math.Abs(currentNumber);
            Console.WriteLine($"The number is: {absoluteValueNumber}");
        }
    }
}
