
namespace _07.FromTerabytesToBits
{
    using System;

    public class Program
    {
        public static void Main()
        {
            decimal terabytes = decimal.Parse(Console.ReadLine());

            decimal bites = terabytes * 1024 * 1024 * 1024 * 1024 * 8;
            Console.WriteLine(Math.Round(bites));
        }
    }
}
