
namespace _13.DecryptingMessage
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int key = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());

            string message = string.Empty;
            for (int i = 0; i < lines; i++)
            {
                char character = char.Parse(Console.ReadLine());
                character += (char)key;
                message += character;

            }
            Console.WriteLine(message);
        }
    }
}
