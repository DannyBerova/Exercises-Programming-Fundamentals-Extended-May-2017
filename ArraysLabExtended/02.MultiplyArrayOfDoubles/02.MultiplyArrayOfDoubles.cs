
namespace _02.MultiplyArrayOfDoubles
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            double multiplayer = double.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= multiplayer;
            }

            var multipliedArray = string.Join(" ", numbers);
            Console.WriteLine(multipliedArray);
        }
    }
}
