
namespace _01.BlankReceipt
{
    using System;

    public class Program
    {
        public static void Main()
        {
            PrintReceipt();
        }

        private static void PrintReceipt()
        {
            PrintRecieptHeader();
            PrintRecieptBody();
            PrintRecieptFooter();
        }

        private static void PrintRecieptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        private static void PrintRecieptBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        private static void PrintRecieptFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine(@"© SoftUni");
        }

    }
}
