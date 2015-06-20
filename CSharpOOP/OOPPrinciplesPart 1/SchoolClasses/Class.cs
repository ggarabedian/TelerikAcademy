namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Class : IComment
    {
        private string classIdentifier;
        private List<Student> classStudents;
        private List<Teacher> classTeachers;
        private string comment;

        public Class(string classIdentifier)
        {
            this.classStudents = new List<Student>();
            this.classTeachers = new List<Teacher>();
            this.ClassIdentifier = classIdentifier;
        }

        public Class(string classIdentifier, List<Student> classStudents, List<Teacher> classTeachers)
            : this(classIdentifier)
        {
            //this.classStudents = new List<Student>();
            //this.classTeachers = new List<Teacher>();
        }

        public string ClassIdentifier
        {
            get
            {
                return this.classIdentifier;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Text identifier cannot be null, empty or whitespace");
                }
                this.classIdentifier = value;
            }
        }

        public string Comment
        {
            get
            {
                if (String.IsNullOrWhiteSpace(this.comment))
                {
                    return "No comment so far!";
                }

                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }

        public void AddTeacher(Teacher teacher)
        {
            this.classTeachers.Add(teacher);
        }

        public List<Teacher> GetTeachers()
        {
            return new List<Teacher>(this.classTeachers);
        }

        public void AddStudent(Student student)
        {
            this.classStudents.Add(student);
        }

        public List<Student> GetStudents()
        {
            return new List<Student>(this.classStudents);
        }
    }
}
