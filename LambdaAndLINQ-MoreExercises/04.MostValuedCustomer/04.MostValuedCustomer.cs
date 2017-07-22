
namespace _04.MostValuedCustomer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var productsList = new Dictionary<string, double>();

            var clientsList = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();
            while (input != "Shop is open")
            {
                string[] tokens = input.Split();
                string product = tokens[0];
                double price = double.Parse(tokens[1]);

                productsList[product] = price;

                input = Console.ReadLine();
            }

            while (input != "Print")
            {
                string[] tokens = input
                    .Split(new string[] { ": ", ", " },
                    StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "Discount")
                {
                    var productsAfterDiscount = productsList
                        .OrderByDescending(p => p.Value)
                        .Take(3)
                        .Select(p => new KeyValuePair<string, double>(p.Key, p.Value * 0.9));

                    foreach (var productAfterDiscount in productsAfterDiscount)
                    {
                        productsList[productAfterDiscount.Key] = productAfterDiscount.Value;
                    }
                }
                else
                {
                    string client = tokens[0];
                    if (!clientsList.ContainsKey(client))
                    {
                        clientsList.Add(client, new List<string>());
                    }

                    for (int index = 1; index < tokens.Length; index++)
                    {
                        string boughtProduct = tokens[index];
                        if (productsList.ContainsKey(boughtProduct))
                        {
                            clientsList[client].Add(boughtProduct);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            var mostValuedClient = clientsList
                .OrderByDescending(d => d.Value.Sum(product => productsList[product]))
                .First();

            string name = mostValuedClient.Key;
            List<string> productsBought = mostValuedClient.Value;
            Console.WriteLine("Biggest spender: {0}", name);
            Console.WriteLine("^Products bought:");

            double totalSum = productsBought
                .Sum(p => productsList[p]);
            var orderedProducts = productsBought
                .Distinct()
                .OrderByDescending(p => productsList[p]);

            foreach (var product in orderedProducts)
            {
                Console.WriteLine("^^^{0}: {1:F2}",
                    product,
                    productsList[product]);
            }

            Console.WriteLine("Total: {0:F2}", totalSum);
        }
    }
}