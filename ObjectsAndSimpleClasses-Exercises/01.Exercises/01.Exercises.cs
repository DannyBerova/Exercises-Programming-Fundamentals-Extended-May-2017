
namespace _01.Exercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Exercise
    {
        public string Topic { get; set; }

        public string CourseName { get; set; }

        public string JudgeContestLink { get; set; }

        public List<string> Problems { get; set; }
    }
    public class Program
    {
        public static void Main()
        {
            List<Exercise> exercises = new List<Exercise>();

            string inputLine = Console.ReadLine();

            while (inputLine != "go go go")
            {
                string[] tokens = inputLine.Split(new string[] { " -> " },
                    StringSplitOptions.RemoveEmptyEntries);

                string topic = tokens[0];
                string courseName = tokens[1];
                string judgeContestLink = tokens[2];
                List<string> problems = tokens[3].Split(new string[] { ", " },
                    StringSplitOptions.RemoveEmptyEntries).ToList();

                Exercise newExercise = new Exercise()
                {
                    Topic = topic,
                    CourseName = courseName,
                    JudgeContestLink = judgeContestLink,
                    Problems = problems
                };
                exercises.Add(newExercise);

                inputLine = Console.ReadLine();
            }

            foreach (Exercise exercise in exercises)
            {
                Console.WriteLine($"Exercises: {exercise.Topic}");
                Console.WriteLine(
                    "Problems for exercises and homework for the \"{0}\" course @ SoftUni.",
                    exercise.CourseName);
                Console.WriteLine($"Check your solutions here: {exercise.JudgeContestLink}");

                int counter = 1;
                foreach (var problem in exercise.Problems)
                {
                    Console.WriteLine($"{counter}. {problem}");
                    counter++;
                }
            }
        }
    }
}
