
namespace _17.Altitude
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] commands = Console.ReadLine().Split(' ');

            long altitude = Convert.ToInt64(commands[0]);

            for (int i = 1; i < commands.Length; i++)
            {
                if (commands[i] == "up")
                {
                    altitude += Convert.ToInt64(commands[i + 1]);
                }
                if (commands[i] == "down")
                {
                    altitude -= Convert.ToInt64(commands[i + 1]);
                }
                if (altitude <= 0)
                {
                    Console.WriteLine("crashed");
                    return;
                }
            }

            Console.WriteLine($"got through safely. current altitude: {altitude}m");
        }
    }
}
