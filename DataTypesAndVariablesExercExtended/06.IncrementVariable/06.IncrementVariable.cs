
namespace _06.IncrementVariable
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int overflowTimes = 0;
            byte output = 1;
            for (int i = 0; i < n; i++)
            {
                output++;
                if (output == 0)
                {
                    overflowTimes++;
                }
            }
            Console.WriteLine(output - 1);
            if (overflowTimes > 0)
            {
                Console.WriteLine("Overflowed {0} times", overflowTimes);
            }
        }
    }
}
