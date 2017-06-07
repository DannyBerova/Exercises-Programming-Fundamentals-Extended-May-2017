
namespace _09.TriangleFormations
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                Console.WriteLine("Triangle is valid.");
            }
            else
            {
                Console.WriteLine("Invalid Triangle.");
                return;
            }
            
            if (a * a + b * b == c * c)
            {
                Console.WriteLine("Triangle has a right angle between sides a and b");
            }
            else if (b * b + c * c == a * a)
            {
                Console.WriteLine("Triangle has a right angle between sides b and c");
            }
            else if (c * c + a * a == b * b)
            {
                Console.WriteLine("Triangle has a right angle between sides a and c");
            }
            else if((a + b > c) && (a + c > b) && (b + c > a))
            {
                Console.WriteLine("Triangle has no right angles");
            }

        }
    }
}
