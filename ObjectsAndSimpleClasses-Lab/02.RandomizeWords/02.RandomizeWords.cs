
namespace _02.RandomizeWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split();

            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int randomPos = random.Next(words.Length);

                var tempWord = words[randomPos];
                words[randomPos] = words[i];
                words[i] = tempWord;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
