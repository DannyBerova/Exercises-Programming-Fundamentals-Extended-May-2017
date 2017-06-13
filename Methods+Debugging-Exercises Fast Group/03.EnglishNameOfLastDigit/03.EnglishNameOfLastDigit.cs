
namespace _03.EnglishNameOfLastDigit
{
    using System;

    public class Program
    {
        public static void Main()
        {
            long inputNumber = Math.Abs(long.Parse(Console.ReadLine()));
            long lastDigit = GetLastDigitFromInputNumber(inputNumber);
            string nameOfDigit = PrintEnglishNameOfLastDigit(lastDigit);
            Console.WriteLine(nameOfDigit);
        }

        private static string PrintEnglishNameOfLastDigit(long lastDigit)
        {
            string nameOfDigit = string.Empty;
            if (lastDigit == 0)
            {
                nameOfDigit = "zero";
            }
            else if (lastDigit == 1)
            {
                nameOfDigit = "one";
            }
            else if (lastDigit == 2)
            {
                nameOfDigit = "two";
            }
            else if (lastDigit == 3)
            {
                nameOfDigit = "three";
            }
            else if (lastDigit == 4)
            {
                nameOfDigit = "four";
            }
            else if (lastDigit == 5)
            {
                nameOfDigit = "five";
            }
            else if (lastDigit == 6)
            {
                nameOfDigit = "six";
            }
            else if (lastDigit == 7)
            {
                nameOfDigit = "seven";
            }
            else if (lastDigit == 8)
            {
                nameOfDigit = "eight";
            }
            else if (lastDigit == 9)
            {
                nameOfDigit = "nine";
            }

            return nameOfDigit;
        }

        private static long GetLastDigitFromInputNumber(long inputNumber)
        {
            return inputNumber % 10;
        }
    }
}
