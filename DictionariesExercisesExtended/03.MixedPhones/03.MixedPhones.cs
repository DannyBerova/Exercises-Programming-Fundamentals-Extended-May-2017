
namespace _03.MixedPhones
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string[] line = Console.ReadLine()
                .Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var phoneNumbers = new SortedDictionary<string, long>();

            while (line[0] != "Over")
            {
                long phone = 0;
                string person = string.Empty;

                if (long.TryParse(line[0], out phone))
                {
                    person = line[2];
                }
                else
                {
                    person = line[0];
                    phone = long.Parse(line[2]);
                }

                if (!phoneNumbers.ContainsKey(person))
                {
                    phoneNumbers[person] = 0;
                }
                phoneNumbers[person] = phone;


                line = Console.ReadLine()
                .Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            foreach (var kvp in phoneNumbers)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
