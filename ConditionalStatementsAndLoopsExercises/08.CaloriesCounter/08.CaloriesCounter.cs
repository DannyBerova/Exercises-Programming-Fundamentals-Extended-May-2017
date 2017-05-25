
namespace _08.CaloriesCounter
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int sumCalories = 0;

            for (int i = 0; i < n; i++)
            {
                string ingridient = Console.ReadLine().ToLower();

                if (ingridient == "cheese")
                {
                    sumCalories += 500;
                }
                else if (ingridient == "tomato sauce")
                {
                    sumCalories += 150;
                }
                else if (ingridient == "salami")
                {
                    sumCalories += 600;
                }
                else if (ingridient == "pepper")
                {
                    sumCalories += 50;
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine($"Total calories: {sumCalories}");
        }
    }
}
