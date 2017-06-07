
namespace _16.TrickyStrings
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string delimiter = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string output = string.Empty;
            
            for (int i = 1; i <= n; i++)
            {
                string currentWord = Console.ReadLine();
                output += currentWord + delimiter;
            }
            int remove = delimiter.Length;
            Console.WriteLine(output.Remove(output.Length - remove, remove));
        }
    }
}
