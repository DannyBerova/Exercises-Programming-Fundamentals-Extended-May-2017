
namespace _05.RoundingNumbers
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            double[] doublesArray = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            double[] resultDoubles = (double[])doublesArray.Clone();
            resultDoubles = doublesArray
                .Select(element => Math.Round(element, MidpointRounding.AwayFromZero))
                .ToArray();

            for (int i = 0; i < resultDoubles.Length; i++)
            {
                Console.WriteLine($"{doublesArray[i]} => {resultDoubles[i]}");
            }
        }
    }
}
