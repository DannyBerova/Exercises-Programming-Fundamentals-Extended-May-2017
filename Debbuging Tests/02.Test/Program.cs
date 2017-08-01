using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            var theList = new Dictionary<string, User>();
            string input = Console.ReadLine();
            string sender;
            string recipient;

            while (input != "exit")
            {
                string[] inputData = input.Split(' ');
                if (inputData[0] == "register")
                {
                    string userName = inputData[1];

                    theList.Add(userName, new User(userName));

                }
                else
                {
                    sender = inputData[0];
                    recipient = inputData[2];
                    string content = inputData[3];
                    if (theList.ContainsKey(sender) && theList.ContainsKey(recipient))
                    {
                        Message message = new Message(theList[sender], content);
                        theList[sender].Messages.Add(message);
                    }
                }
                input = Console.ReadLine();
            }
            string newInput = Console.ReadLine();
            sender = newInput.Split(' ').First();
            recipient = newInput.Split(' ').Last();
            int cnt = Math.Max(theList[sender].Messages.Count, theList[recipient].Messages.Count);
            if (theList[sender].Messages.Count == 0 && theList[recipient].Messages.Count == 0)
            {
                Console.WriteLine("No messages");
            }
            else
            {


                if (theList.ContainsKey(sender) && theList.ContainsKey(recipient))
                {
                    for (int i = 0; i < cnt; i++)
                    {
                        foreach (var user in theList)
                        {
                            if (user.Key == sender)
                            {
                                if (user.Value.Messages.Count > i)
                                {

                                    Console.WriteLine($"{user.Key}: {user.Value.Messages[i].Content}");
                                }
                            }
                            else if (user.Key == recipient)
                            {
                                if (user.Value.Messages.Count > i)
                                {
                                    Console.WriteLine($"{user.Value.Messages[i].Content} :{user.Key}");
                                }
                            }

                        }
                    }

                }
            }
        }

        class User
        {
            public string Name { get; set; }
            public List<Message> Messages { get; set; }

            public User(string name)
            {
                Name = name;
                Messages = new List<Message>();
            }


        }

        class Message
        {
            public User Sender { get; set; }
            public string Content { get; set; }

            public Message(User sender, string content)
            {
                Sender = sender;
                Content = content;
            }
        }
    }
}