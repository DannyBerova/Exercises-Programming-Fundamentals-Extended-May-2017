
namespace _06.Messages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    class Message
    {
        public string Content { get; set; }

        public User Sender { get; set; }
    }

    class User
    {
        public string Username { get; set; }

        public List<Message> RecievedMessages { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            Dictionary<string, User> users = new Dictionary<string, User>();

            string inputLine = Console.ReadLine();

            while (inputLine != "exit")
            {
                string[] tokens = inputLine.Split();

                if (tokens[0] == "register")
                {
                    string newUsername = tokens[1];
                    users.Add(newUsername, new User()
                    {
                        Username = newUsername,
                        RecievedMessages = new List<Message>()
                    });
                }
                else
                {
                    string sender = tokens[0];
                    string recipient = tokens[2];
                    string content = tokens[3];

                    if (users.ContainsKey(sender) && users.ContainsKey(recipient))
                    {
                        User senderName = users[sender];
                        users[recipient]
                            .RecievedMessages
                            .Add(new Message()
                        { Content = content, Sender = senderName });
                    }
                }

                inputLine = Console.ReadLine();
            }

            inputLine = Console.ReadLine();
            string[] messagesPair = inputLine.Split();
            string firstAuthor = messagesPair[0];
            string secondAuthor = messagesPair[1];

            List<Message> firstAuthorMessages = users[secondAuthor]
                .RecievedMessages
                .Where(m => m.Sender.Username == firstAuthor)
                .ToList();

            List<Message> secondtAuthorMessages = users[firstAuthor]
                .RecievedMessages
                .Where(m => m.Sender.Username == secondAuthor)
                .ToList();

            int maxCount = Math.Max
                (firstAuthorMessages.Count, secondtAuthorMessages.Count);

            if (firstAuthorMessages.Count == 0 && secondtAuthorMessages.Count == 0)
            {
                Console.WriteLine("No messages");
            }
            else
            {
                for (int i = 0; i < maxCount; i++)
                {
                    if (i < firstAuthorMessages.Count)
                    {
                        Console.WriteLine($"{firstAuthor}: {firstAuthorMessages[i].Content}");
                    }
                    if (i < secondtAuthorMessages.Count)
                    {
                        Console.WriteLine($"{secondtAuthorMessages[i].Content} :{secondAuthor}");
                    }
                }
            }
        }
    }
}
