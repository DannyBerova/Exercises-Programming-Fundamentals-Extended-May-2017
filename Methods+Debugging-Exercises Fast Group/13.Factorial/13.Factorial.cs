
namespace _13.Factorial
{
    using System;
    using System.Numerics;

    public class Program
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            BigInteger factorial = CalculateFactorial(num);
            Console.WriteLine(factorial);
        }

        private static BigInteger CalculateFactorial(int num)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
