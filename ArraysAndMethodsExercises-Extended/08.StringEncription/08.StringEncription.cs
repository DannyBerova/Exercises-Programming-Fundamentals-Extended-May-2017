
namespace _08.StringEncription
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string encryptedString = string.Empty;
            for (int i = 0; i < n; i++)
            {
                char inputChar = char.Parse(Console.ReadLine());
                encryptedString += EncryptChars(inputChar);
            }

            Console.WriteLine(encryptedString);
        }

        private static string EncryptChars(char inputChar)
        {
            string append = string.Empty;
            int firstDigit = GetFirstDigit(inputChar);
            int lastDigit = GetLastDigit(inputChar);
            char firstEncryptedPart = (char)(inputChar + lastDigit);
            char secondEncryptedPart = (char)(inputChar - firstDigit);
            append = $"{firstEncryptedPart}{firstDigit}{lastDigit}{secondEncryptedPart}";
            return append;

        }

        private static int GetFirstDigit(char inputChar)
        {
            int digit = 0;
            while ((int)inputChar != 0)
            {
                digit = inputChar % 10;
                inputChar = (char)(inputChar / 10);
            }
            return digit;
        }

        private static int GetLastDigit(char inputChar)
        {
            int digit = 0;
            return digit = inputChar % 10;
        }
    }
}
