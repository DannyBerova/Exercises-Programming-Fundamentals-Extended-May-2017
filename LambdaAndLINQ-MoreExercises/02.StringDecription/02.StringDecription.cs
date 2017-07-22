
namespace _02.StringDecription
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] inputParams = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

            List<int> numbersToChars = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int m = inputParams[0];
            int n = inputParams[1];

            List<char> charsOutput = numbersToChars
                .Where(num => (num >= 'A' && num <= 'Z'))
                .Skip(m)
                .Take(n)
                .Select(num => (char)num)
                .ToList();

            Console.WriteLine(string.Join("", charsOutput));
        }
    }
}