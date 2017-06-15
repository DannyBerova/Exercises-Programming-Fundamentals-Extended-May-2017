
namespace _01.HelloName
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            PrintName(name);
        }

        private static void PrintName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
