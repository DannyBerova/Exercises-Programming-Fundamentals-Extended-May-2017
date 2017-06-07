
namespace _05.DistanceOfTheStars
{
    using System;

    public class Program
    {
        public static void Main()
        {
            decimal onelightYearInKilometers = 9450000000000m;
            decimal distanceFromEarthToNearestStar = 4.22m * onelightYearInKilometers;
            decimal distanceToTheCenterOfMilkyWay = 26000m * onelightYearInKilometers;
            decimal diameterOfMilkyWay = 100000m * onelightYearInKilometers;
            decimal distanceFromEarthToBeyond = 46500000000m * onelightYearInKilometers;

            Console.WriteLine($"{distanceFromEarthToNearestStar:e2}");
            Console.WriteLine($"{distanceToTheCenterOfMilkyWay:e2}");
            Console.WriteLine($"{diameterOfMilkyWay:e2}");
            Console.WriteLine($"{distanceFromEarthToBeyond:e2}");
        }
    }
}
