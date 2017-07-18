
namespace _01.AverageStudentsGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputLine = Console.ReadLine()
                    .Split(new [] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                string name = inputLine[0];
                double grade = double.Parse(inputLine[1]);

                if (!studentGrades.ContainsKey(name))
                {
                    studentGrades[name] = new List<double>();
                }
                studentGrades[name].Add(grade);

            }

            foreach (var student in studentGrades)
            {
                Console.Write($"{student.Key} -> ");

                foreach (var value in student.Value)
                {
                    Console.Write($"{value:f2} ");
                }

                Console.WriteLine($"(avg: {student.Value.Average():f2})");
            }

        }
    }
}
