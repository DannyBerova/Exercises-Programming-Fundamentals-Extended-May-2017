
namespace _08.HouseBuilder
{
    using System;

    public class Program
    {
        public static void Main()
        {
            long priceOne = long.Parse(Console.ReadLine());
            long priceTwo = long.Parse(Console.ReadLine());

            long totalPrice = 0;

            if (priceOne > priceTwo )
            {
                totalPrice = priceOne * 10 + priceTwo * 4;
            }
            else
            {
                totalPrice = priceOne * 4 + priceTwo * 10;

            }

            Console.WriteLine(totalPrice);
        }
    }
}
