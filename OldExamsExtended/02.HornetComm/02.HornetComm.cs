
namespace _02.HornetComm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            List<string> messages = new List<string>();
            List<string> broadcastsList = new List<string>();

            string input = Console.ReadLine();

            while (input != "Hornet is Green")
            {
                string[] tokens = input
                    .Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length != 2)
                {
                    input = Console.ReadLine();
                    tokens = input
                        .Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }

                var leftPart = tokens[0];
                var rightPart = tokens[1];

                if (leftPart.All(char.IsDigit) && rightPart.All(char.IsLetterOrDigit))
                {
                    var reversingLeftPart = leftPart.ToCharArray().Reverse().ToArray();
                    string reversed = string.Join("", reversingLeftPart);
                    string message = $"{reversed} -> {rightPart}";
                    messages.Add(message);
                }
                else if (leftPart.All(c => !char.IsDigit(c)) && rightPart.All(char.IsLetterOrDigit))
                {
                    StringBuilder result = new StringBuilder();

                    for (int i = 0; i < rightPart.Length; i++)
                    {
                        if (char.IsUpper(rightPart[i]))
                        {
                            result.Append(char.ToLower(rightPart[i]));
                        }
                        else if (char.IsLower(rightPart[i]))
                        {
                            result.Append(char.ToUpper(rightPart[i]));
                        }
                        else
                        {
                            result.Append(rightPart[i]);
                        }
                    }

                    string broadcast = $"{result} -> {leftPart}";
                    broadcastsList.Add(broadcast);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            Console.WriteLine(broadcastsList.Count == 0 ? "None" : string.Join(Environment.NewLine, broadcastsList));
            Console.WriteLine("Messages:");
            Console.WriteLine(messages.Count == 0 ? "None" : string.Join(Environment.NewLine, messages));
        }
    }
}
