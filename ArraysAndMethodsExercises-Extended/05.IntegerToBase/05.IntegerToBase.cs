
namespace _05.IntegerToBase
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());

            string resultString = ConvertIntegerToBase(number, toBase);
            Console.WriteLine(resultString);
        }

        private static string ConvertIntegerToBase(int number, int toBase)
        {
            string resultString = string.Empty;
            while (number != 0)
            {
                int remainder = number % toBase;
                number /= toBase;
                resultString = remainder + resultString;
            }

            return resultString;
        }
    }
}
