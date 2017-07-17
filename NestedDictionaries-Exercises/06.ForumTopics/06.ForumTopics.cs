
namespace _06.ForumTopics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static Dictionary<string, HashSet<string>> forumTopicsData = new Dictionary<string, HashSet<string>>();

        public static void Main()
        {
            var forumTopicsData = new Dictionary<string, HashSet<string>>();
            var currentLine = Console.ReadLine();

            while (currentLine != "filter")
            {
                var currentData = currentLine
                    .Split(new[] { " -> ", ", " }, StringSplitOptions.RemoveEmptyEntries);
                var topic = currentData[0];
                var tags = currentData.Skip(1).ToArray();

                if (!forumTopicsData.ContainsKey(topic))
                {
                    forumTopicsData[topic] = new HashSet<string>();
                }

                AddTagsToTopic(forumTopicsData, topic, tags);

                currentLine = Console.ReadLine();
            }

            var filteredTags = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            PrintTopicsWithFilteredTags(forumTopicsData, filteredTags);
        }

        static void AddTagsToTopic(
            Dictionary<string, HashSet<string>> forumTopicsData, string topic, string[] tags)
        {
            foreach (var tag in tags)
            {
                forumTopicsData[topic].Add($"#{tag}");
            }
        }

        static void PrintTopicsWithFilteredTags(
            Dictionary<string, HashSet<string>> forumTopicsData, string[] filteredTags)
        {
            foreach (var topic in forumTopicsData)
            {
                var containsAllTags = true;

                foreach (var tag in filteredTags)
                {
                    if (!topic.Value.Contains($"#{tag}"))
                    {
                        containsAllTags = false;
                    }
                }

                if (containsAllTags)
                {
                    Console.WriteLine($"{topic.Key} | {string.Join(", ", topic.Value)}");
                }
            }
        }
    }
}
