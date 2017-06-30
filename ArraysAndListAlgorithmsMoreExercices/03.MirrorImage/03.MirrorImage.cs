
namespace _03.MirrorImage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<string> elements = Console.ReadLine().Split().ToList();
            string line = Console.ReadLine();


            while (line != "Print")
            {
                int n = int.Parse(line);
                int left = elements.Count - n;
                List<string> leftSide = new List<string>();
                List<string> rightSide = new List<string>();
                string elementN = elements[n];

                if (n != 0 && n!= elements.Count - 1)
                {
                    for (int i = 0; i < n; i++)
                    {
                        leftSide.Add(elements[i]);
                    }
                    for (int i = n + 1; i < elements.Count; i++)
                    {
                        rightSide.Add(elements[i]);
                    }

                    leftSide.Reverse();
                    rightSide.Reverse();

                    elements.Clear();
                    elements.AddRange(leftSide);
                    elements.Add(elementN);
                    elements.AddRange(rightSide);


                }
                else if (n == 0)
                {
                    rightSide.AddRange(elements);
                    rightSide.RemoveAt(0);
                    rightSide.Reverse();
                    elements.Clear();
                    elements.Add(elementN);
                    elements.AddRange(rightSide);
                }
                else // if (n == elements.Count - 1)
                {
                    leftSide.AddRange(elements);
                    leftSide.RemoveAt(elements.Count - 1);
                    leftSide.Reverse();
                    elements.Clear();
                    elements.AddRange(leftSide);
                    elements.Add(elementN);
                }

                line = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
