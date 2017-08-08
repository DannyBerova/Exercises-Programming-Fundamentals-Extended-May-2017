
namespace _02.MatchPhoneNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string pattern = @"(\+359([ |-])2\2\d{3}\2\d{4})\b";
            string text = Console.ReadLine();

            MatchCollection phones = Regex.Matches(text, pattern);

            var phonesMatched = phones.Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", phonesMatched));
        }
    }
}
