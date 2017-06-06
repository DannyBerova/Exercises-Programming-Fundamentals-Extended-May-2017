
namespace _02.CirclePerimeter12dig
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double radius = double.Parse(Console.ReadLine());
            double area = 3.1415926535897931 * radius * 2;

            Console.WriteLine($"{area:f12}");
        }
    }
}
