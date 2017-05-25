
namespace _12.TestNumbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSumBoundary = int.Parse(Console.ReadLine());

            int countOfCombinations = 0;
            int sum = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    int currentProduct = 3 * (i * j);
                    sum += currentProduct;
                    countOfCombinations++;

                    if (sum >= maxSumBoundary)
                    {
                        Console.WriteLine($"{countOfCombinations} combinations");
                        Console.WriteLine($"Sum: {sum} >= {maxSumBoundary}");
                        return;
                    }
                }
            }

            Console.WriteLine($"{countOfCombinations} combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
