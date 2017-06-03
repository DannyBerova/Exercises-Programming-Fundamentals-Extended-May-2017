
namespace _10.CenturiesToNanoseconds
{
    using System;
    using System.Numerics;

    

    public class Program
    {
        public static void Main()
        {
            byte centuries = byte.Parse(Console.ReadLine());

            ushort years = (ushort)(centuries * 100);
            uint days = (uint)(years * 365.2422);
            ulong hours = days * 24;
            ulong minutes = hours * 60;
            ulong seconds = minutes * 60;
            ulong milliseconds = seconds * 1000;
            BigInteger microseconds = milliseconds * 1000;
            BigInteger nanoseconds = microseconds * 1000;

            Console.Write($"{centuries} centuries = {years} years = {days} days = {hours} hours ");
            Console.Write($"= {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds ");
            Console.WriteLine($"= {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
