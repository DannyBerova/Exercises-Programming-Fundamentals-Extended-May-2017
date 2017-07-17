
namespace _06.Extremums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();

            int minValue = int.MaxValue;
            int maxValue = int.MinValue;
            int sum = 0;
            List<int> result = new List<int>();

            if (command == "Min")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    int number = numbers[i];
                    string numberToString = number.ToString();
                    int count = 0;

                    while (count <= numberToString.Length)
                    {
                        if (number < minValue)
                        {
                            minValue = number;
                        }
                        numberToString = ShiftString(numberToString);
                        number = int.Parse(numberToString);
                        count++;
                    }

                    result.Add(minValue);
                    sum += minValue;
                    minValue = int.MaxValue;
                }
            }
            if (command == "Max")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    int number = numbers[i];
                    string numberToString = number.ToString();
                    int count = 0;

                    while (count <= numberToString.Length)
                    {
                        if (number > maxValue)
                        {
                            maxValue = number;
                        }
                        numberToString = ShiftString(numberToString);
                        number = int.Parse(numberToString);
                        count++;
                    }

                    result.Add(maxValue);
                    sum += maxValue;
                    maxValue = int.MinValue;
                }
            }

            Console.WriteLine(string.Join(", ", result));
            Console.WriteLine(sum);
        }

        static string ShiftString(string str)
        {
            string firstChar = str.Substring(0, 1);
            return str.Substring(1) + firstChar;
        }
    }
}