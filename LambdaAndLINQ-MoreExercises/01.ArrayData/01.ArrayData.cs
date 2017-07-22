
namespace _01.ArrayData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            string command = Console.ReadLine();

            double avgNumbers = numbers.Average();
            numbers = numbers
                .Where(n => n >= avgNumbers)
                .ToArray();

            string output = string.Empty;

            if (command == "Min")
            {
                output = numbers
                    .Min()
                    .ToString();
            }
            else if (command == "Max")
            {
                output = numbers
                    .Max()
                    .ToString();
            }
            else
            {
                output = string.Join(" ", numbers.OrderBy(n => n));
            }

            Console.WriteLine(output);
        }
    }
}