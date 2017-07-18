
namespace _03.RecordUniqueNames
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            HashSet<string> uniqueNamesCollection = new HashSet<string>();

            int n = int.Parse(Console.ReadLine());

            for (int each = 0; each < n; each++)
            {
                string name = Console.ReadLine();

                uniqueNamesCollection.Add(name);
            }

            foreach (var name in uniqueNamesCollection)
            {
                Console.WriteLine($"{name}");
            }
        }
    }
}
