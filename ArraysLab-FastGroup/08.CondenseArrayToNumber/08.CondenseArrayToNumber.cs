
namespace _08.CondenseArrayToNumber
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            while (nums.Length > 1)
            {
                int[] condensed = new int[nums.Length - 1];

                for (int j = 0; j < condensed.Length; j++)
                {
                    condensed[j] = nums[j] + nums[j + 1];
                }
                nums = condensed;
            }

            Console.WriteLine(nums[0]);
        }
    }
}
