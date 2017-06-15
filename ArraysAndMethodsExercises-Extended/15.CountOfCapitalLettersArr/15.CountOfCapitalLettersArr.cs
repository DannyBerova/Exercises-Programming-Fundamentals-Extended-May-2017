
namespace _15.CountOfCapitalLettersArr
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] stringArray = Console.ReadLine().Split(' ');
            int countCapital = 0;

            for (int i = 0; i < stringArray.Length; i++)
            {
                string currentElement = stringArray[i];

                if (currentElement.Length == 1)
                {
                    if (currentElement[0] >= 'A' && currentElement[0] <= 'Z')
                    {
                        countCapital++;
                    }
                }
            }

            Console.WriteLine(countCapital);
        }
    }
}
