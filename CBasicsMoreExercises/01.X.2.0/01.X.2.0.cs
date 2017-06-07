
namespace _01.X._2._0
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int left = 0;
            int right = number - 1;

            for (int row = 0; row < number; row++)
            {
                for (int col = 0; col < number; col++)
                {
                    if ((col == left) || (col == right))
                    {
                        Console.Write('x');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
                left++;
                right--;
            }
        }
    }
}
