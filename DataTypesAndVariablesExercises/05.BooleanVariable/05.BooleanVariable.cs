
namespace _05.BooleanVariable
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string boolean = Console.ReadLine();
            bool isTrue = Convert.ToBoolean(boolean);

            if (isTrue)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
