
namespace _15.Calculator
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int firstOperand = int.Parse(Console.ReadLine());
            char operatorChar = char.Parse(Console.ReadLine());
            int secondOperand = int.Parse(Console.ReadLine());

            int result = 0;
            switch (operatorChar)
            {
                case '+':
                    result = firstOperand + secondOperand;
                    break;
                case '-':
                    result = firstOperand - secondOperand;
                    break;
                case '*':
                    result = firstOperand * secondOperand;
                    break;
                case '/':
                    result = firstOperand / secondOperand;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{firstOperand} {operatorChar} {secondOperand} = {result}");

        }
    }
}
