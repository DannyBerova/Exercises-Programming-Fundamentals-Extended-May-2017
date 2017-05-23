namespace _02AddTwoNumbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            var sum = a + b;

            Console.WriteLine($"{a} + {b} = {sum}");

        }
    }
}
