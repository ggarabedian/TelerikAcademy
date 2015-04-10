namespace PersonClass
{
    using System;

    public class Person
    {
        private string name;
        private int? age;

        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name 
        {
            get
            { 
                return this.name; 
            }
            set
            {
                this.name = value;
            }
        }

        public int? Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public override string ToString()
        {
            return String.Format("My name is {0} and I am {1} years old", this.Name, this.Age == null ? "SECRETZ" : this.Age.ToString());
        }
    }
}
