
namespace _04.FoldAndSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                   .Split(' ').Select(int.Parse).ToArray();

            int k = numbers.Length / 4;

            int[] firstPartUpperRow = numbers
                .Take(k)
                .Reverse()
                .ToArray();

            int[] secondPartUpperRow = numbers
                .Reverse()
                .Take(k)
                .ToArray();

            int[] upperRow = firstPartUpperRow.Concat(secondPartUpperRow)
                .ToArray();

            int[] lowerRow = numbers
                .Skip(k)
                .Take(k * 2)
                .ToArray();

            for (int i = 0; i < lowerRow.Length; i++)
            {
                Console.Write($"{upperRow[i] + lowerRow[i]} ");
            }
        }
    }
}