
namespace _04.SoftUniBeerPong
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var teamsData = new Dictionary<string, Dictionary<string, double>>();

            string inputLine = Console.ReadLine();

            while (inputLine != "stop the game")
            {
                string[] tokens = inputLine.Split('|');
                string player = tokens[0];
                string team = tokens[1];
                double playerPoints = double.Parse(tokens[2]);

                if (!teamsData.ContainsKey(team))
                {
                    teamsData.Add(team, new Dictionary<string, double>());
                }

                if (teamsData[team].Count < 3)
                {
                    if (!teamsData[team].ContainsKey(player))
                    {
                        teamsData[team].Add(player, playerPoints);
                    }
                }

                inputLine = Console.ReadLine();
            }

            int ranking = 1;

            foreach (var team in teamsData.OrderByDescending(x => x.Value.Values.Sum()))
            {
                if (team.Value.Count == 3)
                {
                    Console.WriteLine($"{ranking}. {team.Key}; Players:");
                    foreach (var player in team.Value.OrderByDescending(x => x.Value))
                    {
                        Console.WriteLine($"###{player.Key}: {player.Value}");
                    }
                    ranking++;
                }

            }
        }
    }
}