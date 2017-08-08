
namespace _01.MatchFullName
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string pattern = @"\b([A-Z][a-z]+ [A-Z][a-z]+)\b";
            string text = Console.ReadLine();

            MatchCollection names = Regex.Matches(text, pattern);

            foreach (Match name in names)
            {
                Console.Write(name.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
