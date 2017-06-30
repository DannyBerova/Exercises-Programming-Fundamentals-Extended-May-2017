
namespace _02.JapaneseRoulette
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] cylinderPlaces = Console.ReadLine()
                .Split().Select(int.Parse).ToArray();
            // cylinderPlaces.Lenght is always 6
            string[] players = Console.ReadLine().Split();

            int bulletPosition = 0;

            // finding bullet's position in array
            for (int i = 0; i < 6; i++)
            {
                if (cylinderPlaces[i] == 1)
                {
                    bulletPosition = i;
                }
            }

            //players moves
            for (int player = 0; player < players.Length; player++)
            {
                string[] strenghtAndDirection = players[player].Split(',');
                int strenght = int.Parse(strenghtAndDirection[0]);
                string direction = strenghtAndDirection[1];

                if (direction == "Right")
                {
                    bulletPosition = (bulletPosition + strenght) % 6;
                }
                else
                {
                    bulletPosition =(bulletPosition - strenght) % 6;

                    if (bulletPosition < 0)
                    {
                        bulletPosition += 6;
                    }
                }

                if (bulletPosition == 2)
                {
                    Console.WriteLine($"Game over! Player {player} is dead.");
                    return;
                }
               
                    bulletPosition++;
                
            }

            // if everybody's alive...
            Console.WriteLine("Everybody got lucky!");
        }
    }
}
