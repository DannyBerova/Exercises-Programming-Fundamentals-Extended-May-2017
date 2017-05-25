
namespace _09.CountTheIntegers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int integerCounter = 0;

            try
            {
                
                while (true)
                {
                    int integer = int.Parse(Console.ReadLine());
                    integerCounter++;
                }
            }
            catch (Exception)
            {

                Console.WriteLine(integerCounter);
            }
        }
    }
}
