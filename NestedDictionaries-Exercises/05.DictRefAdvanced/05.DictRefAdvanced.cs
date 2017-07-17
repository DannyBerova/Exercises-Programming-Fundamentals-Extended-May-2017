
namespace _05.DictRefAdvanced
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var dictRefData = new Dictionary<string, List<string>>();
            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var currentData = inputLine
                    .Split(new[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);
                var key = currentData[0];
                var values = currentData.Skip(1).ToList();

                var num = 0;
                var isValue = int.TryParse(values[0], out num);

                if (!isValue && !dictRefData.ContainsKey(values[0]))
                {
                    inputLine = Console.ReadLine();
                    continue;
                }
                if (!isValue && dictRefData.ContainsKey(values[0]))
                {
                    values = dictRefData[values[0]];
                }

                if (!dictRefData.ContainsKey(key))
                {
                    dictRefData[key] = new List<string>();
                }
                dictRefData[key].AddRange(values);

                inputLine = Console.ReadLine();
            }

            foreach (var item in dictRefData)
            {
                Console.Write($"{item.Key} === ");
                var isFirst = true;

                foreach (var value in item.Value)
                {
                    if (isFirst)
                    {
                        isFirst = false;
                        Console.Write(value);
                        continue;
                    }
                    Console.Write(", {0}", value.TrimStart());
                }
                Console.WriteLine();
            }
        }
    }
}
