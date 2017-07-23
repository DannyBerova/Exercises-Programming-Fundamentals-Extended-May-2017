
namespace _01.DayOfWeek
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    public class Program
    {
        public static void Main()
        {
            var dateAsString = Console.ReadLine();
            DateTime date = DateTime.ParseExact(
                dateAsString, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
