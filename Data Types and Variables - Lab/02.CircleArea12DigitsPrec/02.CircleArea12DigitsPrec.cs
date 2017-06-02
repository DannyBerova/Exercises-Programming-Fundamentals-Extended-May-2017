
namespace _02.CircleArea12DigitsPrec
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double radius = double.Parse(Console.ReadLine());
            double area = 3.1415926535897931 * radius * radius;

            Console.WriteLine($"{area:f12}");
        }
    }
}
