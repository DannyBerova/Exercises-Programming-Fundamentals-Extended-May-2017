
namespace _01.ReverseString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            StringBuilder output = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                output.Append(input[i]);
            }

            Console.WriteLine(output.ToString()); 
        }
    }
}
