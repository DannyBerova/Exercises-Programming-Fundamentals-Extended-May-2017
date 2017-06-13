
namespace _04.NumbersOfReversedOrder
{
    using System;

    public class Program
    {
        public static void Main()
        {
            decimal inputNumber = decimal.Parse(Console.ReadLine());
            decimal reversedNumber = ReverseOrderOfNumber(inputNumber);
            Console.WriteLine(reversedNumber);
        }

        private static decimal ReverseOrderOfNumber(decimal inputNumber)
        {
            string numberToString = inputNumber.ToString();
            string result = string.Empty;
            for (int i = numberToString.Length - 1; i >= 0; i--)
            {
                result += numberToString[i];
            }
            return decimal.Parse(result);
        }
    }
}
