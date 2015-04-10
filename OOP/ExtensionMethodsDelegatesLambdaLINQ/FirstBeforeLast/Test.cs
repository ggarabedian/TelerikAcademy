namespace FirstBeforeLast
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Test
    {
        static void Main()
        {
            var listOfStudents = new List<Student>()
                {
                    { new Student("Petyr", "Ivanov", 25) },
                    { new Student("Ivan", "Petrov", 18) },
                    { new Student("Stoyan", "Petrov", 22) },
                    { new Student("Aleksandur", "Stanev", 29) },
                    { new Student("Asen", "Grigorov", 33) },
                    { new Student("Georgie", "Zahariev", 23) },
                    { new Student("Asen", "Antonov", 23) }
                };

/*
Write a method that from a given array of students finds all students whose first name is 
before its last name alphabetically. Use LINQ query operators.
*/

            var sortedByName = from ls in listOfStudents
                               where ls.FirstName.CompareTo(ls.LastName) < 0
                               orderby ls.FirstName
                               select ls;

            Console.WriteLine("Students who's first name is before their last name alphabetically: ");
            foreach (var student in sortedByName)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            Console.WriteLine(new string('*', 70));
/*
Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
*/

            var sortedByAge = from st in listOfStudents
                              where st.Age >= 18 && st.Age <= 24
                              select st;

            Console.WriteLine("First and last name of all students aged between 18 and 24: ");
            foreach (var student in sortedByAge)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            Console.WriteLine(new string('*', 70));

/*
Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by 
first name and last name in descending order. Rewrite the same with LINQ.
*/

            var sortedDescending = listOfStudents.OrderByDescending(st => st.FirstName)
                                                 .ThenByDescending(st => st.LastName);
            //var sortedDescending = from st in listOfStudents
            //                       orderby st.FirstName descending, st.LastName descending 
            //                       select st;

            Console.WriteLine("Students in descending order by first name, then by last name: ");
            foreach (var student in sortedDescending)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}
