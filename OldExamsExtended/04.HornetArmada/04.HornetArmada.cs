
namespace _04.HornetArmada
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var soldiers = new Dictionary<string, Dictionary<string, long>>();
            var legionActivity = new Dictionary<string, long>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(new[] { '=', '-', '>', ':', ' ' }
                    , StringSplitOptions.RemoveEmptyEntries);

                long activity = long.Parse(tokens[0]);
                string legionName = tokens[1];
                string soldierType = tokens[2];
                long count = long.Parse(tokens[3]);

                if (!legionActivity.ContainsKey(legionName))
                {
                    legionActivity.Add(legionName, activity);
                    soldiers.Add(legionName, new Dictionary<string, long>());
                }

                if (!soldiers[legionName].ContainsKey(soldierType))
                {
                    soldiers[legionName][soldierType] = 0;
                }

                if (legionActivity[legionName] < activity)
                {
                    legionActivity[legionName] = activity;
                }

                soldiers[legionName][soldierType] += count;
            }

            string[] commands = Console.ReadLine().Split('\\');

            if (commands.Length == 1)
            {
                string soldType = commands[0];
                foreach (var legion in legionActivity.OrderByDescending(l => l.Value))
                {
                    if (soldiers[legion.Key].ContainsKey(soldType))
                    {
                        Console.WriteLine($"{legion.Value} : {legion.Key}");
                    }
                }
            }
            else
            {
                int searchedActivity = int.Parse(commands[0]);
                string type = commands[1];

                foreach (var legion in soldiers.Where(l => l.Value.ContainsKey(type))
                    .OrderByDescending(l => l.Value[type]))
                {
                    if (legionActivity[legion.Key] < searchedActivity)
                    {
                        Console.WriteLine($"{legion.Key} -> {legion.Value[type]}");
                    }
                }
            }
        }
    }
}
