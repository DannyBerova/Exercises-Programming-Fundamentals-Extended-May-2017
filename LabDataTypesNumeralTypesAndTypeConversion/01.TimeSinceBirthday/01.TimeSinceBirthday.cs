
namespace _01.TimeSinceBirthday
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Console.Write("Years - ");
            byte years = byte.Parse(Console.ReadLine());
            uint days = (uint)(years * 365);
            ulong hours = days * 24;
            ulong minutes = hours * 60;

            Console.WriteLine($"{years} years = {days} days = {hours} hours = { minutes} minutes");
        }
    }
}
