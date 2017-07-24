
namespace _05.Boxes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Point
    {
        public int X { get; set; }

        public int Y { get; set; }

        
    }

    class Box
    {
        public Point UpperLeft { get; set; }

        public Point UpperRight { get; set; }

        public Point BottomLeft { get; set; }

        public Point BottomRight { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }

        public double CalculatePerimeter(double width, double height)
        {
            double perimeter = (2 * width) + (2 * height);
            return perimeter;
        }

        public double CalculateArea(double width, double height)
        {
            double area = width * height;
            return area;
        }
    }
    public class Program
    {
        public static void Main()
        {
            List<Box> boxes = new List<Box>();

            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                int[] tokens = inputLine.Split(new [] { ' ', '|', ':' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                Point upperLeft = new Point();
                upperLeft.X = tokens[0];
                upperLeft.Y = tokens[1];

                Point upperRight = new Point();
                upperRight.X = tokens[2];
                upperRight.Y = tokens[3];

                Point bottomLeft = new Point();
                bottomLeft.X = tokens[4];
                bottomLeft.Y = tokens[5];

                Point bottomRight = new Point();
                bottomRight.X = tokens[6];
                bottomRight.Y = tokens[7];

                Box newBox = new Box();
                newBox.UpperLeft = upperLeft;
                newBox.UpperRight = upperRight;
                newBox.BottomLeft = bottomLeft;
                newBox.BottomRight = bottomRight;

                double width = CalcDistance(newBox.UpperLeft, newBox.UpperRight);
                double height = CalcDistance(newBox.UpperLeft, newBox.BottomLeft);
                newBox.Width = width;
                newBox.Height = height;

                boxes.Add(newBox);

                inputLine = Console.ReadLine();
            }

            foreach (var box in boxes)
            {
                Console.WriteLine($"Box: {box.Width}, {box.Height}");
                Console.WriteLine($"Perimeter: {box.CalculatePerimeter(box.Width, box.Height)}");
                Console.WriteLine($"Area: {box.CalculateArea(box.Width, box.Height)}");
            }
        }

        private static double CalcDistance(Point firstPoint, Point secondPoint)
        {
            double diffX = Math.Pow(firstPoint.X - secondPoint.X, 2);
            double diffY = Math.Pow(firstPoint.Y - secondPoint.Y, 2);
            double distance = Math.Sqrt(diffX + diffY);

            return distance;
        }
    }
}
