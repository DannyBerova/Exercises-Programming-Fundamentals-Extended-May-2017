
namespace _04.GroupContinentsCountriesCities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> globalData = 
                new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputData = Console.ReadLine()
                    .Split(new [] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                string continent = inputData[0];
                string country = inputData[1];
                string city = inputData[2];

                if (!globalData.ContainsKey(continent))
                {
                    globalData[continent] = new SortedDictionary<string, SortedSet<string>>();
                }

                if (!globalData[continent].ContainsKey(country))
                {
                    globalData[continent][country] = new SortedSet<string>();
                }

                globalData[continent][country].Add(city);

            }

            foreach (var continet in globalData)
            {
                Console.WriteLine($"{continet.Key}:");

                foreach (var country in continet.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
