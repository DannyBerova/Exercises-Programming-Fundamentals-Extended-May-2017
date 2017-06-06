
namespace _10.SumOfChars
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int sumOfChars = 0;
            for (int i = 0; i < n; i++)
            {
                char inputChar = char.Parse(Console.ReadLine());
                sumOfChars += inputChar;
            }
            Console.WriteLine($"The sum equals: {sumOfChars}");
        }
    }
}
