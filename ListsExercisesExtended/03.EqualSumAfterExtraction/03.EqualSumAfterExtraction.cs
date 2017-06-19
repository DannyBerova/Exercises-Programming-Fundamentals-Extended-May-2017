
namespace _03.EqualSumAfterExtraction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<int> firstList = Console.ReadLine()
                .Split(' ').Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine()
                .Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < firstList.Count; i++)
            {
                for (int j = 0; j < secondList.Count; j++)
                {
                    if (firstList[i] == secondList[j])
                    {
                        secondList.RemoveAt(j);
                        j--;
                    }
                }
            }

            int firstSum = firstList.Sum();
            int secondSum = secondList.Sum();
            int diff = Math.Abs(firstSum - secondSum);

            if (firstSum == secondSum)
            {
                Console.WriteLine($"Yes. Sum: {firstSum}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {diff}");
            }
        }
    }
}
