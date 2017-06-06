
namespace _11.StringConcatenation
{
    using System;

    public class Program
    {
        public static void Main()
        {
            char delimiter = char.Parse(Console.ReadLine());
            string position = Console.ReadLine().ToLower();
            int n = int.Parse(Console.ReadLine());

            string output = string.Empty;
            int result = 0;
            if (position == "odd")
            {
                result = 1;
            }
            for (int i = 1; i <= n; i++)
            {
                string currentWord = Console.ReadLine();

                if (i % 2 == result)
                {
                    output +=currentWord + delimiter;
                }
            }
            Console.WriteLine(output.Remove(output.Length - 1, 1));

        }
    }
}
