
namespace _04.DistanceBetweenPoints
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Point
    {
        public int X { get; set; }

        public int Y { get; set; }
    }
    
    public class Program
    {
        public static void Main()
        {
            Point firstPoint = ReadPoint();
            Point secondPoint = ReadPoint();

            var result = CalcDistance(firstPoint, secondPoint);

            Console.WriteLine($"{result:f3}");
        }
        public static Point ReadPoint()
        {
            var pointAsString = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Point point = new Point();
            point.X = pointAsString[0];
            point.Y = pointAsString[1];

            return point;
        }

        public static double CalcDistance(Point firstPoint, Point secondPoint)
        {
            double diffX = Math.Pow(firstPoint.X - secondPoint.X, 2);
            double diffY = Math.Pow(firstPoint.Y - secondPoint.Y, 2);

            double distance = Math.Sqrt(diffX + diffY);

            return distance;
        }
    }
}
