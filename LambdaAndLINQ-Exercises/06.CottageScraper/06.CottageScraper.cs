
namespace _06.CottageScraper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var logsData = new Dictionary<string, List<int>>();

            string input = Console.ReadLine();

            while (input != "chop chop")
            {
                string[] tokens = input.Split(new string[] { " -> " },
                                  StringSplitOptions.RemoveEmptyEntries);

                string logsType = tokens[0];
                int logsHeight = int.Parse(tokens[1]);

                if (!logsData.ContainsKey(logsType))
                {
                    logsData.Add(logsType, new List<int>());
                }
                logsData[logsType].Add(logsHeight);

                input = Console.ReadLine();
            }

            string typeNeeded = Console.ReadLine();
            int heightNeeded = int.Parse(Console.ReadLine());

            double sumLogs = logsData.Values.Sum(d => d.Sum());
            int logsCount = 0;

            foreach (var list in logsData.Values)
            {
                logsCount += list.Count;
            }

            double pricePerMeter = Math.Round(sumLogs / logsCount, 2);

            Console.WriteLine($"Price per meter: ${pricePerMeter:f2}");

            int usedLogs = 0;

            foreach (var pair in logsData)
            {
                if (pair.Key == typeNeeded)
                {
                    foreach (int log in logsData[pair.Key])
                    {
                        if (log >= heightNeeded)
                        {
                            usedLogs += log;
                        }
                    }
                }
            }

            int unusedLogs = (int)sumLogs - usedLogs;

            double usedLogsPrice = Math.Round(usedLogs * pricePerMeter, 2);
            double unusedLogsPrice = Math.Round(unusedLogs * pricePerMeter * 0.25, 2);
            double subTotal = Math.Round(usedLogsPrice + unusedLogsPrice, 2);

            Console.WriteLine($"Used logs price: ${usedLogsPrice:f2}");
            Console.WriteLine($"Unused logs price: ${unusedLogsPrice:f2}");
            Console.WriteLine($"CottageScraper subtotal: ${subTotal:f2}");
        }
    }
}