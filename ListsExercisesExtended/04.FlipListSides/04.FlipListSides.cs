
namespace _04.FlipListSides
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

            int last = numbers[numbers.Count - 1];
            int first = numbers[0];

            numbers.Reverse();
            numbers[0] = first;
            numbers[numbers.Count - 1] = last;

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
