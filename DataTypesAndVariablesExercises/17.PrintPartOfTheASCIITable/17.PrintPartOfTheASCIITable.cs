
namespace _17.PrintPartOfTheASCIITable
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (char symbol = (char)start; symbol <= end; symbol++)
            {
                Console.Write(symbol + " ");
            }

        }
    }
}
