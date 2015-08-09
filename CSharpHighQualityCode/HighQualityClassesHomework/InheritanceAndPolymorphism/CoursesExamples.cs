﻿namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;

    public class CoursesExamples
    {
        public static void Main()
        {
            LocalCourse localCourse = new LocalCourse("Databases");
            Console.WriteLine(localCourse);

            localCourse.AssignLab("Enterprise");
            Console.WriteLine(localCourse);

            localCourse.AddStudent("Peter");
            localCourse.AddStudent("Maria");
            Console.WriteLine(localCourse);

            localCourse.AssignTeacher("Svetlin Nakov");
            localCourse.AddStudent("Milena");
            localCourse.AddStudent("Todor");
            Console.WriteLine(localCourse);

            OffsiteCourse offsiteCourse = new OffsiteCourse(
                "PHP and WordPress Development", 
                "Mario Peshev",
                new List<string>() { "Thomas", "Ani", "Steve" });
            Console.WriteLine(offsiteCourse);
        }
    }
}