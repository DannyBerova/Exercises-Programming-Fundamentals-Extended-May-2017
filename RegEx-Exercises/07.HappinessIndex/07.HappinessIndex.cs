
namespace _07.HappinessIndex
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
            string happyPattern = @"(:\)|:D|;\)|:\*|:]|;]|:}|;}|\(:|\*:|c:|\[:|\[;)";
            string sadPattern = @"(:\(|D:|;\(|:\[|;\[|:{|;{|\):|:c|\]:|\];)";

            double happinessIndex = 0.0;

            string input = Console.ReadLine();

            var happyEmoticons = Regex.Matches(input, happyPattern);
            var sadEmoticons = Regex.Matches(input, sadPattern);

            happinessIndex = (double)happyEmoticons.Count / sadEmoticons.Count;

            string status = string.Empty;

            if (happinessIndex >= 2)
            {
                status = ":D";
            }
            else if (happinessIndex > 1)
            {
                status = ":)";
            }
            else if (happinessIndex == 1)
            {
                status = ":|";
            }
            else if (happinessIndex < 1)
            {
                status = ":(";
            }

            Console.WriteLine
                ($"Happiness index: {happinessIndex:F2} {status}");
            Console.WriteLine(
                $"[Happy count: {happyEmoticons.Count}, Sad count: {sadEmoticons.Count}]");
        }
    }
}
