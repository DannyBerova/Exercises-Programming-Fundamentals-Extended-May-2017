
namespace _05.LambadaExpressions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var lambadaExpressions = new Dictionary<string, string>();

            string inputLine = Console.ReadLine();

            while (inputLine != "lambada")
            {
                var tokens = inputLine
                    .Split(" =>".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (tokens.Count > 1)
                {
                    string key = tokens[0];
                    string value = tokens[1];

                    if (!lambadaExpressions.ContainsKey(key));
                    {
                        lambadaExpressions[key] = string.Empty;
                    }
                    lambadaExpressions[key] = value;
                }
                else
                {
                    lambadaExpressions = lambadaExpressions
                        .ToDictionary(e => e.Key, e => e.Key + "." + e.Value);
                }

                inputLine = Console.ReadLine();
            }

            foreach (var lambadaExpression in lambadaExpressions)
            {
                Console.WriteLine("{0} => {1}",
                    lambadaExpression.Key, 
                    lambadaExpression.Value);
            }
        }
    }
}
