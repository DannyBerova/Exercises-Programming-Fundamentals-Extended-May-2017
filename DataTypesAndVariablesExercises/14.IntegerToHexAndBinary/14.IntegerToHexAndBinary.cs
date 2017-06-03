
namespace _14.IntegerToHexAndBinary
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int decimalNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(decimalNumber, 16).ToUpper());
            Console.WriteLine(Convert.ToString(decimalNumber, 2).ToUpper());

        }
    }
}
