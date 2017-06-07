
namespace _03.ExchangeVariableValues
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int oldValueOfA = a;
            a = b;
            b = oldValueOfA;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
