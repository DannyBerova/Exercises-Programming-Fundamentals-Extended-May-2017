
namespace _05.UserLogins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {

            string[] inputInfo = Console.ReadLine()
                .Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var nameAndPassword = new Dictionary<string, string>();

            while (inputInfo[0] != "login")
            {
                string name = inputInfo[0];
                string password = inputInfo[2];

                if (!nameAndPassword.ContainsKey(name))
                {
                    nameAndPassword[name] = string.Empty;
                }
                nameAndPassword[name] = password;

                inputInfo = Console.ReadLine()
                .Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            inputInfo = Console.ReadLine()
                .Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int failsCounter = 0;

            //Chek if the user give us the correct data
            while (inputInfo[0] != "end")
            {
                string name = inputInfo[0];
                string password = inputInfo[2];

                if (nameAndPassword.ContainsKey(name) && nameAndPassword.ContainsValue(password))
                {
                    Console.WriteLine($"{name}: logged in successfully");
                }
                else
                {
                    Console.WriteLine($"{name}: login failed");
                    failsCounter++;
                }

                inputInfo = Console.ReadLine()
                .Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine($"unsuccessful login attempts: {failsCounter}");
        }
    }
}