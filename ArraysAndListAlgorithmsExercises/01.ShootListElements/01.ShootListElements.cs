
namespace _01.ShootListElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string inputLine = string.Empty;
            List<int> integers = new List<int>();
            int lastRemovedInt = 0;

            while (true)
            {
                inputLine = Console.ReadLine();

                if (inputLine == "stop")
                {
                    break;
                }

                AddingIntegersToList(inputLine, integers);

                if (inputLine == "bang")
                {
                    if (integers.Count == 0)
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {lastRemovedInt}");
                        return;
                    }
                    else
                    {
                        

                        double avg = integers.Average();
                        for (int i = 0; i < integers.Count; i++)
                        {

                            if (integers[i] < avg)
                            {
                                lastRemovedInt = integers[i];
                                Console.WriteLine($"shot {lastRemovedInt}");
                                integers.RemoveAt(i);

                                for (int j = 0; j < integers.Count; j++)
                                {
                                    integers[j]--;
                                }
                                break;
                            }
                            if (integers.Count == 1)
                            {
                                lastRemovedInt = integers[0];
                                Console.WriteLine($"shot {lastRemovedInt}");
                                integers.RemoveAt(0);

                            }
                        }
                    }
                }
            }

            if (integers.Count > 0)
            {
                Console.WriteLine("survivors: {0}", string.Join(" ", integers));
            }
            else
            {
                Console.WriteLine($"you shot them all. last one was {lastRemovedInt}");
            }
        }

        static void AddingIntegersToList(string inputLine, List<int> integers)
        {
            if (inputLine != "bang" && inputLine != "stop")
            {
                int number = int.Parse(inputLine);
                integers.Insert(0, number);
            }
        }
    }
}
