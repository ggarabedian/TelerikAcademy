namespace ExtractAndSortStudents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    /*
    01. A text file students.txt holds information about students and their courses in the following format:
    Using SortedDictionary<K,T> print the courses in alphabetical order and for each of them prints the students 
    ordered by family and then by name. Expected result:
        C#: Ivan Grigorov, Kiril Ivanov, Milena Petrova
        Java: Stela Mineva
        SQL: Ivan Kolev, Stefka Nikolova
    */
    public class Startup
    {
        public static void Main()
        {
            string filePath = "../../students.txt";
            var courseAndStudentsDict = new SortedDictionary<string, List<Student>>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    var studentAndCourse = line.Split('|');
                    var studentFirstname = studentAndCourse[0].Trim();
                    var studentLastName = studentAndCourse[1].Trim();
                    var courseName = studentAndCourse[2].Trim();

                    var currentStudent = new Student(studentFirstname, studentLastName);

                    if (courseAndStudentsDict.ContainsKey(courseName))
                    {
                        courseAndStudentsDict[courseName].Add(currentStudent);
                    }
                    else
                    {
                        courseAndStudentsDict.Add(courseName, new List<Student> { currentStudent });
                    }
                }
            }

            foreach (var course in courseAndStudentsDict)
            {
                Console.Write("{0}: ", course.Key);

                var orderedStudents = course.Value
                                            .OrderBy(st => st.LastName)
                                            .ThenBy(st => st.FirstName);

                Console.WriteLine(string.Join(", ", orderedStudents));
            }
        }
    }
}
