
namespace _03.MatchHexadecimalsNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string pattern = @"\b(?:0x)?[0-9A-F]+\b";

            string textNumbers = Console.ReadLine();
            var numbers = Regex.Matches(textNumbers, pattern)
                .Cast<Match>()
                .Select(a => a.Value)
                .ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
