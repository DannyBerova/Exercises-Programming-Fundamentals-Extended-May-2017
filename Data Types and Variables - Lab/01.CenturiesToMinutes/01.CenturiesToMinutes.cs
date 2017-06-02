
namespace _01.CenturiesToMinutes
{
    using System;

    public class Program
    {
        public static void Main()
        {
            byte centuries = byte.Parse(Console.ReadLine());
            ushort years = (ushort)(centuries * 100);
            uint days = (uint)(years * 365.2422);
            ulong hours = days * 24;
            ulong minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = { minutes} minutes");


        }
    }
}
