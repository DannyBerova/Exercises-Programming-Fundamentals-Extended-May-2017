
namespace _07.GreaterOfTwoValues
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string typeOfInput = Console.ReadLine();

            if (typeOfInput == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int max = GetMax(first, second);
                Console.WriteLine(max);
            }
            if (typeOfInput == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                char max = GetMax(first, second);
                Console.WriteLine(max);
            }
            if (typeOfInput == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                string max = GetMax(first, second);
                Console.WriteLine(max);
            }
        }

        private static int GetMax(int first, int second)
        {
            return Math.Max(first, second);
        }

        private static char GetMax(char first, char second)
        {
            return (char)Math.Max(first, second);
        }

        private static string GetMax(string first, string second)
        {
            int result = first.CompareTo(second);
            if (result >= 0)
            {
                return first;
            }
            return second;
        }
    }
}
