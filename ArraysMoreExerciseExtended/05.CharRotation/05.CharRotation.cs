
namespace _05.CharRotation
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var chars = Console.ReadLine().ToCharArray();
            int[] integers = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (integers[i] % 2 == 0)
                {
                    chars[i] = (char)((int)chars[i] - integers[i]);
                }
                else
                {
                    chars[i] = (char)((int)chars[i] + integers[i]);
                }
            }

            Console.WriteLine(string.Join("", chars));
        }
    }
}
