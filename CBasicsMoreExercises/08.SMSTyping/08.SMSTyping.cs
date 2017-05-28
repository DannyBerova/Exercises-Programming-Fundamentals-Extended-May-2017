
namespace _08.SMSTyping
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int numberOfCharacters = int.Parse(Console.ReadLine());
            string result = string.Empty;

            for (int sequence = 0; sequence < numberOfCharacters; sequence++)
            {
                string digits = Console.ReadLine();
                int mainDigit = int.Parse(digits[0].ToString());
                int offset = (mainDigit - 2) * 3;
                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset += 1;
                }

                int letterIndex = offset + digits.Length - 1;

                if (mainDigit == 0)
                {
                    result += " ";
                }
                else
                {
                    result += (char)(letterIndex + 97);
                }
            }
            Console.WriteLine(result);

        }
    }
}
