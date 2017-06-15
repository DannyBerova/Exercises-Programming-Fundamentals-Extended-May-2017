
namespace _02.MinMethod
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int minNumber = GetMin(a, b);
            int minNumberFinal = GetMin(minNumber, c);

            Console.WriteLine(minNumberFinal);
        }

        private static int GetMin(int a, int b)
        {
            if (a <= b)
            {
                return a;
            }
            return b;
        }
    }
}
