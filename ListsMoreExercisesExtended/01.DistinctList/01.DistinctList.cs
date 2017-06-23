
namespace _01.DistinctList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ').Select(int.Parse).ToList();

            List<int> distinct = numbers.Distinct().ToList();

            Console.WriteLine(string.Join(" ", distinct));
        }
    }
}
