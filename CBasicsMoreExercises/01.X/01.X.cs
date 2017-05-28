
namespace _01.X
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int upper = 0; upper < number / 2; upper++)
            {
                Console.WriteLine(new string(' ', upper) + "x" 
                    + new string(' ', (number - 2) - 2 * upper)
                    + "x" + (new string(' ', upper)));
            }

            Console.WriteLine(new string(' ', number / 2) + "x" + new string(' ', number / 2));

            for (int lower = 0; lower < number / 2; lower++)
            {
                Console.WriteLine(new string(' ', (number - 3) / 2 - lower) + "x"
                    + new string(' ', 1 + (2 * lower))
                    + "x" + (new string(' ', (number - 3) / 2 - lower)));
            }
        }
    }
}
