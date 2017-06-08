
namespace _15.BalancedBrackets
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());

            string previousBracket = string.Empty;
            string status = "BALANCED";


            for (int i = 0; i < lines; i++)
            {
                string currentString = Console.ReadLine();

                if (currentString == "(")
                {
                    if (previousBracket == "(")
                    {
                        status = "UNBALANCED";
                        break;
                    }
                    previousBracket = "(";
                }

                if (currentString == ")")
                {
                    if (previousBracket != "(")
                    {
                        status = "UNBALANCED";
                        break;
                    }
                    previousBracket = ")";
                }
            }

            if (previousBracket == "(")
            {
                status = "UNBALANCED";
            }
                Console.WriteLine(status);
        }
    }
}
