
namespace _07.NumbersToWords
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string numberInWords = string.Empty;

            for (int i = 0; i < n; i++)
            {

                int inputNumber = int.Parse(Console.ReadLine());

                if (inputNumber > -99 && inputNumber < 99)
                {
                    continue;
                }
                if (inputNumber > 999)
                {
                    Console.WriteLine("too large");
                }
                else if (inputNumber < -999)
                {
                    Console.WriteLine("too small");
                }
                else if (inputNumber < 99 || inputNumber > 99)
                {
                    numberInWords = Letterize(inputNumber);
                    Console.WriteLine(numberInWords);
                }


            }
        }

        private static string Letterize(int inputNumber)
        {
            
            if (inputNumber == 0)
                return "zero";

            if (inputNumber < 0)
                return "minus " + Letterize(Math.Abs(inputNumber));

            string words = "";

            
            if ((inputNumber / 100) > 0)
            {
                words += Letterize(inputNumber / 100) + "-hundred ";
                inputNumber %= 100;
            }

            if (inputNumber > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsInWords = new[] 
                { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
                    "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen",
                    "seventeen", "eighteen", "nineteen" };
                var tensInWords = new[] 
                { "zero", "ten", "twenty", "thirty", "forty", "fifty",
                    "sixty", "seventy", "eighty", "ninety" };

                if (inputNumber < 20)
                    words += unitsInWords[inputNumber];
                else
                {
                    words += tensInWords[inputNumber / 10];
                    if ((inputNumber % 10) > 0)
                    {
                        words += " " + unitsInWords[inputNumber % 10];
                    }
                }
            }

            return words; 
        }
    }
}
