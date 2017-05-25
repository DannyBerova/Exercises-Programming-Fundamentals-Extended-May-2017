
namespace _09.MultiplicationTable
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                var product = n * i;
                Console.WriteLine($"{n} X {i} = {product}");
            }
        }
    }
}
