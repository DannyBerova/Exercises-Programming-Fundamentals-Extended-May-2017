
namespace _10.CubeProperties
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            double result = CalculateParameterNeeded(side, parameter);
            Console.WriteLine($"{result:f2}");
        }

        private static double CalculateParameterNeeded(double side, string parameter)
        {
            double result = 0;
            if (parameter == "face")
            {
                result = Math.Sqrt(Math.Pow(side, 2) * 2);
            }
            else if (parameter == "space")
            {
                result = Math.Sqrt(Math.Pow(side, 2) * 3);
            }
            else if (parameter == "volume")
            {
                result = Math.Pow(side, 3);
            }
            else if (parameter == "area")
            {
                result = Math.Pow(side, 2) * 6;
            }

            return result;
        }
    }
}
