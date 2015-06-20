namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Animal : ISound
    {
        private string name;
        private int age;
        private AnimalType typeOfAnimal;
        private GenderType gender;

        public Animal(string name, int age, GenderType gender)
	    {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.TypeOfAnimal = AnimalType.Default;
	    }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null, empty or whitespace");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Age must be greater than 0");
                }
                this.age = value;
            }
        }

        public AnimalType TypeOfAnimal
        {
            get
            {
                return this.typeOfAnimal;
            }
            set
            {
                this.typeOfAnimal = value;
            }
        }

        public GenderType Gender
        {
            get
            {
                return this.gender;
            }
            private set
            {
                this.gender = value;
            }
        }

        public static double AverageAge(IEnumerable<Animal> animals)
        {
            return animals.Average(x => x.Age);
        }

        public virtual string ProduceSound()
        {
            return "....";
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("{0} is {1} years old ", this.name, this.age);

            if (this.gender == GenderType.Female && this.typeOfAnimal == AnimalType.Cat)
            {
                result.Append("kitten.");
            }
            else if (this.gender == GenderType.Male && this.typeOfAnimal == AnimalType.Cat)
            {
                result.Append("tomcat.");
            }
            else
            {
                result.AppendFormat("{0} {1}.",
                    this.gender.ToString().ToLowerInvariant(),
                    this.typeOfAnimal.ToString().ToLowerInvariant());                                   
            }

            return result.ToString();
        }
    }

    public enum GenderType
    {
        Male,
        Female
    }

    public enum AnimalType
    {
        Cat,
        Dog,
        Frog,
        Default
    }
}
