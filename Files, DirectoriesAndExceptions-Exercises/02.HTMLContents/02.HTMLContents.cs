
namespace _02.HTMLContents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            string[] inputLines = File.ReadAllLines("../../Input.txt");

            string title = string.Empty;
            List<string> bodyParts = new List<string>();

            foreach (var inputLine in inputLines)
            {
                if (inputLine == "exit")
                {
                    break;
                }

                var command = inputLine.Split().ToArray();
                string tag = command[0];
                string tagContent = command[1];

                if (tag == "title")
                {
                    title = tagContent;
                }
                else
                {
                    bodyParts.Add($"\t<{tag}>{tagContent}</{tag}>");
                }
            }

            var output = new StringBuilder();

            output.AppendLine("<!DOCTYPE html>");
            output.AppendLine("<html>");
            output.AppendLine("<head>");

            if (title != string.Empty)
            {
                output.AppendLine($"\t<title>{title}</title>");
            }

            output.AppendLine("</head>");
            output.AppendLine("<body>");

            if (bodyParts.Any())
            {
                output.AppendLine(string.Join
                    (Environment.NewLine, bodyParts));
            }

            output.AppendLine("</body>");
            output.AppendLine("</html>");

            File.WriteAllText("index.html", 
                output.ToString().Trim());
        }
    }
}
