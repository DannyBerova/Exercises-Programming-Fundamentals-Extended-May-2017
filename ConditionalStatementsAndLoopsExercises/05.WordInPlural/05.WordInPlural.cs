
namespace _05.WordInPlural
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine(); 

            if (input.EndsWith("o") 
                || input.EndsWith("ch") 
                || input.EndsWith("s") 
                || input.EndsWith("sh") 
                || input.EndsWith("x") 
                || input.EndsWith("z"))
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
