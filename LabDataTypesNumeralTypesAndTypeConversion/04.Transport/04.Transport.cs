
namespace _04.Transport
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int numberOfPeople = int.Parse(Console.ReadLine());

            int totalCapacityOfVehicles = 24;
            int coursesNeeded = (int)Math.Ceiling(
                (double)numberOfPeople / totalCapacityOfVehicles);
            Console.WriteLine(coursesNeeded);
        }
    }
}
