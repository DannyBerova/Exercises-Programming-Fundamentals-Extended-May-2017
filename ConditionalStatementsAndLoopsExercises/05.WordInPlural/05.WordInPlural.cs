
namespace _05.WordInPlural
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine(); 

            if (input.EndsWith("o"))
            {
                Console.WriteLine(input + "es");
            }
            else if (input.EndsWith("ch"))
            {
                Console.WriteLine(input + "es");
            }
            else if (input.EndsWith("s"))
            {
                Console.WriteLine(input + "es");
            }
            else if (input.EndsWith("sh"))
            {
                Console.WriteLine(input + "es");
            }
            else if (input.EndsWith("x"))
            {
                Console.WriteLine(input + "es");
            }
            else if (input.EndsWith("z"))
            {
                Console.WriteLine(input + "es");
            }
            else if (input.EndsWith("y"))
            {
                input = input.Remove(input.Length - 1);
                Console.WriteLine(input + "ies");
            }
            else
            {
                Console.WriteLine(input + "s");
            }
        }
    }
}
