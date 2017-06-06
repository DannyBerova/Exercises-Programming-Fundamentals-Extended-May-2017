
namespace _14.BoatSimulator
{
    using System;

    public class Program
    {
        public static void Main()
        {
            char firstBoat = char.Parse(Console.ReadLine());
            char secondBoat = char.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());

            int firstBoatTiles = 0;
            int secondBoatTiles = 0;
            for (int i = 1; i <= lines; i++)
            {
                string randomString = Console.ReadLine();

                if (randomString == "UPGRADE")
                {
                    firstBoat += (char)3;
                    secondBoat += (char)3;
                }
                else if (i % 2 == 1)
                {
                    firstBoatTiles += randomString.Length;
                }
                else if (i % 2 == 0)
                {
                    secondBoatTiles += randomString.Length;
                }

                if (firstBoatTiles >= 50)
                {
                    Console.WriteLine(firstBoat);
                    return;
                }
                if (secondBoatTiles >= 50)
                {
                    Console.WriteLine(secondBoat);
                    return;
                }
            }
            if (firstBoatTiles > secondBoatTiles)
            {
                Console.WriteLine(firstBoat);
            }
            else
            {
                Console.WriteLine(secondBoat);
            }

        }
    }
}
