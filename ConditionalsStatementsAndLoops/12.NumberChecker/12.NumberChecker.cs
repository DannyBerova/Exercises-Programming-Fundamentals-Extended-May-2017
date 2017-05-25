
namespace _12.NumberChecker
{
    using System;

    public class Program
    {
        public static void Main()
        {
            try
            {
                var input = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
