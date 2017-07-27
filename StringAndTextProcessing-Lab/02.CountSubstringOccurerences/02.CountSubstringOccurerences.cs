
namespace _02.CountSubstringOccurerences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine().ToLower();
            string sample = Console.ReadLine().ToLower();

            int counter = 0;
            int startIndex = input.IndexOf(sample);

            while (startIndex != -1)
            {
                counter++;
                startIndex = input.IndexOf(sample, startIndex + 1);
            }

            Console.WriteLine(counter);
        }
    }
}
