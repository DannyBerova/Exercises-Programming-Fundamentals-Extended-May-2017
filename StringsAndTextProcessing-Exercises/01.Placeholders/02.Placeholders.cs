
namespace _02.Placeholders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] tokens = inputLine
                    .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string sentence = tokens[0];
                string[] placeholders = tokens[1]
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < placeholders.Length; i++)
                {
                    string currentPlaceholder = "{" + i + "}";
                    sentence = sentence.Replace(currentPlaceholder, placeholders[i]);
                }

                Console.WriteLine(sentence);

                inputLine = Console.ReadLine();
            }
        }
    }
}
