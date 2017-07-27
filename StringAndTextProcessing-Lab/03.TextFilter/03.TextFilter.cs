
namespace _03.TextFilter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] bannedWords = Console.ReadLine()
                .Split(new[] { ' ', ',', '.' }, 
                StringSplitOptions.RemoveEmptyEntries);
            string inputText = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                inputText = inputText
                    .Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(inputText);
        }
    }
}
