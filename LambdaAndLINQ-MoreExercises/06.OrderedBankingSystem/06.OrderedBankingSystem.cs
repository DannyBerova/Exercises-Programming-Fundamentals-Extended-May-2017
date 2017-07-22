
namespace _06.OrderedBankingSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var banksData = new Dictionary<string, Dictionary<string, decimal>>();
            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] tokens = inputLine
                    .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                string bankName = tokens[0];
                string personName = tokens[1];
                decimal balance = decimal.Parse(tokens[2]);

                if (!banksData.ContainsKey(bankName))
                {
                    banksData[bankName] = new Dictionary<string, decimal>();
                }
                if (!banksData[bankName].ContainsKey(personName))
                {
                    banksData[bankName][personName] = 0m;
                }

                banksData[bankName][personName] += balance;

                inputLine = Console.ReadLine();
            }

            // "b" -> bankName, "p" -> personAccountData
            banksData
                .OrderByDescending(b => b.Value.Sum(p => p.Value))
                .ThenByDescending(b => b.Value.Max(p => p.Value))
                .ToList()
                .ForEach(b => b.Value
                    .OrderByDescending(p => p.Value)
                    .ToList()
                    .ForEach(p => Console.WriteLine(
                        $"{p.Key} -> {p.Value} ({b.Key})" )));
        }
    }
}
