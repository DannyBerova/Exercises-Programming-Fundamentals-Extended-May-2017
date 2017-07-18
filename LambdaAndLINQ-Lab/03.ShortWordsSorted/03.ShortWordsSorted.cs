
namespace _03.ShortWordsSorted
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] words = Console.ReadLine()
                   .ToLower()
                   .Split(" .,:;()[]\"'\\/!?".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                   .Where(x => x.Length < 5)
                   .OrderBy(x => x)
                   .Distinct()
                   .ToArray();

            Console.WriteLine($"{string.Join(", ", words)}");
        }
    }
}
