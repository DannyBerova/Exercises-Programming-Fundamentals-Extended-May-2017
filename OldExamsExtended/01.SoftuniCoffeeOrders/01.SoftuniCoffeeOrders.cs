
namespace _01.SoftuniCoffeeOrders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    public class Program
    {
        public static void Main()
        {
            int countOfOrders = int.Parse(Console.ReadLine());

            decimal totalPrice = 0m;

            for (int i = 0; i < countOfOrders; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime
                    .ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsulesCount = long.Parse(Console.ReadLine());

                decimal orderPrice = 
                    (DateTime.DaysInMonth(orderDate.Year, orderDate.Month) * capsulesCount * pricePerCapsule);

                totalPrice += orderPrice;

                Console.WriteLine($"The price for the coffee is: ${orderPrice:F2}");
            }

            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
