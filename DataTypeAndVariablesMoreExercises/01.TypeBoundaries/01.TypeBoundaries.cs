
namespace _01.TypeBoundaries
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string type = Console.ReadLine();
            
            long minInput = long.MinValue;
            long maxInput = long.MaxValue;

            if (type == "sbyte")
            {
                minInput = sbyte.MinValue;
                maxInput = sbyte.MaxValue;
            }
            else if (type == "byte")
            {
                minInput = byte.MinValue;
                maxInput = byte.MaxValue;
            }
            else if (type == "int")
            {
                minInput = int.MinValue;
                maxInput = int.MaxValue;
            }
            else if (type == "uint")
            {
                minInput = uint.MinValue;
                maxInput = uint.MaxValue;
            }

            Console.WriteLine(maxInput);
            Console.WriteLine(minInput);
        }
    }
}
