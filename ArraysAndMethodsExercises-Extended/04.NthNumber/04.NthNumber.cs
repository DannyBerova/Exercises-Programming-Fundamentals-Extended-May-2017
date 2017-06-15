
namespace _04.NthNumber
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());

            int digitNth = FindNthDigit(number, index);
            Console.WriteLine(digitNth);
        }

        private static int FindNthDigit(int number, int index)
        {
            int countIndex = 1;
            int currentDigit = 0;
            while (countIndex <= index )
            {
                currentDigit = number % 10;
                if (countIndex == index)
                {
                    break; 
                }
                number /= 10;
                countIndex++;
            }
            return currentDigit;
        }
    }
}
