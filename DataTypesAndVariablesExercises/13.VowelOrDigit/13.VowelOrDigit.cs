
namespace _13.VowelOrDigit
{
    using System;

    public class Program
    {
        public static void Main()
        {
            char givenSymbol = char.Parse(Console.ReadLine());

            if (givenSymbol == 'a' || givenSymbol == 'o'
                || givenSymbol == 'u' || givenSymbol == 'e' 
                || givenSymbol == 'i') 
            {
                Console.WriteLine("vowel");
            }
            else if (givenSymbol >= '0' && givenSymbol <= '9')
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
