
namespace _06.SentenceSplit
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string sentence = Console.ReadLine();
            string delimiter = Console.ReadLine();

            sentence = sentence.Replace(delimiter, "papoi");

            string[] elements = sentence
                .Split(new string[] { "papoi" }, StringSplitOptions.None);

            Console.WriteLine("[" + string.Join(", ", elements) + "]");
        }
    }
}
