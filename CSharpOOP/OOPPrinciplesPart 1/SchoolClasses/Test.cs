namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Test
    {
        static void Main()
        {
            var someSchool = new School("Some Very Special School");
            var someClass = new Class("Some Very Special Class");

            var georgeTheStudent = new Student("George", 123);
            var jimmyTheStudent = new Student("Jimmy", 124);
            var jamesTheStudent = new Student("James", 125);
            var dianeTheStudent = new Student("Diane", 126);

            jamesTheStudent.Comment = "I hate Math";
            jimmyTheStudent.Comment = "I gotta learn more about cats";

            var math = new Discipline("Math", 10, 10);
            var biology = new Discipline("Biology", 8, 4);
            var chemistry = new Discipline("Chemistry", 8, 4);
            var literature = new Discipline("Literature", 10, 2);

            var johnTheTeacher = new Teacher("John", new List<Discipline>() { math });
            var jackTheTeacher = new Teacher("Jack", new List<Discipline>() { biology, chemistry });
            var mariaTheTeacher = new Teacher("Maria");
            mariaTheTeacher.AddDiscipline(literature);

            johnTheTeacher.Comment = "George is SOOO bad at math";
            jackTheTeacher.Comment = "I need to get a dog";

            someSchool.AddClass(someClass);

            someClass.AddStudent(georgeTheStudent);
            someClass.AddStudent(jimmyTheStudent);
            someClass.AddStudent(jamesTheStudent);
            someClass.AddStudent(dianeTheStudent);

            someClass.AddTeacher(johnTheTeacher);
            someClass.AddTeacher(jackTheTeacher);
            someClass.AddTeacher(mariaTheTeacher);

            Console.WriteLine(PrintSchoolInfo(someSchool)); 
        }

        static string PrintSchoolInfo(School school)
        { 
            StringBuilder result = new StringBuilder();

            result.AppendLine(school.SchoolName);

            foreach (var aClass in school.GetClasses())
            {
                result.AppendLine("  " + aClass.ClassIdentifier);

                foreach (var teacher in aClass.GetTeachers())
                {
                    result.AppendLine("    " + teacher.ToString());
                    result.AppendLine("      Comments: " + teacher.Comment);

                    foreach (var discipline in teacher.GetDiscipline())
                    {
                        result.AppendLine("      Disciplines: " + discipline.ToString());
                    }
                }

                foreach (var student in aClass.GetStudents())
                {
                    result.AppendLine("    " + student.ToString() + "    " + student.Comment);
                }
            }

            return result.ToString();
        }
    }
}
