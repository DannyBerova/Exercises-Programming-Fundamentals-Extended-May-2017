
namespace _12.MasterNumber
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int endNum = int.Parse(Console.ReadLine());
            
            for (int i = 1; i < endNum; i++)
            {
                if (IsPalindrom(i) && (SumOfDigits(i) % 7 == 0) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool ContainsEvenDigit(int i)
        {
            int currentDigit = 0;
            while (i > 0)
            {
                currentDigit = i % 10;
                if (currentDigit % 2 == 0)
                {
                    return true;
                }
                i /= 10;
            }
            return false;
        }

        private static int SumOfDigits(int i)
        {
            int sumOfDigits = 0;
            while (i > 0)
            {
                sumOfDigits += i % 10;
                i /= 10;
            }
            return sumOfDigits;
        }

        private static bool IsPalindrom(int i)
        {
            int digit = 0;
            int num = i;
            int reversed = 0;
            while (num > 0)
            {
                digit = num % 10;
                reversed = reversed * 10 + digit;
                num /=  10;
            }
            if (i == reversed)
            {
                return true;
            }

            return false;
        }
    }
}
