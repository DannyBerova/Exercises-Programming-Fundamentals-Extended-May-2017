
namespace _13.IncreasingSequence
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
            bool isIncreasing = false;

            for (int i = 0; i < elements.Length - 1; i++)
            {
                if (elements[i] < elements[i + 1])
                {
                    isIncreasing = true;
                }
                else
                {
                    isIncreasing = false;
                    break;
                }
            }
            if (isIncreasing)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
