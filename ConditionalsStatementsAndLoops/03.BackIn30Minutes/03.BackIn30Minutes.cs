
namespace _03.BackIn30Minutes
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            var addedMinutes = minutes + 30;

            if (addedMinutes > 59)
            {
                hours++;
                addedMinutes -= 60;

                if (hours > 23)
                {
                    hours = 0;
                }
            }

            Console.WriteLine($"{hours}:{addedMinutes:D2}");
        }
    }
}
