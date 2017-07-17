using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                      .Split()
                      .Select(double.Parse)
                      .ToList();

            var output = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!output.ContainsKey(number))
                {
                    output[number] = 0;
                }
                output[number]++;
            }

            foreach (var kvp in output)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}