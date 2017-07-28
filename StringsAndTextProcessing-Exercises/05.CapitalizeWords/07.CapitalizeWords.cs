﻿
namespace _07.CapitalizeWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] elements = inputLine.Trim()
                    .Split(new[] { ' ', '.', ',', ':', ';', '?', '!', '-', '_' },
                    StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < elements.Length; i++)
                {
                    string word = elements[i].ToLower();
                    string firstLetter = word[0].ToString().ToUpper();

                    elements[i] =firstLetter + word.Substring(1);
                }

                Console.WriteLine(string.Join(", ", elements));

                inputLine = Console.ReadLine();
            }
        }
    }
}
