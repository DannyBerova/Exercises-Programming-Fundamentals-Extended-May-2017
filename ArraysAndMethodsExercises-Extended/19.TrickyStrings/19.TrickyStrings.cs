
namespace _19.TrickyStrings
{
    using System;
    class TrickyStrings
    {
        static void Main()
        {
            string delimiter = Console.ReadLine();
            int numberOfStrings = int.Parse(Console.ReadLine());
            string result = string.Empty;
            for (int i = 1; i <= numberOfStrings; i++)
            {
                string currentString = Console.ReadLine();
                result += currentString + delimiter;

            }
            int remove = delimiter.Length;
            Console.WriteLine(result.Remove(result.Length - remove, remove));
        }
    }
}