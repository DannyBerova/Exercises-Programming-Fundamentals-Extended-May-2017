
namespace _03.Camel_sBack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<int> buildings = Console.ReadLine()
                .Split(' ').Select(int.Parse).ToList();
            int camelBackLenght = int.Parse(Console.ReadLine());

            int rounds = 0;

            while (camelBackLenght < buildings.Count)
            {
                buildings.RemoveAt(buildings.Count - 1);
                buildings.RemoveAt(0);
                rounds++;
            }

            if (rounds == 0)
            {
                Console.Write("already stable: ");
                Console.WriteLine(string.Join(" ", buildings));
            }
            else
            {
                Console.WriteLine($"{rounds} rounds");
                Console.Write("remaining: ");
                Console.WriteLine(string.Join(" ", buildings));

            }
        }
    }
}
