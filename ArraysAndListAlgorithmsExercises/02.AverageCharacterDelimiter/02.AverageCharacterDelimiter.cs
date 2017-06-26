
namespace _02.AverageCharacterDelimiter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static string[] strings;
        public static void Main()
        {
            strings = Console.ReadLine().Split();
            string delimiter = string.Empty;
            delimiter = FindAverageCharacter(delimiter);

            Console.WriteLine(string.Join($"{delimiter}", strings));
        }

        private static string FindAverageCharacter(string delimiter)
        {
            int sumChars = 0;
            int count = 0;
            for (int i = 0; i < strings.Length; i++)
            {
                char[] currentString = strings[i].ToCharArray();
                count += currentString.Length;

                for (int currentChar = 0; currentChar < currentString.Length; currentChar++)
                {
                    sumChars += currentString[currentChar];
                }
            }

            char lowerDelimiter = (char)(sumChars / count);
            delimiter = lowerDelimiter.ToString().ToUpper();

            return delimiter;
        }
    }
}
