
namespace _09.LargestElementInArray
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int largestNum = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int inputNum = int.Parse(Console.ReadLine());
                array[i] = inputNum;
                if (largestNum < inputNum)
                {
                    largestNum = inputNum;
                }
            }
            Console.WriteLine(largestNum);
        }
    }
}
