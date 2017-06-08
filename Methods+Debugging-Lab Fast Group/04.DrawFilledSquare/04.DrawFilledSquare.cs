
namespace _04.DrawFilledSquare
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeaderFooter(n);
            for (int i = 0; i < n-2; i++)
            {
                PrintMiddleRow(n);
            }
            PrintHeaderFooter(n);
        }

        private static void PrintMiddleRow(int n)
        {
            Console.Write('-');
            for (int i = 1; i <= (2 * n-2)/2; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }

        private static void PrintHeaderFooter(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
    }
}
