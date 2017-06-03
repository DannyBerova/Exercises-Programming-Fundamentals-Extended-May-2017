
namespace _11.ConvertSpeedUnits
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float totalSeconds = (hours * 3600) + (minutes * 60) + seconds;
            float totalHours = totalSeconds / 3600.0f;
            float distanceInKilometers = distanceInMeters / 1000.0f;
            float distanceInMiles = distanceInMeters / 1609.0f;
            
            float speedInMetersPerSecond = distanceInMeters / totalSeconds;
            float speedInKilometersPerHours = distanceInKilometers / totalHours;
            float speedInMilesPerHour = distanceInMiles / (totalSeconds/3600.0f);

            Console.WriteLine($"{speedInMetersPerSecond}");
            Console.WriteLine($"{speedInKilometersPerHours}");
            Console.WriteLine($"{speedInMilesPerHour}");

        }
    }
}
