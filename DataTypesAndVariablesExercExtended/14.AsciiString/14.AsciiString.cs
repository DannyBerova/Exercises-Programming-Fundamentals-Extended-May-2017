
namespace _14.AsciiString
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string output = string.Empty;
            for (int i = 0; i < n; i++)
            {
                int inputAscii = int.Parse(Console.ReadLine());
                output += (char)inputAscii;
            }
            Console.WriteLine(output);
        }
    }
}
