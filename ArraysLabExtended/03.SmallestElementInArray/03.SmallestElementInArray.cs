
namespace _03.SmallestElementInArray
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int smallestElement = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNumber = numbers[i];
                if (currentNumber < smallestElement)
                {
                    smallestElement = currentNumber;
                }
            }

            Console.WriteLine(smallestElement);
        }
    }
}
