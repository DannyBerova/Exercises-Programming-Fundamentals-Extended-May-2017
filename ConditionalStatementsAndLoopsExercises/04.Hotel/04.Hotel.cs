
namespace _04.Hotel
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            double studioPrice = 1;
            double doublePrice = 1;
            double suitePrice = 1;
            double discount = 1;

            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                doublePrice = 65;
                suitePrice = 75;
                if (nightsCount > 7)
                {
                    studioPrice = studioPrice * 0.95;
                }
               
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 60;
                doublePrice = 72;
                suitePrice = 82;
                if (nightsCount > 14)
                {
                    doublePrice = doublePrice * 0.90;
                }
                
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studioPrice = 68;
                doublePrice = 77;
                suitePrice = 89;
                if (nightsCount > 14)
                {
                    suitePrice = suitePrice * 0.85;
                }
            }

            double totalPriceStudio = studioPrice * nightsCount;
            double totalPriceDouble = doublePrice * nightsCount;
            double totalPriceSuite = suitePrice * nightsCount;

            if (nightsCount > 7 && (month == "September" || month == "October"))
            {
                totalPriceStudio = studioPrice * nightsCount - studioPrice;
            }

            Console.WriteLine($"Studio: {totalPriceStudio:F2} lv.");
            Console.WriteLine($"Double: {totalPriceDouble:F2} lv.");
            Console.WriteLine($"Suite: {totalPriceSuite:F2} lv.");

        }
    }
}
