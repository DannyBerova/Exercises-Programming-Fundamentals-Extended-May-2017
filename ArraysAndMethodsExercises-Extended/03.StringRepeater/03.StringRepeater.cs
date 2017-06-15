
namespace _03.StringRepeater
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string inputString = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            string outputString = RepeatString(inputString, count);

            Console.WriteLine(outputString);
        }

        private static string RepeatString(string inputString, int count)
        {
            string repeatedString = string.Empty;

            for (int i = 0; i < count; i++)
            {
                repeatedString += inputString;
            }
            return repeatedString;
        }
    }
}
