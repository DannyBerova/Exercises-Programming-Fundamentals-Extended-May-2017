
namespace _01.SumArrayElements
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int numOfElements = int.Parse(Console.ReadLine());
            int[] elements = new int[numOfElements];
            int sumOfElements = 0;

            for (int i = 0; i < elements.Length; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                elements[i] = currentNumber;
                sumOfElements += elements[i];  
            }

            Console.WriteLine(sumOfElements);
        }
    }
}
