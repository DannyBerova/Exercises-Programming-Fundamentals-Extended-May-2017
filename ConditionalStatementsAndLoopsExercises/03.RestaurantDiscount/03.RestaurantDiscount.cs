
namespace _03.RestaurantDiscount
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int groupSize = int.Parse(Console.ReadLine());
            string packageType = Console.ReadLine();

            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            double hallPrice = 1;
            string hallName = "";

            if (groupSize <= 50)
            {
                hallName = "Small Hall";
                hallPrice = 2500;
            }
            else if (groupSize <= 100)
            {
                hallName = "Terrace";
                hallPrice = 5000;
            }
            else if (groupSize <= 120)
            {
                hallName = "Great Hall";
                hallPrice = 7500;
            }

            double pakagePrice = 1;
            double percentDiscount = 1;

            switch (packageType)
            {
                case "Normal":
                    pakagePrice = 500;
                    percentDiscount = 0.95;
                    break;
                case "Gold":
                    pakagePrice = 750;
                    percentDiscount = 0.90;
                    break;
                case "Platinum":
                    pakagePrice = 1000;
                    percentDiscount = 0.85;
                    break;
                default:
                    break;
            }

            double totalPrice = (hallPrice + pakagePrice) * percentDiscount;
            double pricePerPerson = totalPrice / groupSize;

            Console.WriteLine($"We can offer you the {hallName}");
            Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
        }
    }
}
