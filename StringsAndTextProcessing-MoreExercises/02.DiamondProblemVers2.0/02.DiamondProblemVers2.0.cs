
namespace _02.DiamondProblemVers2._0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string line = Console.ReadLine();
            MatchCollection diamonds = Regex.Matches(line, @"<[^<>]+>");

            if (diamonds.Count > 0)
            {
                foreach (Match diamond in diamonds)
                {
                    MatchCollection validMatches = Regex.Matches(diamond.Value, @"\d+");
                    string carats = string.Empty;

                    foreach (Match validMatch in validMatches)
                    {
                        carats += validMatch.Value;
                    }

                    int sumOfCarats = 0;
                    for (int i = 0; i < carats.Length; i++)
                    {
                        sumOfCarats += int.Parse(carats[i].ToString());
                    }

                    Console.WriteLine($"Found {sumOfCarats} carat diamond");
                }
            }
            else
            {
                Console.WriteLine("Better luck next time");
            }
            
        }
    }
}
