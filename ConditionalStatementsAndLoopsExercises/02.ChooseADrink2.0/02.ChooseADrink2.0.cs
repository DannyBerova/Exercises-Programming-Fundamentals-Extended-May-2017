
namespace _02.ChooseADrink2._0
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0;
            string baverage = "";

            switch (profession)
            {
                case "Athlete":
                    baverage = "Water";
                    price = 0.70;
                    break;
                case "Businessman":
                case "Businesswoman":
                    baverage = "Coffee";
                    price = 1.00;
                    break;
                case "SoftUni Student":
                    baverage = "Beer";
                    price = 1.70;
                    break;
                default:
                    baverage = "Tea";
                    price = 1.20;
                    break;
            }
            double totalPrice = quantity * price;
            Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
        }
    }
}
