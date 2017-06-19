
namespace _06.StuckZipper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int minLenght = TakeMinLenghtOfNumbers(firstList, secondList);

            firstList = RemoveBigerValues(minLenght, firstList);
            secondList = RemoveBigerValues(minLenght, secondList);

            int minCount = Math.Min(firstList.Count, secondList.Count);
            int maxCount = firstList.Count + secondList.Count;
            List<int> zippList = new List<int>();

            for (int i = 0; i <= maxCount; i++)
            {
                if (i < secondList.Count)
                {
                    zippList.Add(secondList[i]);
                }
                
                if (i < firstList.Count)
                {
                    zippList.Add(firstList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", zippList));
        }

        private static int TakeMinLenghtOfNumbers(List<int> firstList, List<int> secondList)
        {
            int currentLenght = 0;
            int nextLenght = 0;
            int minLenght = int.MaxValue;

            for (int i = 0; i < firstList.Count - 1; i++)
            {
                currentLenght = (Math.Abs(firstList[i])).ToString().Length;
                if (currentLenght < minLenght)
                {
                    minLenght = currentLenght;
                }
            }
            for (int i = 0; i < secondList.Count - 1; i++)
            {
                currentLenght = (Math.Abs(secondList[i])).ToString().Length;
                if (currentLenght < minLenght)
                {
                    minLenght = currentLenght;
                }
            }

            return minLenght;
        }

        private static List<int> RemoveBigerValues(int minLenght, List<int> list)
        {
            int currentLenght = 0;
            for (int i = 0; i < list.Count; i++)
            {
                currentLenght = (Math.Abs(list[i])).ToString().Length;

                if (currentLenght > minLenght)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
            return list;
        }
    }
}
