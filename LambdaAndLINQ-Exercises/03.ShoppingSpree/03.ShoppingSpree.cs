
namespace _03.ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var productsData = new Dictionary<string, double>();

            double budget = double.Parse(Console.ReadLine());

            string inputLine = Console.ReadLine();
            while (inputLine != "end")
            {
                string[] tokens =
                    inputLine.Split(' ');
                string product = tokens[0];
                double currentPrice = double.Parse(tokens[1]);

                if (productsData.ContainsKey(product))
                {
                    if (productsData[product] > currentPrice)
                    {
                        productsData[product] = currentPrice;
                    }
                }
                else
                {
                    productsData[product] = currentPrice;
                }

                inputLine = Console.ReadLine();
            }

            double totalSum = productsData.Sum(x => x.Value);

            if (totalSum <= budget)
            {
                var output = productsData
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key.Length);

                foreach (var item in output)
                {
                    Console.WriteLine("{0} costs {1:F2}", item.Key, item.Value);
                }
            }
            else
            {
                Console.WriteLine("Need more money... Just buy banichka");
            }
        }
    }
}
