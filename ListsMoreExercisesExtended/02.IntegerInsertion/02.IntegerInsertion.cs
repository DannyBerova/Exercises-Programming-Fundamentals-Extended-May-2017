
namespace _02.IntegerInsertion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ').Select(int.Parse).ToList();

            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                int index = ((int)(inputLine[0]) - 48);
                int element = int.Parse(inputLine);
                numbers.Insert(index, element);

                inputLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
