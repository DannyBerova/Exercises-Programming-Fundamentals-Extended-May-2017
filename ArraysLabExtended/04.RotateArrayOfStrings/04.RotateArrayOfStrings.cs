
namespace _04.RotateArrayOfStrings
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string[] inputStrings = Console.ReadLine().Split(' ');
            string[] rotatedStrings = new string[inputStrings.Length];
            var firstIndex = inputStrings[inputStrings.Length - 1];

            for (int i = 0; i < inputStrings.Length-1; i++)
            {
                rotatedStrings[i + 1] = inputStrings[i];
            }
            rotatedStrings[0] = firstIndex;
            var rotated = string.Join(" ", rotatedStrings);
            Console.WriteLine(rotated);
        }
    }
}
