
namespace _02.WormIpsum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            var regex = new Regex(@"[A-Z]{1}[\w\W]+?\.{1,}");
            string sentenceLine = Console.ReadLine();

            while (sentenceLine != "Worm Ipsum")
            {
                var matches = regex.Matches(sentenceLine);

                if (matches.Count > 1)
                {
                    sentenceLine = Console.ReadLine();
                    continue;
                }

                var sentence = string.Empty;

                var words = sentenceLine.TrimEnd('.').Split(' ');
                foreach (var word in words)
                {
                    string currentWord = ProcessWord(word);

                    sentence += $" {currentWord}";
                }

                sentence = sentence.TrimStart();
                Console.WriteLine($"{sentence}.");

                sentenceLine = Console.ReadLine();
            }
        }
        private static string ProcessWord(string word)
        {
            var elements = new Dictionary<char, int>();

            for (int ind = 0; ind < word.Length; ind++)
            {
                var element = word[ind];
                if (!elements.ContainsKey(word[ind]))
                {
                    elements[element] = 0;
                }

                elements[element]++;
            }

            char returned = elements.OrderByDescending(c => c.Value).First().Key;
            var occurences = elements.OrderByDescending(c => c.Value).First().Value;

            if (occurences >= 2)
            {
                string returnedWord = string.Empty;
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == ',')
                    {
                        returnedWord += ',';
                    }
                    else if (word[i] == '\'')
                    {
                        returnedWord += '\'';
                    }
                    else
                    {
                        returnedWord += returned;
                    }
                }

                return returnedWord;
            }
            else
            {
                return word;
            }
        }
    }
}

