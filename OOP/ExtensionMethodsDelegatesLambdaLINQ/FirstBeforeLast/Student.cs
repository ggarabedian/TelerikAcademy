namespace FirstBeforeLast
{
    using System;

    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;

        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set 
            {
                if (value == "")
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }
                this.firstName = value; 
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set 
            {
                if (value == "")
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }
                this.lastName = value; 
            }
        }

        public int Age
        {
            get { return this.age; }
            private set
            {
                if (value < 15 || value > 100)
                {
                    throw new ArgumentException("The student's age must be greater than 15 and less than 100");
                }
                this.age = value;
            }
        }
    }
}
