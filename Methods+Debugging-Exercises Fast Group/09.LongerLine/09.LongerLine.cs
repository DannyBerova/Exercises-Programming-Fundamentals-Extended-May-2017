
namespace _09.LongerLine
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            var distanceOne = CalculateDistanceBetweenPoints(x1, y1, x2, y2);
            var distanceTwo = CalculateDistanceBetweenPoints(x3, y3, x4, y4);

            if (distanceOne > distanceTwo)
            {
                if (IsFirstPointCloserToCenter(x1, y1, x2, y2))
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");

                }

            }
            else
            {
                if (IsFirstPointCloserToCenter(x3, y3, x4, y4))
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");

                }
            }

        }

        private static bool IsFirstPointCloserToCenter(double x1, double y1, double x2, double y2)
        {
            var distanceOne = CalculateDistanceBetweenPoints(x1, y1, 0, 0);
            var distanceTwo = CalculateDistanceBetweenPoints(x2, y2, 0, 0);

            if (distanceOne <= distanceTwo)
            {
                return true;
            }

            return false;
        }

        private static double CalculateDistanceBetweenPoints(double x1, double y1, double x2, double y2)
        {
            var distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + (Math.Pow(y2 - y1, 2)));
            return distance;
        }
    }
}
