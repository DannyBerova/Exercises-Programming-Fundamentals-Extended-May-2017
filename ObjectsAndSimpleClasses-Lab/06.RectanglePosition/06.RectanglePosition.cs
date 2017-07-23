
namespace _06.RectanglePosition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Rectangle firstRect = new Rectangle().ReadRectangle();
            Rectangle secondRect = new Rectangle().ReadRectangle();

            Console.WriteLine(firstRect.IsInside(secondRect) ? "Inside" : "Not inside");
        }
    }
    class Rectangle
    {
        public int Left { get; set; }

        public int Top { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int CalculateArea()
        {
            return Width * Height;
        }

        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }

        public int Right
        {
            get
            {
                return Left + Width;
            }
        }

        public bool IsInside(Rectangle rect)
        {
            bool IsInsideLeft = rect.Left <= Left;
            bool IsInsideRight = rect.Right >= Right;
            bool IsInsideTop = rect.Top <= Top;
            bool IsInsideBottom = rect.Bottom >= Bottom;

            return IsInsideLeft && IsInsideRight && IsInsideTop && IsInsideBottom;
        }

        public Rectangle ReadRectangle()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Rectangle rectangle = new Rectangle
            {
                Left = input[0],
                Top = input[1],
                Width = input[2],
                Height = input[3]
            };
            return rectangle;
        }
    }
}
