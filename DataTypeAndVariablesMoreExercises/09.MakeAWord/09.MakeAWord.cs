
namespace _09.MakeAWord
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string result = string.Empty;
            for (int i = 0; i < n; i++)
            {
                char inputChar = char.Parse(Console.ReadLine());
                result += inputChar;
            }
            Console.WriteLine($"The word is: {result}");
        }
    }
}
