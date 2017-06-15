
namespace _11.CountOfGivenElementInArr
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] elements = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int givenElement = int.Parse(Console.ReadLine());

            int countGivenElement = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] == givenElement)
                {
                    countGivenElement++;
                }
            }
            Console.WriteLine(countGivenElement);
        }
    }
}
