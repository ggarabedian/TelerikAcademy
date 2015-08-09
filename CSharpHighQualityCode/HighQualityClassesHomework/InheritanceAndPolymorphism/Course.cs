namespace InheritanceAndPolymorphism
{
    using System.Collections.Generic;
    using System.Text;

    public abstract class Course
    {
        private string courseName;
        private string teacherName;
        private IList<string> students;

        protected Course(string courseName, string teacherName = null, IList<string> students = null)
        {
            this.CourseName = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        public string CourseName 
        { 
            get
            {
                return this.courseName;
            }
            
            private set
            {
                this.courseName = value;
            }
        }

        public string TeacherName 
        {
            get
            {
                return this.teacherName;
            }

            private set
            {
                this.teacherName = value;
            }
        }

        public IList<string> Students 
        {
            get
            {
                return this.students;
            }

            private set
            {
                if (value == null)
                {
                    this.students = new List<string>();
                }
                else
                {
                    this.students = value;
                }
            }
        }

        public void AddStudent(string studentName)
        {
            this.Students.Add(studentName);
        }

        public void AssignTeacher(string teacherName)
        {
            this.TeacherName = teacherName;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(this.CourseName);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());

            return result.ToString();
        }

        private string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }
    }
}
