
namespace _06.IntervalOfNumbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int first = firstNumber;
            int second = secondNumber;

            if(secondNumber < firstNumber)
            {
                first = secondNumber;
                second = firstNumber;
            }

            for (int i = first; i <= second; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
