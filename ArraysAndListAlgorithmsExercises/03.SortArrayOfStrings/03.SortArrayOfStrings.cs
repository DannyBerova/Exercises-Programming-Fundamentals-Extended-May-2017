
namespace _03.SortArrayOfStrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static string[] words;
        public static void Main()
        {
            words = Console.ReadLine().Split();

            SortArray();

            Console.WriteLine(string.Join(" ", words));

        }

        public static void SortArray()
        {
            bool hasSwapped = true;
            while (hasSwapped)
            {
                hasSwapped = false;
                for (int i = 0; i < words.Length - 1; i++)
                {
                    if (words[i].CompareTo(words[i + 1]) > 0)
                    {
                        string tempWord = words[i];
                        words[i] = words[i + 1];
                        words[i + 1] = tempWord;

                        hasSwapped = true;
                    }
                }
            }
        }
    }
}

