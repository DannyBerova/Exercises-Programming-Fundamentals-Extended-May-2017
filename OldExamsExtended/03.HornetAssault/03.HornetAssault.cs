
namespace _03.HornetAssault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            List<long> hives = Console.ReadLine().Split().Select(long.Parse).ToList();
            List<long> hornets = Console.ReadLine().Split().Select(long.Parse).ToList();

            for (int i = 0; i < hives.Count; i++)
            {
                if (hornets.Count <= 0)
                {
                    break;
                }

                if (hornets.Sum() > hives[i])
                {
                    hives.RemoveAt(i);
                    i--;
                }
                else
                {
                    hives[i] -= hornets.Sum();
                    hornets.RemoveAt(0);
                }
            }

            if (hives.Where(h => h > 0).ToList().Count > 0)
            {
                Console.WriteLine(string.Join(" ", hives.Where(h => h > 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }

        }
    }
}
