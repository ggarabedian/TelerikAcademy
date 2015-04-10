namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private string schoolName;
        private List<Class> schoolClasses;

        public School(string schoolName)
        {
            this.SchoolName = schoolName;
            this.schoolClasses = new List<Class>();
        }

        public string SchoolName
        {
            get
            {
                return this.schoolName;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("School name cannot be null, empty or whitespace");
                }
                this.schoolName = value;
            }
        }

        public void AddClass(Class newClass)
        {
            this.schoolClasses.Add(newClass);
        }

        
        public List<Class> GetClasses()
        {
            return new List<Class>(this.schoolClasses);
        }

        public override string ToString()
        {
            return string.Format("{0}", this.SchoolName);
        }
    }
}
