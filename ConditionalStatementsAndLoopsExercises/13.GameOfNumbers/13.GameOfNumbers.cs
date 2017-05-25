
namespace _13.GameOfNumbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());

            int countOfCombinations = 0;

            for (int firstNumber = m; firstNumber >= n; firstNumber--)
            {
                for (int secondNumber = m; secondNumber >= n; secondNumber--)
                {
                    countOfCombinations++;

                    if (magicalNumber == firstNumber + secondNumber)
                    {
                        Console.WriteLine($"Number found! {firstNumber} + {secondNumber} = {magicalNumber}");
                        return;
                    }
                }
            }

            Console.WriteLine($"{countOfCombinations} combinations - neither equals {magicalNumber}");
        }
    }
}
