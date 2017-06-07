
namespace _17.CypherRoulette
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            string output = string.Empty;
            string previousString = string.Empty;
            int direction = 0;

            for (int i = 0; i < num; i++)
            {
                string currentString = Console.ReadLine();
                if (currentString == previousString)
                {
                    output = string.Empty;
                    if (currentString == "spin")
                    {
                        i--;
                    }
                }
                else
                {
                    if (currentString == "spin")
                    {
                        direction++;
                        i--;
                    }
                    else
                    {
                        if (direction % 2 == 0)
                        {
                            output += currentString;
                        }
                        else if (direction % 2 == 1)
                        {
                            output = currentString + output;
                        }
                    }
                }
                previousString = currentString;
            }
            Console.WriteLine(output);
        }
    }
}
