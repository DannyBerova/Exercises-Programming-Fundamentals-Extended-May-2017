
namespace _02.Key_Key_Value_Value
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var pairsData = new Dictionary<string, List<string>>();

            var key = Console.ReadLine();
            var value = Console.ReadLine();
            var lines = int.Parse(Console.ReadLine());

            for (int count = 0; count < lines; count++)
            {
                var currentLine = Console.ReadLine().Split(new[] { ' ', ';' });

                var currentKey = currentLine[0];
                var currentValues = currentLine.Skip(2);

                if (currentKey.Contains(key))
                {
                    if (!pairsData.ContainsKey(currentKey))
                    {
                        pairsData[currentKey] = new List<string>();
                    }

                    foreach (var val in currentValues)
                    {
                        if (value.Contains(val) || val.Contains(value))
                        {
                            pairsData[currentKey].Add(val);
                        }
                    }
                }
            }

            foreach (var item in pairsData)
            {
                Console.WriteLine("{0}:", item.Key);

                foreach (var element in item.Value)
                {
                    Console.WriteLine("-{0}", element);
                }
            }
        }
    }
}