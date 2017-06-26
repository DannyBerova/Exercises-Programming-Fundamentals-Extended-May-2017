
namespace _05.DecodeRadioFrequencies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            decimal[] frequencies = Console.ReadLine()
                .Split()
                .Select(decimal.Parse)
                .ToArray();
            List<char> convertedChars = new List<char>();

            for (int i = 0; i < frequencies.Length; i++)
            {
                decimal value = frequencies[i];
                List<int> currentFrequencyParts = (value.ToString()).Split('.').Select(int.Parse).ToList();
                char leftPart = (char)(currentFrequencyParts[0]);
                char rightPart = (char)(currentFrequencyParts[1]);

                if ((int)leftPart != 0)
                {
                    convertedChars.Insert(i, leftPart);
                }
                convertedChars.Reverse();
                if ((int)rightPart != 0)
                {
                    convertedChars.Insert(i, rightPart);
                }
                convertedChars.Reverse();
            }

            Console.WriteLine(string.Join("", convertedChars));
        }
    }
}
