namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Test
    {
        public static void Main()
        {
            List<Student> listOfStudents = new List<Student>();

            listOfStudents.Add(new Student("Georgi", "Georgiev", "1211062652", "8583423", "GeorgeG@abv.bg", 3, new List<int>() { 6, 4 }));
            listOfStudents.Add(new Student("Ivan", "Petrov", "1703052352", "02564896", "Ivan@gmail.bg", 2, new List<int>() { 3, 5 }));
            listOfStudents.Add(new Student("George", "Stoyanov", "1202052352", "8861723", "GeorgeS@abv.bg", 4, new List<int>() { 3, 4, 4 }));
            listOfStudents.Add(new Student("Stoyan", "Ivanov", "1602012327", "8986572", "Stoyan@yahoo.bg", 4, new List<int>() { 4, 6 }));
            listOfStudents.Add(new Student("Grigor", "Stanev", "1205062351", "02126985", "Grigor@abv.bg", 2, new List<int>() { 6, 5, 6 }));
            listOfStudents.Add(new Student("Petyr", "Yanev", "2107062352", "8658938", "Petyr@yahoo.bg", 2, new List<int>() { 5, 4 }));
            listOfStudents.Add(new Student("Asen", "Georgiev", "1202032350", "02888598", "Asen@abv.bg", 1, new List<int>() { 6, 5, 6, 4 }));
            listOfStudents.Add(new Student("Borislav", "Bojilov", "1209062392", "8996875", "Borislav@gmail.bg", 3, new List<int>() { 5, 6, 4 }));

/*
Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
Create a List<Student> with sample students. Select only the students that are from group number 2.
Use LINQ query. Order the students by FirstName.
*/

            IEnumerable<Student> studentsFromSecondGroupLinq = from student in listOfStudents
                                                               where student.GroupNumber == 2
                                                               orderby student.FirstName
                                                               select student;

            PrintResult(studentsFromSecondGroupLinq, "Students from second group using Linq");

/*
Implement the previous using the same query expressed with extension methods.
*/

            var studentsFromSecondGroupLambda = listOfStudents.Where(st => st.GroupNumber == 2)
                                                              .OrderBy(st => st.FirstName);

            PrintResult(studentsFromSecondGroupLambda, "Students from second group using Lambda");

/*
Extract all students that have email in abv.bg.
Use string methods and LINQ.
*/

            var studentsWithAbvMail = from student in listOfStudents
                                      where student.Email.Contains("abv.bg")
                                      orderby student.FirstName
                                      select student;

            PrintResult(studentsWithAbvMail, "Students with abv.bg email");

/*
Extract all students with phones in Sofia.
Use LINQ. 
*/

            var studentsFromSofia = from student in listOfStudents
                                    where student.PhoneNumber.StartsWith("8")
                                    orderby student.FirstName
                                    select student;

            PrintResult(studentsFromSofia, "Students from Sofia");


/*
Select all students that have at least one mark Excellent (6) into a new anonymous class that 
has properties – FullName and Marks.
Use LINQ.
*/

            var studentsByExcellence = from student in listOfStudents
                                  where student.Marks.Contains(6)
                                  select new { FullName = student.ToString(), Marks = student.Marks };

            Console.WriteLine(new string('*', 50));
            Console.WriteLine("Students with at least one excellent mark");
            Console.WriteLine(new string('*', 50));

            foreach (var st in studentsByExcellence)
            {
                Console.WriteLine("{0} [{1}]", st.FullName, string.Join(", ", st.Marks));
            }
            Console.WriteLine();

/*
Write down a similar program that extracts the students with exactly two marks "2".
Use extension methods.
*/
            var studentsWithTwoMarks = listOfStudents.Where(st => st.Marks.Count == 2)
                                                     .Select(st => new { FullName = st.ToString(), Marks = st.Marks });

            Console.WriteLine(new string('*', 50));
            Console.WriteLine("Students with exactly two marks");
            Console.WriteLine(new string('*', 50));

            foreach (var st in studentsWithTwoMarks)
            {
                Console.WriteLine("{0} [{1}]", st.FullName, string.Join(", ", st.Marks));
            }
            Console.WriteLine();


/*
Extract all Marks of the students that enrolled in 2006. 
(The students from 2006 have 06 as their 5-th and 6-th digit in the FN). 
*/

            var studentsFrom2006 = from student in listOfStudents
                                   where student.FN[5] == '6'
                                   select student;

            PrintResult(studentsFrom2006, "Students that enrolled 2006");

/*
Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
Use LINQ. 
*/

            var studentsByGroupNumberLinq = from student in listOfStudents
                                        orderby student.GroupNumber
                                        select student;

            PrintResult(studentsByGroupNumberLinq, "Students grouped by GroupNumber using Linq");

/*
Rewrite the previous using extension methods. 
*/

            var studentsByGroupNumberLambda = listOfStudents.OrderBy(st => st.GroupNumber);

            PrintResult(studentsByGroupNumberLambda, "Students grouped by GroupNumber using Lambda");
        }

        private static void PrintResult(IEnumerable<Student> listToPrint, string problem)
        {
            Console.WriteLine(new string('*', 50));
            Console.WriteLine(problem);
            Console.WriteLine(new string('*', 50));
            foreach (var st in listToPrint)
            {
                Console.WriteLine("{0} {1}", st.FirstName, st.LastName);
            }
            Console.WriteLine();
        }   
    }
}
