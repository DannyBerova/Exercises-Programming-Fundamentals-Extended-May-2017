
namespace _05.ForeignLanguages
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var countryName = Console.ReadLine();

            switch (countryName)
            {
                case "USA":
                case "England":
                    {
                        Console.WriteLine("English");
                        break;
                    }
                case "Spain":
                case "Argentina":
                case "Mexico":
                    {
                        Console.WriteLine("Spanish");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("unknown");
                    }
                    break;
            }
        }
    }
}
