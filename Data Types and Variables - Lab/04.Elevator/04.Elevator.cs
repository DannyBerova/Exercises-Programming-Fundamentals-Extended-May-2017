
namespace _04.Elevator
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacityOfElevator = int.Parse(Console.ReadLine());

            int coursesNeeded = (int)Math.Ceiling((double)numberOfPeople / capacityOfElevator);
            Console.WriteLine(coursesNeeded);
        }
    }
}
