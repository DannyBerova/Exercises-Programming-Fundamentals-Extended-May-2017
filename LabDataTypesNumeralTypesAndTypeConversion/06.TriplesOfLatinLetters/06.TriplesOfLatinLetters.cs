namespace _06.TriplesOfLetters
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int firstLetter = 0; firstLetter < n; firstLetter++)
            {
                for (int secondLetter = 0; secondLetter < n; secondLetter++)
                {
                    for (int thirdLetter = 0; thirdLetter < n; thirdLetter++)
                    {
                        Console.WriteLine(
                            $"{(char)('a' + firstLetter)}{(char)('a' + secondLetter)}{(char)('a' + thirdLetter)}");
                    }
                }
            }
        }
    }
}
