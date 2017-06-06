
namespace _05.WeatherForecast
{
    using System;

    public class Program
    {
        public static void Main()
        {
            try
            {
                long inputNum = long.Parse(Console.ReadLine());

                

                if (inputNum >= sbyte.MinValue && inputNum <= sbyte.MaxValue)
                {
                    Console.WriteLine("Sunny");
                }
                else if (inputNum >= int.MinValue && inputNum <= int.MaxValue)
                {
                    Console.WriteLine("Cloudy");
                }
                else
                {
                    Console.WriteLine("Windy");
                }

            }
            catch (Exception)
            {

                Console.WriteLine("Rainy"); ;
            }
        }
    }
}
