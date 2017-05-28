
namespace _06.DNASequence
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int sumOfElements = int.Parse(Console.ReadLine());

            for (int firstLetter = 1; firstLetter <= 4; firstLetter++)
            {
                for (int secondLetter = 1; secondLetter <= 4; secondLetter++)
                {
                    for (int thirdLetter = 1; thirdLetter <= 4; thirdLetter++)
                    {

                        string result = $"{firstLetter}{secondLetter}{thirdLetter}";
                        result = result.Replace("1", "A").Replace("2", "C").Replace("3", "G").Replace("4", "T");

                        if (firstLetter + secondLetter + thirdLetter >= sumOfElements)
                        {
                            
                            Console.Write($"O{result}O ");
                        }
                        else
                        {
                            Console.Write($"X{result}X ");

                        }

                        if (thirdLetter % 4 == 0)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
