
namespace _01.LetterRepetition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            char[] letters = Console.ReadLine()
                   .ToCharArray();

            Dictionary<char, int> output = new Dictionary<char, int>();

            foreach (var letter in letters)
            {
                if (!output.ContainsKey(letter))
                {
                    output[letter] = 0;
                }
                output[letter]++;
            }

            foreach (var letter in output)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}
