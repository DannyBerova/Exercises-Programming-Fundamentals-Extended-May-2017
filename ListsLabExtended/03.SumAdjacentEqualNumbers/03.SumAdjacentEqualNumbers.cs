
namespace _03.SumAdjacentEqualNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .ToList();
            numbers.Add(int.MaxValue);

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i + 1] = numbers[i] + numbers[i + 1];
                    numbers.RemoveAt(i);
                    i= -1;
                }
            }

            numbers.RemoveAt(numbers.Count - 1);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
