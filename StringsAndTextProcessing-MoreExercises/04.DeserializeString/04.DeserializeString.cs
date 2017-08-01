
namespace _04.DeserializeString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            string line = Console.ReadLine();
            StringBuilder output = new StringBuilder(new string(' ', 200));
            
            while (line != "end")
            {
                string[] tokens = line
                .Split(new[] { ':', '/' },
                StringSplitOptions.RemoveEmptyEntries);

                string symbol = tokens[0];
                int[] indexes = tokens.Skip(1).Select(int.Parse).ToArray();

                for (int i = 0; i < indexes.Length; i++)
                {
                    int indeX = indexes[i];
                    //if (indeX >= output.Length - 1)
                    //{
                    //    output.Append(new string(' ', 200));
                    //}
                    //if (symbol.Length == 1)
                    //{
                        output.Replace(" ", symbol, indeX, 1);
                    //}
                }

                line = Console.ReadLine();
            }

            Console.WriteLine(output.ToString().Trim());
        }
    }
}
