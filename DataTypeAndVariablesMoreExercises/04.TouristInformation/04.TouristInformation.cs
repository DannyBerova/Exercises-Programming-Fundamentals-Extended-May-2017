
namespace _04.TouristInformation
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string imperialUnitToConvert = Console.ReadLine().ToLower();
            double valueToConvert = double.Parse(Console.ReadLine());
            double convertedValue = 1;
            string metricUnit = string.Empty;

            switch (imperialUnitToConvert)
            {
                case "miles":
                    convertedValue = valueToConvert * 1.6;
                    metricUnit = "kilometers";
                    break;
                case "inches":
                    convertedValue = valueToConvert * 2.54;
                    metricUnit = "centimeters";
                    break;
                case "feet":
                    convertedValue = valueToConvert * 30;
                    metricUnit = "centimeters";
                    break;
                case "yards":
                    convertedValue = valueToConvert * 0.91;
                    metricUnit = "meters";
                    break;
                case "gallons":
                    convertedValue = valueToConvert * 3.8;
                    metricUnit = "liters";
                    break;

                default:
                    break;
            }

            Console.WriteLine($"{valueToConvert} {imperialUnitToConvert} = {convertedValue:f2} {metricUnit}");
        }
    }
}
