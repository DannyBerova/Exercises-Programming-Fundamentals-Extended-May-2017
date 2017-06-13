
namespace _02.ReverseArrayOfIntegers
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int numOfElements = int.Parse(Console.ReadLine());
            int[] elements = new int[numOfElements];

            for (int i = numOfElements - 1; i >= 0; i--)
            {
                elements[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(" ",elements));
        }
    }
}
