using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OddOccurrences
{
    class Program
    {
        static void Main()
        {
            var words = Console.ReadLine()
                .ToLower()
                .Split()
                .ToArray();

            Dictionary<string, int> occurrences = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!occurrences.ContainsKey(word))
                {
                    occurrences[word] = 0;
                }
                occurrences[word]++;
            }

            var output = new List<string>();

            foreach (var kvp in occurrences)
            {

                if (kvp.Value % 2 == 1)
                {
                    output.Add(kvp.Key);
                }
            }

            Console.WriteLine(string.Join(", ", output));
        }
    }
}