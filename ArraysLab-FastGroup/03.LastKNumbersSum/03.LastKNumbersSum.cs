
namespace _03.LastKNumbersSum
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int arrayLenght = int.Parse(Console.ReadLine());
            int previousKElements = int.Parse(Console.ReadLine());

            long[] array = new long[arrayLenght];
            array[0] = 1;

            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 1; j <= previousKElements; j++)
                {
                    if (i - j >= 0)
                    {
                        array[i] += array[i - j];
                        continue;
                    }
                    break;
                }
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}