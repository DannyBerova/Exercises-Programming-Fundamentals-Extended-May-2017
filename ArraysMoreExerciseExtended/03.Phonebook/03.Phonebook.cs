
namespace _03.Phonebook
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] phoneNumbers = Console.ReadLine().Split();
            string[] names = Console.ReadLine().Split();
            string inputName = Console.ReadLine();

            while (inputName != "done")
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (inputName == names[i])
                    {
                        Console.WriteLine($"{names[i]} -> {phoneNumbers[i]}");
                        break;
                    }
                }
                inputName = Console.ReadLine();
            }
        }
    }
}
