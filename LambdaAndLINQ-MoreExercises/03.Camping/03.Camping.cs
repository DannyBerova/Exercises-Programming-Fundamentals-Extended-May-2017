
namespace _03.Camping
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var campers = new Dictionary<string, Dictionary<string, int>>();

            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] tokens = inputLine.Split();

                string name = tokens[0];
                string camperModel = tokens[1];
                int timeToStay = int.Parse(tokens[2]);

                if (!campers.ContainsKey(name))
                {
                    campers.Add(name, new Dictionary<string, int>());
                }
                else
                {
                    if (!campers[name].ContainsKey(camperModel))
                    {
                        campers[name].Add(camperModel, timeToStay);
                    }
                }

                if (!campers[name].ContainsKey(camperModel))
                {
                    campers[name].Add(camperModel, timeToStay);
                }

                inputLine = Console.ReadLine();
            }

            foreach (var personData in campers.OrderByDescending(p => p.Value.Count)
                .ThenBy(names => names.Key.Length))
            {
                int totalNights = 0;

                Console.WriteLine($"{personData.Key}: {campers[personData.Key].Count}");

                foreach (var campersAndNights in personData.Value)
                {
                    Console.WriteLine($"***{campersAndNights.Key}");
                    totalNights += campersAndNights.Value;
                }

                Console.WriteLine($"Total stay: {totalNights} nights");
            }
        }
    }
}
