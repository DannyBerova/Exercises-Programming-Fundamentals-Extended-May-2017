
namespace _07.ChangeVariableValues
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Before:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");

            int oldValueOfA = a;
            a = b;
            b = oldValueOfA;

            Console.WriteLine("After:");
            Console.WriteLine($"a = {a}"); ;
            Console.WriteLine($"b = {b}");


        }
    }
}
