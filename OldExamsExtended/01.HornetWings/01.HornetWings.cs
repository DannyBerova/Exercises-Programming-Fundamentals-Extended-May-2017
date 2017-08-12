
namespace _01.HornetWings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            long wingFlapsToDo = int.Parse(Console.ReadLine());
            double distancePerThousandsWingFlaps = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            double distance = (wingFlapsToDo / 1000.0) * distancePerThousandsWingFlaps;
            long secondsToFlap = wingFlapsToDo / 100;

            long wingFlapsToRest = (wingFlapsToDo / endurance) * 5;
            long totalTime = wingFlapsToRest + secondsToFlap;

            Console.WriteLine($"{distance:F2} m.");
            Console.WriteLine($"{totalTime} s.");

        }
    }
}
