
namespace _08.TravelingAtLightSpeed
{
    using System;

    public class Program
    {
        public static void Main()
        {
            decimal lightYearsToConvert = decimal.Parse(Console.ReadLine());

            decimal lightYear = 9450000000000m;
            decimal speedOfLightInSecToKm = 300000m;

            decimal totalKilometers = lightYearsToConvert * lightYear;
            decimal totalSeconds = totalKilometers / speedOfLightInSecToKm;
            decimal weeks = totalSeconds / 604800;
            decimal weeksLeftovers = totalSeconds % 604800;
            decimal days = weeksLeftovers / (60 * 60 * 24);
            decimal daysLeftovers = weeksLeftovers % (60 * 60 * 24);
            decimal hours = daysLeftovers / 3600;
            decimal hoursLeftovers = daysLeftovers % 3600;
            decimal minutes = hoursLeftovers / 60;
            decimal seconds = hoursLeftovers % 60;


            Console.WriteLine($"{Math.Floor(weeks)} weeks");
            Console.WriteLine($"{Math.Floor(days)} days");
            Console.WriteLine($"{Math.Floor(hours)} hours");
            Console.WriteLine($"{Math.Floor(minutes)} minutes");
            Console.WriteLine($"{Math.Floor(seconds)} seconds");



        }
    }
}
