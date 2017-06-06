
namespace _12.BeerKegs
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double biggestVolume = double.MinValue;
            string biggestKeg = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string modelOfKeg = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double kegVolume = Math.PI * radius * radius * height;
                if (kegVolume > biggestVolume)
                {
                    biggestVolume = kegVolume;
                    biggestKeg = modelOfKeg;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
