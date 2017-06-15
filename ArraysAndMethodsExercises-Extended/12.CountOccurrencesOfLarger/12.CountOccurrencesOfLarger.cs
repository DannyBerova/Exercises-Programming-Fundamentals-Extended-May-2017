
namespace _12.CountOccurrencesOfLarger
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            double[] elements = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            double p = double.Parse(Console.ReadLine());

            int countLargerElements = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] > p)
                {
                    countLargerElements++;
                }
            }
            Console.WriteLine(countLargerElements);
        }
    }
}
