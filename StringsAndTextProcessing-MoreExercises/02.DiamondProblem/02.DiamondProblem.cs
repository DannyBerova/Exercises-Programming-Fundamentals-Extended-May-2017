
namespace _02.DiamondProblem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string line = Console.ReadLine();
            List<int> values = new List<int>();

            while (true)
            {
                int startIndex = line.IndexOf('<');
                int endIndex = line.IndexOf('>');

                if (startIndex == -1 || endIndex == -1 || line.Length == 0)
                {
                    break;
                }

                if (startIndex > endIndex)
                {
                    line = line.Substring(endIndex + 1);
                    startIndex = line.IndexOf('<');
                    endIndex = line.IndexOf('>');
                    if (startIndex == -1 || endIndex == -1)
                    {
                        break;
                    }
                }

                string currentDiamond = line
                    .Substring(startIndex, endIndex + 1 - startIndex);

                int carat = 0;
                if (currentDiamond.Contains('<'))
                {
                    int newStartIndex = currentDiamond.LastIndexOf('<');
                    currentDiamond = currentDiamond.Substring(newStartIndex);
                }

                if (currentDiamond.Length > 0)
                {
                    foreach (var ch in currentDiamond)
                    {
                        if (ch > 47 && ch < 58)
                        {
                            carat += ch - 48;
                        }
                    }

                    values.Add(carat);
                }

                line = line.Substring(endIndex + 1);
            }

            if (values.Count == 0)
            {
                Console.WriteLine("Better luck next time");
            }
            else
            {
                foreach (var carats in values)
                {
                    Console.WriteLine($"Found {carats} carat diamond");
                }
            }
        }
    }
}
