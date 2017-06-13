
namespace _01.DaysOfWeek
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string[] daysOfWeek = new string[]
            {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

            int dayNeeded = int.Parse(Console.ReadLine());

            if (dayNeeded > 0 && dayNeeded < 8)
            {
                Console.WriteLine(daysOfWeek[dayNeeded - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
