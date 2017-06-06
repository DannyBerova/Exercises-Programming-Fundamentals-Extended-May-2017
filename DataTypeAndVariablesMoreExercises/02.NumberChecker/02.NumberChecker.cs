
namespace _02.NumberChecker
{
    using System;

    public class Program
    {
        public static void Main()
        {
            try
            {
                long inputNumber = long.Parse(Console.ReadLine());

                Console.WriteLine("integer");
            }
            catch (Exception)
            {

                Console.WriteLine("floating-point");
            }
        }
    }
}
