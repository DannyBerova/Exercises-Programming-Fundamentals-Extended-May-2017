
namespace _02.AppendLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<string> tokens = Console.ReadLine()
                .Split('|')                
                .ToList();
            string result = string.Empty;

            for (int i = tokens.Count - 1; i >= 0; i--)
            {
                string element = tokens[i];
                var parts = element
                    .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

                for (int append = 0; append < parts.Count; append++)
                {
                    result += parts[append] + " ";
                }
            }

            Console.WriteLine(result);
        }
    }
}
