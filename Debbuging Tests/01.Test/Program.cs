
namespace _01.Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var midict = new Dictionary<string, Dictionary<string, string>>();
            var danceCounter = 0;

            var input = Console.ReadLine();

            while (input != "lambada")
            {
                if (input == "dance")
                {
                    danceCounter++;

                }
                else
                {
                    var mianInput = input.Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries);
                    var selector = mianInput[0];
                    var secondPart = mianInput[1];
                    var secondPartString = secondPart.Split('.');

                    var selectorObject = secondPartString[0];
                    var property = secondPartString[1];

                    if (!midict.ContainsKey(selector))
                    {
                        midict[selector] = new Dictionary<string, string>();

                    }

                        midict[selector][selectorObject] = property;

                }

                input = Console.ReadLine();

            }
            foreach (var item in midict)
            {
                Console.Write($"{item.Key} => ");
                foreach (var pair in item.Value)
                {
                    for (int i = 0; i < danceCounter + 1; i++)
                    {
                        Console.Write($"{pair.Key}.");
                    }
                    Console.WriteLine($"{pair.Value}");
                }
            }
        }
    }
}
