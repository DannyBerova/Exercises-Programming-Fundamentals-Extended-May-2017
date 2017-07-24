
namespace _04.Websites
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Website
    {
        public string Host { get; set; }

        public string Domain { get; set; }

        public List<string> Queries { get; set; }
    }
    public class Program
    {
        public static void Main()
        {
            List<Website> websites = new List<Website>();

            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] tokens = inputLine.Split(new string[] { " | " },
                    StringSplitOptions.RemoveEmptyEntries);
                string host = tokens[0];
                string domain = tokens[1];

                Website newWebsite = new Website();
                newWebsite.Host = host;
                newWebsite.Domain = domain;

                if (tokens.Length > 2)
                {
                    List<string> queries = tokens[2].Split(new[] { ',' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                    newWebsite.Queries = queries;
                }

                websites.Add(newWebsite);

                inputLine = Console.ReadLine();
            }

            foreach (var site in websites)
            {
                Console.Write($"https://www.{site.Host}.{site.Domain}");

                if (site.Queries != null)
                {
                    Console.Write($"/query?=[{string.Join("]&[", site.Queries)}]");
                }

                Console.WriteLine();
            }
        }
    }
}
