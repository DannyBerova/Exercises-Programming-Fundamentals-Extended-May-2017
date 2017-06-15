
namespace _18.BallisticTraining
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            double[] coordinates = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            string[] sequence = Console.ReadLine().ToLower().Split(' ');

            string[] nums = new string[(sequence.Length) / 2];
            int temp = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = sequence[temp];
                temp += 2;
            }
            double[] numsToDouble = nums.Select(double.Parse).ToArray();

            string[] commands = new string[(sequence.Length) / 2];
            temp = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                commands[i] = sequence[temp];
                temp += 2;
            }

            double targetX = coordinates[0];
            double targetY = coordinates[1];
            double startX = 0;
            double startY = 0;
            for (int i = 0; i < commands.Length; i++)
            {
                
                if (commands[i] == "up")
                {
                    startY += numsToDouble[i];
                }
                if (commands[i] == "down")
                {
                    startY -= numsToDouble[i];
                }
                if (commands[i] == "left")
                {
                    startX -= numsToDouble[i];
                }
                if (commands[i] == "right")
                {
                    startX += numsToDouble[i];
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
