using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var charsToRemove = new string[] { "@", "%", "$", "*" };
            Dictionary<string, Party> Data = new Dictionary<string, Party>();
            string input = Console.ReadLine();

            while (input != "Result")
            {
                foreach (var c in charsToRemove) { input = input.Replace(c, string.Empty); }
                string[] inputTokens = input.Split('|');
                if (inputTokens[0] == inputTokens[0].ToUpper())
                {
                    if (!Data.ContainsKey(inputTokens[0]))
                    {
                        Data.Add(inputTokens[0], new Party { Player = new TM { Name = inputTokens[1], score = int.Parse(inputTokens[2]) }, Points = int.Parse(inputTokens[2]) });
                    }
                    else
                    {
                        if (Data[inputTokens[0]].Player.Name == inputTokens[1])
                        {
                            Data[inputTokens[0]].Points -= Data[inputTokens[0]].Player.score;
                            Data[inputTokens[0]].Player.score = int.Parse(inputTokens[2]);
                        }

                        if (Data[inputTokens[0]].Player.score < int.Parse(inputTokens[2]))
                        {
                            Data[inputTokens[0]].Player.Name = inputTokens[1];
                        }
                        Data[inputTokens[0]].Points = int.Parse(inputTokens[2]);
                    }
                }
                else
                {
                    if (!Data.ContainsKey(inputTokens[1]))
                    {
                        Data.Add(inputTokens[1], new Party { Player = new TM { Name = inputTokens[0], score = int.Parse(inputTokens[2]) }, Points = int.Parse(inputTokens[2]) });
                    }
                    else
                    {
                        if (Data[inputTokens[1]].Player.Name == inputTokens[0])
                        {
                            Data[inputTokens[1]].Points -= Data[inputTokens[1]].Player.score;
                            Data[inputTokens[1]].Player.score = int.Parse(inputTokens[2]);
                        }

                        if (Data[inputTokens[1]].Player.score < int.Parse(inputTokens[2]))
                        {
                            Data[inputTokens[1]].Player.Name = inputTokens[0];
                        }
                        Data[inputTokens[1]].Points = int.Parse(inputTokens[2]);
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var ptp in Data.OrderByDescending(x => x.Value.Points).ThenByDescending(x => x.Value.Player.score))
            {
                Console.WriteLine("{0} => {1}", ptp.Key, ptp.Value.Points);
                Console.WriteLine("Most points scored by {0}", ptp.Value.Player.Name);
            }
           //foreach (var ptp in Data.OrderByDescending(x => x.Value.Points.Sum()))
           //{
           //    Console.WriteLine($"{ptp.Key} => {ptp.Value.Values.Sum()}");
           //
           //    foreach (var player in Data.Values.OrderByDescending(x => x.Points).Take(1))
           //    {
           //        Console.WriteLine($"Most points scored by {player.Points}");
           //    }
           //}
    }
    class Party
    {
        public TM Player { get; set; }
        public int Points { get; set; }
    }
    class TM
    {
        public string Name { get; set; }
        public int score { get; set; }
    }
}