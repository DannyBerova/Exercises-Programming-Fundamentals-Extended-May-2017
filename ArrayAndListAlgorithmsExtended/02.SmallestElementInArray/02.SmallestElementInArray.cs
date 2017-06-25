
namespace _02.SmallestElementInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int smallestInt = numbers[0];
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < smallestInt)
                {
                    smallestInt = numbers[i];
                }
            }

            Console.WriteLine(smallestInt);
        }
    }
}
