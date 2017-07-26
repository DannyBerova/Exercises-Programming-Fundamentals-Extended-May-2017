
namespace _03.UserDatabase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    class User
    {
        public string Username { get; set; }
        public string Pass { get; set; }
        public bool IsLogged { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            string pathDB = "../../usersDB.txt";
            string[] database = File.ReadAllLines(pathDB);

            Dictionary<string, User> users = new Dictionary<string, User>();

            foreach (var userData in database)
            {
                string[] tokens = userData.Split();

                User user = new User()
                {
                    Username = tokens[0],
                    Pass = tokens[1],
                    IsLogged = bool.Parse(tokens[2])
                };

                users.Add(user.Username, user);
            }

            while (true)
            {
                string[] tokens = Console.ReadLine().Split();
                string command = tokens[0];

                if (command == "exit")
                {
                    break;
                }

                switch (command)
                {
                    case "register":
                        string username = tokens[1];
                        string pass = tokens[2];
                        string confirmPass = tokens[3];

                        if (users.ContainsKey(username))
                        {
                            Console.WriteLine("The given username already exists.");
                        }
                        else if (confirmPass != pass)
                        {
                            Console.WriteLine("The two passwords must match.");
                        }
                        else
                        {
                            User newUser = new User
                            {
                                Username = username,
                                Pass = pass,
                                IsLogged = false
                            };
                            users.Add(newUser.Username, newUser);
                        }
                        break;

                    case "login":
                        username = tokens[1];
                        
                        pass = tokens[2];

                        if (!users.ContainsKey(username))
                        {
                            Console.WriteLine("There is no user with the given username.");
                        }
                        else if (users[username].Pass != pass)
                        {
                            Console.WriteLine("The DATA you entered is incorrect.");
                        }
                        else
                        {
                            users[username].IsLogged = true;
                        }
                        break;
                    case "logout":
                        username = tokens[1];

                        
                        if (!users[username].IsLogged)
                        {
                            Console.WriteLine("This user is not logged in.");
                        }
                        else if (!users.ContainsKey(username))
                        {
                            Console.WriteLine("There is no user with the given username.");
                        }
                        else
                        {
                            users[username].IsLogged = false;
                        }
                        break;
                }
            }
            foreach (var user in users)
            {
                File.WriteAllLines(pathDB,
                    users
                    .Values
                    .Select(u => $"{u.Username} {u.Pass} {u.IsLogged}")
                    .ToArray());
            }
        }
    }
}
