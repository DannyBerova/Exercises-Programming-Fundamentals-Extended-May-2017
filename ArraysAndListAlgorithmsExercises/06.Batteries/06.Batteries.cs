
namespace _06.Batteries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            double[] capacities = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            double[] usagePerHours = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            int hoursToTest = int.Parse(Console.ReadLine());
            string label = string.Empty;

            for (int battery = 0; battery < capacities.Length; battery++)
            {
                double drainedCapacity = usagePerHours[battery] * hoursToTest;
                double leftovers = capacities[battery] - drainedCapacity;
                if (leftovers > 0)
                {
                    double percentageLeft = leftovers * 100 / capacities[battery];
                    label = $"Battery {battery + 1}: {leftovers:F2} mAh ({percentageLeft:F2})%";
                    Console.WriteLine(label);
                }
                else
                {
                    int countHours = 0;
                    double filledCapacity = 0;
                    for (int hours = 0; hours < hoursToTest; hours++)
                    {
                        filledCapacity += usagePerHours[battery];
                        countHours++;
                        if (filledCapacity > capacities[battery])
                        {
                            label = $"Battery {battery + 1}: dead (lasted {countHours} hours)";
                            Console.WriteLine(label);
                            break;
                        }
                    }
                }

            }
        }
    }
}
