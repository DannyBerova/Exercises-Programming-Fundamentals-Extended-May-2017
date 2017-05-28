
namespace _07.TrainingHallEquipment
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfItems = int.Parse(Console.ReadLine());

            double subtotal = 0;
            double currentMoney = budget;

            for (int products = 1; products <= numberOfItems; products++)
            {
                string productName = Console.ReadLine();
                double productPrice = double.Parse(Console.ReadLine());
                int productCount = int.Parse(Console.ReadLine());

                if (productCount > 1)
                {
                    Console.WriteLine($"Adding {productCount} {productName}s to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {productCount} {productName} to cart.");
                }
                currentMoney -= productCount * productPrice;
                subtotal += productCount * productPrice;
            }

            double moneyLeft = budget - subtotal;
            double neededMoney = subtotal - budget;

            Console.WriteLine($"Subtotal: ${subtotal:f2}");
            if (subtotal <= budget)
            {
                Console.WriteLine($"Money left: ${moneyLeft:f2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${neededMoney:f2} more.");

            }

        }
    }
}
