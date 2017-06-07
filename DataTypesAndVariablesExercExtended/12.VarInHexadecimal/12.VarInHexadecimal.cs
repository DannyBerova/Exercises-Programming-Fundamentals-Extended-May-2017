
namespace _12.VarInHexadecimal
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string hexValue = Console.ReadLine();
            int decValue = Convert.ToInt32(hexValue, 16);

            Console.WriteLine(decValue);
        }
    }
}
