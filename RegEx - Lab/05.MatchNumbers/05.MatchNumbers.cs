
namespace _05.MatchNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            var pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            var text = Console.ReadLine();

            var numbers = Regex.Matches(text, pattern);

            foreach (Match number in numbers)
            {
                Console.Write(number.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
