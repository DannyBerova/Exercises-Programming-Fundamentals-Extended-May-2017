
namespace _05.TearListInHalf
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ').Select(int.Parse).ToList();

            List<int> leftHalf = new List<int>();

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                leftHalf.Add(numbers[i]);
            }

            List<int> rightHalf = new List<int>();

            for (int i = numbers.Count / 2; i < numbers.Count; i++)
            {
                rightHalf.Add(numbers[i]);
            }

            List<int> combinedLists = new List<int>();

            for (int i = 0; i < leftHalf.Count; i++)
            {
                //int firstDigit = rightHalf[i] / 10;
                //int secondDigit = rightHalf[i] % 10;
                combinedLists.Add(rightHalf[i] / 10);
                combinedLists.Add(leftHalf[i]);
                combinedLists.Add(rightHalf[i] % 10);
            }

            Console.WriteLine(string.Join(" ", combinedLists));
        }
    }
}
