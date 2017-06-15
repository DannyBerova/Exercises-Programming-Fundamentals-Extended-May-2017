
namespace _18.Ballistic2._0
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] coordinates = Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToArray();
            string[] sequence = Console.ReadLine().Split(' ');

            long targetX = coordinates[0];
            long targetY = coordinates[1];
            long startX = 0;
            long startY = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] == "up")
                {
                    startY += Convert.ToInt64(sequence[i + 1]);
                }
                if (sequence[i] == "down")
                {
                    startY -= Convert.ToInt64(sequence[i + 1]);
                }
                if (sequence[i] == "left")
                {
                    startX -= Convert.ToInt64(sequence[i + 1]);
                }
                if (sequence[i] == "right")
                {
                    startX += Convert.ToInt64(sequence[i + 1]);
                }
            }

            Console.WriteLine($"firing at [{startX}, {startY}]");

            if (targetX == startX && targetY == startY)
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }
        }
    }
}