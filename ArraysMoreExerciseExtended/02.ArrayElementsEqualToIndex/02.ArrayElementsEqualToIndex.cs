
namespace _02.ArrayElementsEqualToIndex
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] integers = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToArray();

            List<int> equalIndexes = new List<int>();

            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] == i)
                {
                    equalIndexes.Add(integers[i]); 
                }
            }

            Console.WriteLine(string.Join(" ", equalIndexes));   
        }
    }
}
