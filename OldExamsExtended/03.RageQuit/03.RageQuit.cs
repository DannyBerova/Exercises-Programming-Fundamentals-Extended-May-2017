
namespace _03.RageQuit
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string pattern = @"(\D+)(\d+)";
            Regex regex = new Regex(pattern);

            string inputLine = Console.ReadLine();

            var matches = regex.Matches(inputLine);

            StringBuilder result = new StringBuilder();

            foreach (Match match in matches)
            {
                string partition = match.Groups[1].Value;
                int times = int.Parse(match.Groups[2].Value);

                for (int i = 0; i < times; i++)
                {
                    result.Append(partition.ToUpper());
                }
            }

            int count = result.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {count}");
            Console.WriteLine(result);
        }
    }
}
