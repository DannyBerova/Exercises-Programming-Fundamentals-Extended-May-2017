
namespace _02.Dict_Ref
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {

            string[] input = Console.ReadLine().Split().ToArray();

            var dictRef = new Dictionary<string, int>();

            while (input[0] != "end")
            {
                string firstElement = input[0];
                string secondElement = input[2];
                int value = 0;

                if (int.TryParse(secondElement, out value))
                {
                    dictRef[firstElement] = value;
                }
                else
                {
                    if (dictRef.ContainsKey(secondElement))
                    {
                        int secondEntryValue = dictRef[secondElement];
                        dictRef[firstElement] = secondEntryValue;
                    }
                }

                input = Console.ReadLine().Split().ToArray();
            }

            foreach (var kvp in dictRef)
            {
                Console.WriteLine($"{kvp.Key} === {kvp.Value}");
            }
        }
    }
}
        
