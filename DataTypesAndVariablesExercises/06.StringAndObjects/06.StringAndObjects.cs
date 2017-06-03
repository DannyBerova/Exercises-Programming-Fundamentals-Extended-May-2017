
namespace _06.StringAndObjects
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();

            object concat = firstWord + " " + secondWord;
            string resultString = (string)concat;

            Console.WriteLine(resultString);
        }
    }
}
