namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Test
    {
        static void Main()
        {
            // Students
            Console.WriteLine("Students List");
            List<Student> listOfStudents = new List<Student>
            {
                new Student("Georgi", "Ivanov", 5),
                new Student("Ivan", "Petrov", 4),
                new Student("Petyr", "Petrov", 3),
                new Student("Stoyan", "Spasov", 3),
                new Student("Ivan", "Georgiev", 6),
                new Student("Asen", "Yankov", 3),
                new Student("Yasen", "Petrov", 4),
                new Student("Borislav", "Todorov", 5),
                new Student("Todor", "Bojanov", 5),
                new Student("Hristo", "Goshev", 6)
            };

            var orderedStudents = listOfStudents.OrderBy(st => st.Grade);

            foreach (var student in orderedStudents)
            {
                Console.WriteLine("{0} {1} - {2}", student.FirstName, student.LastName, student.Grade);
            }

            Console.WriteLine(new string('*', 25));

            // Workers
            Console.WriteLine("Workers List");
            List<Worker> listOfWorkers = new List<Worker>
            {
                new Worker("Yavor", "Petrov", 200.0m, 8),
                new Worker("Georgi", "Stoyanov", 150.0m, 6),
                new Worker("Vasil", "Toshev", 400.0m, 8),
                new Worker("Ivaylo", "Asenov", 300.0m, 8),
                new Worker("Nikolay", "Georgiev", 100.0m, 4),
                new Worker("Evgeni", "Yankov", 125.0m, 4),
                new Worker("Jivko", "Donchev", 250.0m, 6),
                new Worker("Doncho", "Todorov", 500.0m, 6),
                new Worker("Kosta", "Bojanov", 400.0m, 6),
                new Worker("Hristo", "Tzonev", 300.0m, 5)
            };

            var orderedWorkers = listOfWorkers.OrderByDescending(w => w.MoneyPerHour());

            foreach (var worker in orderedWorkers)
            {
                Console.WriteLine("{0} {1} - {2:F2}", worker.FirstName, worker.LastName, worker.MoneyPerHour());
            }
            Console.WriteLine(new string('*', 25));

            // Combined List
            Console.WriteLine("Combined List");
            var combinedList = new List<Human>();

            combinedList.AddRange(listOfStudents);
            combinedList.AddRange(listOfWorkers);

            var orderedCombinedList = combinedList.OrderBy(x => x.FirstName)
                                                  .ThenBy(x => x.LastName);

            foreach (var human in orderedCombinedList)
            {
                Console.WriteLine("{0} {1}", human.FirstName, human.LastName);
            }
        }
    }
}
