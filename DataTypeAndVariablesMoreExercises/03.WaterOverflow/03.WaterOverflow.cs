
namespace _03.WaterOverflow
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = 255;
            int fittedLiters = 0;

            for (int i = 0; i < n; i++)
            {
                int litersAdded = int.Parse(Console.ReadLine());

                if (litersAdded <= capacity - fittedLiters)
                {
                    fittedLiters += litersAdded;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(fittedLiters);
        }
    }
}
