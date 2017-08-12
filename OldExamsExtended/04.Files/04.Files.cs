
namespace _04.Files
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var filesByRoot = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, string> filesWithExt = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split('\\');

                string root = tokens[0];

                string[] fileParts = tokens[tokens.Length - 1].Split(';');

                string fileWithExtension = fileParts[0];
                long fileSize = long.Parse(fileParts[1]);

                string fileName = fileWithExtension;
                string fileExt = fileName.Split('.')[fileName.Split('.').Length - 1];

                if (!filesByRoot.ContainsKey(root))
                {
                    filesByRoot[root] = new Dictionary<string, long>();
                }

                filesByRoot[root][fileName] = fileSize;
                filesWithExt[fileName] = fileExt;
            }

            string[] queryParts = Console.ReadLine().Split(' ');

            string queryExtension = queryParts[0];
            string queryRoot = queryParts[2];

            Dictionary<string, long> selectedFiles = new Dictionary<string, long>();

            if (filesByRoot.ContainsKey(queryRoot))
            {
                foreach (var file in filesByRoot[queryRoot])
                {
                    if (filesWithExt[file.Key] == queryExtension)
                    {
                        selectedFiles.Add(file.Key, file.Value);
                    }
                }
            }

            if (selectedFiles.Count > 0)
            {
                foreach (var file in selectedFiles.OrderByDescending(f => f.Value)
                    .ThenBy(f => f.Key))
                {
                    Console.WriteLine($"{file.Key} - {file.Value} KB");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
