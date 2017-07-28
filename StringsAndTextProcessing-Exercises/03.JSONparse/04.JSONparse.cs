
namespace _04.JSONparse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    //class Student
    //{
    //    public string Name { get; set; }
    //
    //    public int Age { get; set; }
    //
    //    public List<int> Grades { get; set; }
    //}

    public class Program
    {
        public static void Main()
        {
            //List<Student> students = new List<Student>();

            string jsonText = Console.ReadLine();

            string[] studentLine = jsonText.Trim('[')
                .Split(new string[] { "},{" }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < studentLine.Length; i++)
            {
                string student = studentLine[i];
                student = student
                    .Replace(":[]", ":[None]")
                    .Replace("]", string.Empty)
                    .Replace("\"", string.Empty)
                    .Replace("{", string.Empty)
                    .Replace("}", string.Empty)
                    .Replace("name:", string.Empty)
                    .Replace(",age:", " : ")
                    .Replace(",grades:[", " -> ")
                    .Replace("]}", string.Empty);
            
                Console.WriteLine(student);
            }
           //for (int i = 0; i < studentLine.Length; i++)
           //{
           //    string st = studentLine[i].Replace("[]", "[None]");
           //    string[] student = st.
           //        Split(new string[] { "{", "name:", ",age:", ",grades:", "}]", "\"" , },
           //        StringSplitOptions.RemoveEmptyEntries);
           //
           //    string name = student[0];
           //    string age = student[1];
           //    string grades = student[2].Trim('[', ']');
           //
           //    Console.WriteLine($"{name} : {age} -> {grades}");
            //}
        }
    }
}
