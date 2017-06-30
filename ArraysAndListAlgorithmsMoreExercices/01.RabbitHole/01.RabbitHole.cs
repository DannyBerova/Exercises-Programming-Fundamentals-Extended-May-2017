
namespace _01.RabbitHole
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            List<string> obstacles = Console.ReadLine().Split().ToList();
            int energy = int.Parse(Console.ReadLine());

            int index = 0;

            while (energy > 0)
            {
                if (obstacles[index] == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    return;
                }
                else
                {
                    string[] obstacle = obstacles[index].Split('|');
                    string command = obstacle[0];
                    int points = int.Parse(obstacle[1]);


                    if (command == "Right")
                    {
                        energy -= points;
                        index = (index + points) % obstacles.Count;
                    }
                    else if (command == "Left")
                    {
                        energy -= points;
                        index = Math.Abs(index - points) % obstacles.Count;
                    }
                    else if (command == "Bomb")
                    {
                        energy -= points;
                        if (energy <= 0)
                        {
                            Console.WriteLine("You are dead due to bomb explosion!");
                            return;
                        }
                        else
                        {
                            obstacles.RemoveAt(index);
                            index = 0;
                        }
                    }
                }


                string addedElement = $"Bomb|{energy}";
                if (obstacles[obstacles.Count - 1] == "RabbitHole")
                {
                    obstacles.Add(addedElement);
                }
                else
                {
                    obstacles.RemoveAt(obstacles.Count - 1);
                    obstacles.Add(addedElement);
                }
            }

            Console.WriteLine("You are tired. You can't continue the mission.");
        }
    }
}