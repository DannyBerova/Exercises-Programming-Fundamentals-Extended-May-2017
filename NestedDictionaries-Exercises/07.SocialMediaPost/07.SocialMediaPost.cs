
namespace _07.SocialMediaPost
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var socialMediaPosts = new Dictionary<string, Dictionary<string, List<string>>>();
            var inputLine = Console.ReadLine();

            while (inputLine != "drop the media")
            {
                var inputData = inputLine.Split(' ').ToArray();
                var command = inputData[0];
                var postName = inputData[1];

                if (!socialMediaPosts.ContainsKey(postName))
                {
                    socialMediaPosts[postName] = new Dictionary<string, List<string>>();
                }

                if (command == "like")
                {
                    if (!socialMediaPosts[postName].ContainsKey("Like"))
                    {
                        socialMediaPosts[postName]["Like"] = new List<string>();
                    }

                    socialMediaPosts[postName]["Like"].Add(command);
                }
                else if (command == "dislike")
                {
                    if (!socialMediaPosts[postName].ContainsKey("Dislike"))
                    {
                        socialMediaPosts[postName]["Dislike"] = new List<string>();
                    }

                    socialMediaPosts[postName]["Dislike"].Add(command);
                }
                else if (command == "comment")
                {
                    var commenter = inputData[2];
                    int combinedLenght = command.Length + postName.Length + commenter.Length + 3;
                    var comment = inputLine.Substring(combinedLenght);

                    if (!socialMediaPosts[postName].ContainsKey(commenter))
                    {
                        socialMediaPosts[postName][commenter] = new List<string>();
                    }

                    socialMediaPosts[postName][commenter].Add(comment);
                }

                inputLine = Console.ReadLine();
            }

            foreach (var post in socialMediaPosts)
            {
                var likes = 0;
                var dislikes = 0;
                var commenters = post.Value;

                foreach (var item in post.Value)
                {
                    if (item.Key == "Like")
                    {
                        likes = item.Value.Count;
                    }
                    else if (item.Key == "Dislike")
                    {
                        dislikes = item.Value.Count;
                    }
                }

                Console.WriteLine($"Post: {post.Key} | Likes: {likes} | Dislikes: {dislikes}");
                Console.WriteLine("Comments:");

                bool noComment = true;

                foreach (var comment in commenters)
                {
                    if (comment.Key != "Like" && comment.Key != "Dislike")
                    {
                        noComment = false;

                        foreach (var each in comment.Value)
                        {
                            Console.WriteLine($"*  {comment.Key}: {each}");
                        }
                    }
                }

                if (noComment)
                {
                    Console.WriteLine("None");
                }
            }
        }
    }
}