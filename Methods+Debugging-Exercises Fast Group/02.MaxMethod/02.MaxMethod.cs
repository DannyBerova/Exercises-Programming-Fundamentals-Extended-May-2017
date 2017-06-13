
namespace _02.MaxMethod
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int maxNumber = GetMax(a, b, c);
            Console.WriteLine(maxNumber);
        }

        private static int GetMax(int a, int b, int c)
        {
            return (Math.Max(Math.Max(a, b), c));
        }
    }
}
