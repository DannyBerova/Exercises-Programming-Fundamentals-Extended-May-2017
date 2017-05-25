
namespace _07.CakeIngridients
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string ingridient = "";
            int countOfIngridients = 0;

            while (true)
            {
                ingridient = Console.ReadLine();

                if (ingridient == "Bake!")
                {
                    break;
                }
                Console.WriteLine($"Adding ingredient {ingridient}.");
                countOfIngridients++;
            }

            Console.WriteLine($"Preparing cake with {countOfIngridients} ingredients.");
        }
    }
}
