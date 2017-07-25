
namespace _04.MergeFiles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            string[] fileOne = File.ReadAllLines("FileOne.txt");
            string[] fileTwo = File.ReadAllLines("FileTwo.txt");

            string[] mergedLists = fileOne
                .Concat(fileTwo)
                .OrderBy(x => x)
                .ToArray();

            File.AppendAllText("MergeFiles.txt",
                string.Join(Environment.NewLine, mergedLists));
        }
    }
}
