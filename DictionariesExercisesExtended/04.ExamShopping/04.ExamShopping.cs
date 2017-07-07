
namespace _04.ExamShopping
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string[] line = Console.ReadLine()
                .Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var shopInventory = new Dictionary<string, int>();

            while (line[0] != "shopping")
            {
                string product = line[1];
                int quantity = int.Parse(line[2]);

                if (!shopInventory.ContainsKey(product))
                {
                    shopInventory[product] = 0;
                }
                shopInventory[product] += quantity;

                line = Console.ReadLine()
                .Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
            
            line = Console.ReadLine()
                .Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            while (line[0] != "exam")
            {
                string product = line[1];
                int quantity = int.Parse(line[2]);

                if (!shopInventory.ContainsKey(product))
                {
                    Console.WriteLine($"{product} doesn't exist");
                }
                else
                {
                    if (shopInventory[product] > 0)
                    {
                        shopInventory[product] -= quantity;
                    }
                    else if (shopInventory[product] <= 0)
                    {
                        shopInventory[product] = 0;
                        Console.WriteLine($"{product} out of stock");
                    }
                }

                line = Console.ReadLine()
                .Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            shopInventory = shopInventory
                .Where(v => v.Value > 0)
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var item in shopInventory)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
