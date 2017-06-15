
namespace _10.CountOfNegativesInArray
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int countNegatives = 0;

            for (int i = 0; i < n; i++)
            {
                int inputNum = int.Parse(Console.ReadLine());
                array[i] = inputNum;
                if (inputNum < 0)
                {
                    countNegatives++;
                }
            }
            Console.WriteLine(countNegatives);
        }
    }
}
