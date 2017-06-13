
namespace _11.GeometryCalculator
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string typeOfFigure = Console.ReadLine().ToLower();
            double area = CalculateFigureArea(typeOfFigure);
            Console.WriteLine($"{area:f2}");

           
        }

        private static double CalculateFigureArea(string typeOfFigure)
        {
            double area = 0;
            if (typeOfFigure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                return area = (side * height) / 2;
            }
            else if (typeOfFigure == "square")
            {
                double side = double.Parse(Console.ReadLine());

                return area = side * side;
            }
            else if (typeOfFigure == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                return area = width * height;
            }
            else if (typeOfFigure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());

                return area = 3.1415926535897931 * (radius * radius);
            }
            return area;
        }
    }
}
