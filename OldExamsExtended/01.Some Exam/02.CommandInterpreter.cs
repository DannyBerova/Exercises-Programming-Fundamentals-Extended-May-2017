
namespace _01.Some_Exam
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();
            List<string> input = inputLine.Split().ToList();

            string commands = Console.ReadLine();

            while (commands != "end")
            {
                var tokens = commands.Split().ToArray();

                switch (tokens[0])
                {
                    case "reverse":
                        int startReverse = int.Parse(tokens[2]);
                        int countReverse = int.Parse(tokens[4]);

                        if (startReverse >= 0 &&
                             startReverse < input.Count &&
                             countReverse >= 0 &&
                             startReverse + countReverse <= input.Count)
                        {
                            input.Reverse(startReverse, countReverse);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;

                    case "sort":
                        int startSort = int.Parse(tokens[2]);
                        int countSort = int.Parse(tokens[4]);

                        if (startSort >= 0 &&
                            startSort < input.Count &&
                            countSort >= 0 &&
                            startSort + countSort <= input.Count)
                        {
                            input.Sort(startSort, countSort, StringComparer.InvariantCulture);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;

                    case "rollLeft":
                        int countRollLeft = int.Parse(tokens[1]);

                        if (countRollLeft >= 0)
                        {
                            for (int i = 0; i < countRollLeft % input.Count; i++)
                            {
                                string firstElement = input[0];

                                for (int j = 0; j < input.Count - 1; j++)
                                {
                                    input[j] = input[j + 1];
                                }

                                input[input.Count - 1] = firstElement;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;

                    case "rollRight":
                        int countRollRight = int.Parse(tokens[1]);

                        if (countRollRight >= 0)
                        {
                            for (int i = 0; i < countRollRight % input.Count; i++)
                            {
                                string lastElement = input[input.Count - 1];

                                for (int j = input.Count - 1; j > 0; j--)
                                {
                                    input[j] = input[j - 1];
                                }

                                input[0] = lastElement;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;

                }
                commands = Console.ReadLine();
            }

            Console.WriteLine("[" + (string.Join(", ", input)) + "]");

        }
    }
}
