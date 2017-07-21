
namespace _05.FlattenDictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var dictionaryData = new Dictionary<string, Dictionary<string, string>>();

            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] tokens = inputLine
                    .Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length > 2)
                {
                    string type = tokens[0];
                    string trademark = tokens[1];
                    string model = tokens[2];

                    if (!dictionaryData.ContainsKey(type))
                    {
                        dictionaryData[type] = new Dictionary<string, string>();
                    }

                    dictionaryData[type][trademark] = model;
                }
                else
                {
                    string type = tokens[1];

                    dictionaryData[type] = dictionaryData[type]
                        .ToDictionary(k => k.Key + k.Value + "", v => string.Empty);
                }

                inputLine = Console.ReadLine();
            }

            dictionaryData = dictionaryData
                .OrderByDescending(k => k.Key.Length)
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var type in dictionaryData)
            {
                Console.WriteLine(type.Key);

                var originalValues = type.Value
                    .Where(v => v.Value != string.Empty)
                    .ToDictionary(k => k.Key, v => v.Value)
                    .OrderBy(k => k.Key.Length)
                    .ToDictionary(k => k.Key, v => v.Value);

                var flattennedValues = type.Value
                    .Where(v => v.Value == string.Empty)
                    .ToDictionary(k => k.Key, v => v.Value);
                int index = 1;

                foreach (var trademark in originalValues)
                {
                    Console.WriteLine($"{index}. {trademark.Key} - {trademark.Value}");
                    index++;
                }

                foreach (var trademark in flattennedValues)
                {
                    Console.WriteLine($"{index}. {trademark.Key}");
                    index++;
                }
            }
        }
    }
}