
namespace _02.Largest3Numbers
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
                   .OrderByDescending(x => x)
                   .Take(3)
                   .ToArray();

            Console.WriteLine($"{string.Join(" ", numbers)}");
        }
    }
}
