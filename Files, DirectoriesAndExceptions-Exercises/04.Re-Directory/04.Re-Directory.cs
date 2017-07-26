
namespace _04.Re_Directory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            string[] files = Directory.GetFiles("input");

            foreach (var file in files)
            {
                string extention = file.Substring(file.LastIndexOf(".") + 1);

                if (!Directory.Exists(extention + "s"))
                {
                    Directory.CreateDirectory(extention + "s");
                }

                string folderName = file.Substring(file.LastIndexOf(@"\"));
                Directory.Move(file, extention + "s\\" + folderName);
            }
        }
    }
}
