
namespace _06.IncrementVariable2._0
{
    using System;

    public class Program
    {
        public static void Main()
        {
            long n = int.Parse(Console.ReadLine());
            long byteOutput = n % (byte.MaxValue + 1);
            long overflow = n / (byte.MaxValue + 1);

            Console.WriteLine(byteOutput);
            Console.WriteLine($"Overflowed {overflow} times");
        }
    }
}
