
namespace _15.BalancedBrackets
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());

            bool isBalanced = false;
            bool isFirstBracket = false;
            bool isNoBracket = true;
            

            for (int i = 0; i < lines; i++)
            {
                string currentString = Console.ReadLine();

                if (currentString == "(" || currentString == ")")
                {
                    isNoBracket = false;
                }
                if (currentString == "(")
                {
                    isBalanced = false;
                    isFirstBracket = true;

                }
                else if (currentString == ")" && isFirstBracket)
                {
                    isBalanced = true;
                    isFirstBracket = false;
                }


            }
            if (isBalanced || isNoBracket)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
