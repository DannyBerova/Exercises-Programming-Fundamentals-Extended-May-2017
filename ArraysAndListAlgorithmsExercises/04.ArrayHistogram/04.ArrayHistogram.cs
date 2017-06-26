
namespace _04.ArrayHistogram
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

            List<string> words = new List<string>();
            List<int> counts = new List<int>();

            TakeCountsOfEachWord(words, counts);

            SortCountOfWordsInDescendingOrder(words, counts);

            for (int i = 0; i < counts.Count; i++)
            {
                double percentage = counts[i] * 100.0 / strings.Length;
                Console.WriteLine($"{words[i]} -> {counts[i]} times ({percentage:F2}%)");
            }
        }

        public static void SortCountOfWordsInDescendingOrder(List<string> words, List<int> counts)
        {
            bool hasSwapped = true;
            while (hasSwapped)
            {
                hasSwapped = false;
                for (int i = 0; i < counts.Count - 1; i++)
                {
                    if (counts[i] < counts[i + 1])
                    {
                        int temp = counts[i];
                        counts[i] = counts[i + 1];
                        counts[i + 1] = temp;

                        string tempWord = words[i];
                        words[i] = words[i + 1];
                        words[i + 1] = tempWord;

                        hasSwapped = true;
                    }
                }
            }
        }

        public static void TakeCountsOfEachWord(List<string> words, List<int> counts)
        {
            for (int str = 0; str < strings.Length; str++)
            {
                if (words.Contains(strings[str]))
                {
                    int index = words.IndexOf(strings[str]);
                    counts[index]++;
                }
                else
                {
                    words.Add(strings[str]);
                    counts.Add(1);
                }
            }
        }
    }
}

