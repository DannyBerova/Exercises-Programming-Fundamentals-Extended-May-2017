
namespace _06.ReverseArrayOfStrings
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] inputString = Console.ReadLine()
                .Split(' ');

            for (int i = 0; i < inputString.Length / 2; i++)
            {
                string oldCurrent = inputString[i];
                inputString[i] = inputString[inputString.Length - 1 - i];
                inputString[inputString.Length - 1 - i] = oldCurrent;
            }
            Console.WriteLine(string.Join(" ", inputString));
        }
    }
}
