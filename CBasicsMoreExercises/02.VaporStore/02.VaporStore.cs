
namespace _02.VaporStore
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double currentBalance = double.Parse(Console.ReadLine());

            string gameName = Console.ReadLine();

            string status = string.Empty;
            double gamePrice = 0;
            double remainingMoney = currentBalance;
            
            while (gameName != "Game Time")
            {
                
                switch (gameName)
                {
                    case "OutFall 4":
                        gamePrice = 39.99;
                        status = "Bought OutFall 4";
                        break;
                    case "CS: OG":
                        gamePrice = 15.99;
                        status = "Bought CS: OG";
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99;
                        status = "Bought Zplinter Zell";
                        break;
                    case "Honored 2":
                        gamePrice = 59.99;
                        status = "Bought Honored 2";
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99;
                        status = "Bought RoverWatch";
                        break;
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99;
                        status = "Bought RoverWatch Origins Edition";
                        break;
                    default:
                        status = "Not Found";
                        break;
                }

                if (remainingMoney < gamePrice)
                {
                    status = "Too Expensive";
                    Console.WriteLine(status);
                }
                else if (remainingMoney >= gamePrice)
                {
                    remainingMoney -= gamePrice;
                    Console.WriteLine(status);
                    if (remainingMoney == gamePrice)
                    {
                        Console.WriteLine("Out of money");
                        break;
                    }
                }
                gamePrice = 0;
                status = string.Empty;
                gameName = Console.ReadLine();
            }
            
            if (remainingMoney == 0 && gameName == "Game Time")
            {
                Console.WriteLine("Out of money!");
                return;
            }
            else if (remainingMoney > 0)
            {
                double moneySpent = currentBalance - remainingMoney;

                Console.WriteLine($"Total spent: ${moneySpent:f2}. Remaining: ${remainingMoney:f2}");
            }

        }
    }
}
