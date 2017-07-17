
namespace _04.Shellbound
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var shellsOfVladi = new Dictionary<string, HashSet<long>>();
            var regionAndSize = Console.ReadLine();

            while (regionAndSize != "Aggregate")
            {
                var ofParts = regionAndSize.Split(' ').ToArray();
                var region = ofParts[0];
                var size = long.Parse(ofParts[1]);

                if (!shellsOfVladi.ContainsKey(region))
                {
                    shellsOfVladi[region] = new HashSet<long>();
                }
                shellsOfVladi[region].Add(size);
                regionAndSize = Console.ReadLine();
            }

            foreach (var region in shellsOfVladi)
            {
                var sum = region.Value.Sum();
                var result = sum - sum / region.Value.Count;
                Console.WriteLine
                    ($"{region.Key} -> {string.Join(", ", region.Value)} ({result})");
            }
        }
    }
}
