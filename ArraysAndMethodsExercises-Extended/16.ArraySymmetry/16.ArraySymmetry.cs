
namespace _16.ArraySymmetry
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] stringArray = Console.ReadLine().Split(' ');
            bool isSymmetric = false;
            int n = stringArray.Length / 2;
            for (int i = 0; i < n; i++)
            {
                if (stringArray[i] == stringArray[stringArray.Length - 1 - i])
                {
                    isSymmetric = true;
                }
                else
                {
                    isSymmetric = false;
                    break;
                }
            }
            if (isSymmetric)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
