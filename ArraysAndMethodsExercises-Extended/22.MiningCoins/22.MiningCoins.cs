
namespace _22.MiningCoins
{
    using System;
    
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string decrypted = string.Empty;
            float totalValue = 0;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine().Trim());

                int digit1 = number / 100;
                int digit2 = (number % 100) / 10;
                int digit3 = number % 10;

                totalValue += (((float)digit1 + digit2 + digit3) / n);
                int ASCIICode = 0;

                if (i % 2 != 0)
                {
                    ASCIICode = (((digit1 * 10) + digit3) - digit2);
                }
                else
                {
                    ASCIICode = (((digit1 * 10) + digit3) + digit2);
                }

                if ((ASCIICode >= 65 && ASCIICode <= 90)
                    || (ASCIICode >= 97 && ASCIICode <= 122))
                {
                    decrypted += (char)ASCIICode;
                }
            }

            Console.WriteLine("Message: {0}", decrypted);
            Console.WriteLine("Value: {0:F7}", totalValue);
        }
    }
}
