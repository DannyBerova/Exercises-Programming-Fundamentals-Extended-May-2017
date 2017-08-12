
namespace _01.CharityMarathon
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            long marathonDays = long.Parse(Console.ReadLine());
            long runnersCount = long.Parse(Console.ReadLine());
            long avgLapsOfRunners = long.Parse(Console.ReadLine());
            long trackLenght = long.Parse(Console.ReadLine());
            long trackCapacity = long.Parse(Console.ReadLine());
            decimal donatedMoneyperKm = decimal.Parse(Console.ReadLine());

            long maximumRuners = trackCapacity * marathonDays;

            long totalRunersForMarathonDays = runnersCount;

            if (runnersCount > maximumRuners)
            {
                totalRunersForMarathonDays = maximumRuners;
            }

            decimal totalKilometers = (totalRunersForMarathonDays * avgLapsOfRunners * trackLenght) / 1000;
            decimal moneyRaised = totalKilometers * donatedMoneyperKm;

            Console.WriteLine($"Money raised: {moneyRaised:F2}");
        }
    }
}
