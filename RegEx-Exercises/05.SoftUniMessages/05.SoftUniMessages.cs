
namespace _05.SoftUniMessages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            int searchedLenght = 0;

            //string pattern = $@"^\d+([a-zA-Z]{{{searchedLenght}}})[^a-zA-Z\s]*(\d+)$";
            //Regex regex = new Regex($@"^\d+([a-zA-Z]{{{searchedLenght}}})[^a-zA-Z\s]*(\d+)$");

            while (true)
            {
                string encryptedMessage = Console.ReadLine();
                if (encryptedMessage == "Decrypt!")
                {
                    break;
                }

                searchedLenght = int.Parse(Console.ReadLine());
                Regex regex = new Regex($@"^\d+([a-zA-Z]{{{searchedLenght}}})[^a-zA-Z\s]*(\d+)$");


                Match message = regex.Match(encryptedMessage);
                if (message.Success)
                {
                    char[] symbols = encryptedMessage.ToCharArray();
                    List<char> letters = new List<char>();
                    List<int> digits = new List<int>();
                    StringBuilder decrypted = new StringBuilder();

                    for (int i = 0; i < symbols.Length; i++)
                    {
                        if (Char.IsDigit(symbols[i]))
                        {
                            digits.Add(symbols[i] - '0');
                        }
                        if (Char.IsLetter(symbols[i]))
                        {
                            letters.Add(symbols[i]);
                        }
                    }

                    if (searchedLenght < letters.Count)
                    {
                        continue;
                    }
                    else
                    {
                        for (int i = 0; i < digits.Count; i++)
                        {
                            int index = digits[i];
                            if (index < letters.Count)
                            {
                                char currentLetter = letters[index];
                                decrypted.Append(currentLetter);
                            }
                        }
                    }

                    Console.WriteLine($"{string.Join("", letters)} = {decrypted.ToString()}");

                }

            }
        }
    }
}