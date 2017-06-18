
namespace _01.Last3ConsecutiveEqualStrings
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] strings = Console.ReadLine().Split();


            for (int i = strings.Length - 1; i >= 2; i--)
            {
                if (strings[i] == strings[i - 1] && strings[i] == strings[i - 2])
                {
                    Console.WriteLine("{0} {0} {0}", strings[i]);
                    return;
                }
            }
        }
    }
}
