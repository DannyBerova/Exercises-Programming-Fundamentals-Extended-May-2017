
namespace _10.ExtractMiddleOf123Elements
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] result;
            int arrLenght = array.Length;

            if (arrLenght == 1)
            {
                result = new int[1];
                result[0] = array[0];
            }
            else if (arrLenght % 2 == 0)
            {
                result = new int[2];
                result[0] = array[arrLenght / 2 - 1];
                result[1] = array[arrLenght / 2];
            }
            else
            {
                result = new int[3];
                result[0] = array[arrLenght / 2 - 1];
                result[1] = array[arrLenght / 2];
                result[2] = array[arrLenght / 2 + 1];
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}

