
namespace _02.DefaultValues
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var inputValues = new Dictionary<string, string>();

            string inputLine = Console.ReadLine();
            while (inputLine != "end")
            {
                string[] tokens =
                    inputLine.Split(new string[] { " -> " }, 
                    StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];
                string value = tokens[1];

                inputValues[name] = value;

                inputLine = Console.ReadLine();
            }

            string defaultValue = Console.ReadLine();

            var givenValues = inputValues
                .Where(r => r.Value != "null")
                .OrderByDescending(r => r.Value.Length)
                .ToDictionary(k => k.Key, v => v.Value); ;

            var defaultValues = inputValues
                .Where(r => r.Value == "null")
                .ToDictionary(r => r.Key, r => defaultValue);

            var output = givenValues
                .Concat(defaultValues)
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var pair in output)
            {
                Console.WriteLine($"{pair.Key} <-> {pair.Value}");
            }
        }
    }
}