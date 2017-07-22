
namespace _07.LINQuistics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var collections = new Dictionary<string, List<string>>();

            string inputLine = Console.ReadLine();

            while (inputLine != "exit")
            {
                string[] inputTokens = inputLine
                .Split(new string[] { ".", "()" },
                StringSplitOptions.RemoveEmptyEntries);

                string collection = inputTokens[0];
                string[] methods = inputTokens.Skip(1).ToArray();
                int number = 0;

                if (methods.Length > 0)
                {
                    foreach (var method in methods)
                    {
                        if (!collections.ContainsKey(collection))
                        {
                            collections.Add(collection, new List<string>());
                        }

                        if (!collections[collection].Contains(method))
                        {
                            collections[collection].Add(method);
                        }
                    }
                }
                else if (int.TryParse(collection, out number))
                {
                    if (collections.Count > 0)
                    {
                        var richestCollection = collections
                            .OrderByDescending(coll => coll.Value.Count)
                            .First();

                        var outputMethods = richestCollection.Value
                            .OrderBy(m => m.Length)
                            .Take(number)
                            .ToArray();

                        foreach (var met in outputMethods)
                        {
                            Console.WriteLine("* {0}", met);
                        }

                    }
                }
                else if (collections.ContainsKey(collection))
                {
                    var outputMethods = collections[collection]
                        .OrderByDescending(m => m.Length)
                        .ThenByDescending(m => m.Distinct().Count())
                        .ToArray();

                    foreach (var met in outputMethods)
                    {
                        Console.WriteLine("* {0}", met);
                    }
                }


                inputLine = Console.ReadLine();
            }

            string[] lastLine = Console.ReadLine().Split();
            string methodNeeded = lastLine[0];
            string selection = lastLine[1];

            var outputCollections = collections
                .Where(c => c.Value.Contains(methodNeeded))
                .OrderByDescending(c => c.Value.Count)
                .ThenByDescending(c => c.Value
                    .OrderBy(m => m.Length)
                    .First().Length)
                .ToArray();

            foreach (var collData in outputCollections)
            {
                Console.WriteLine(collData.Key);

                var methods = collData.Value;
                var outputMethods = methods
                        .OrderByDescending(m => m.Length)
                        .ToArray();

                if (selection == "all")
                {
                    foreach (var collMethod in outputMethods)
                    {
                        Console.WriteLine("* {0}", collMethod);
                    }
                }


            }
        }
    }
}
