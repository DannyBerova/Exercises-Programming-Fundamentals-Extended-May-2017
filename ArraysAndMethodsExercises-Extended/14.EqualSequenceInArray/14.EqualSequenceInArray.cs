
namespace _14.EqualSequenceInArray
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
            bool isEqual = false;

            for (int i = 0; i < elements.Length - 1; i++)
            {
                if (elements[i] == elements[i + 1])
                {
                    isEqual = true;
                }
                else
                {
                    isEqual = false;
                    break;
                }
            }
            if (isEqual)
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
