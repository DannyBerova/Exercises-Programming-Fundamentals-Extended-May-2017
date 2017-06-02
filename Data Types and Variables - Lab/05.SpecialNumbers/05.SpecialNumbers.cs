
namespace _05.SpecialNumbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int number = 1; number <= n; number++)
            {
                int sumOfDigits = 0;
                int currentNumber = number;

                while(currentNumber > 0)
                {
                    sumOfDigits += currentNumber % 10;
                    currentNumber = currentNumber / 10;
                }

                bool isSpecial = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);

                Console.WriteLine($"{number} -> {isSpecial}");
            }
        }
    }
}
