
namespace _01.RemoveElementsAtOddPosition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();

            List<string> output = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                if (i % 2 != 0)
                {
                    output.Add(input[i]);
                }
            }

            Console.WriteLine(string.Join("", output));
        }
    }
}
