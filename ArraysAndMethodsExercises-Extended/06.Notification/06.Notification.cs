
namespace _06.Notification
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string output = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string result = Console.ReadLine();


                if (result == "success")
                {
                    string operation = Console.ReadLine();
                    string message = Console.ReadLine();
                    output = ShowSuccess(operation, message);
                    Console.WriteLine(output);
                }
                else if (result == "error")
                {
                    string operation = Console.ReadLine();
                    int code = int.Parse(Console.ReadLine());
                    output = ShowError(operation, code);
                    Console.WriteLine(output);
                }
                else
                {
                    continue;
                }
            }
        }

        private static string ShowError(string operation, int code)
        {
            string reason = "Invalid Client Data";
            if (code < 0)
            {
                reason = "Internal System Failure";
            }

            string output = $@"Error: Failed to execute {operation}.
==============================
Error Code: {code}.
Reason: {reason}.";

            return output;
        }
        private static string ShowSuccess(string operation, string message)
        {
            string output = $@"Successfully executed {operation}.
==============================
Message: {message}.";

            return output;
        }
    }
}
