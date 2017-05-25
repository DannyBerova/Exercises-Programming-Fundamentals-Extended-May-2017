
namespace _10.MultiplicationTable2._0
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var multiplier = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                if (i >= multiplier)
                {
                    var product = n * i;
                    Console.WriteLine($"{n} X {i} = {product}");
                }
            }

            if (multiplier > 10)
            {
                Console.WriteLine($"{n} X {multiplier} = {n * multiplier}");
            }
        }
    }
}
