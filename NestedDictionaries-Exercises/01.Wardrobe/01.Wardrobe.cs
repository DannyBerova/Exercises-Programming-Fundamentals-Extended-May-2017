
namespace _01.Wardrobe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();
            int itemCounter = int.Parse(Console.ReadLine());

            for (int count = 0; count < itemCounter; count++)
            {
                var currentDataClothesByColor = Console.ReadLine()
                    .Split(new[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);

                var color = currentDataClothesByColor[0];
                var clothes = currentDataClothesByColor.Skip(1);

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }

                foreach (var item in clothes)
                {
                    if (!wardrobe[color].ContainsKey(item))
                    {
                        wardrobe[color][item] = 0;
                    }
                    wardrobe[color][item]++;
                }
            }

            var colorAndItemPairToFind = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var colorToFind = colorAndItemPairToFind[0];
            var itemToFind = colorAndItemPairToFind[1];

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var cloth in color.Value)
                {
                    if (color.Key == colorToFind && cloth.Key == itemToFind)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                        continue;
                    }
                    Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                }
            }
        }
    }
}