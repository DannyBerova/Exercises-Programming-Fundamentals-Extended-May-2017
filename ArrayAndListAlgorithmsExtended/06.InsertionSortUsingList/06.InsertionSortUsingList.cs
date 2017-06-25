
namespace _06.InsertionSortUsingList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            List<int> outputList = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                bool inserted = false;
                int currentElement = numbers[i];
                for (int index = 0; index < outputList.Count; index++)
                {
                    int currentListElement = outputList[index];
                    if (currentElement <= currentListElement)
                    {
                        inserted = true;
                        outputList.Insert(Math.Max(0, index), currentElement);
                        break;
                    }
                }

                if (!inserted)
                {
                    outputList.Add(currentElement);
                }
            }

            Console.WriteLine(string.Join(" ", outputList));
        }
    }
}
