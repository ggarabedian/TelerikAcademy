namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Discipline : IComment
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;
        private string comment;

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
            : base()
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
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

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Number of lectures must be greater than zero");
                }
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Number of exercises must be greater than zero");
                }
                this.numberOfExercises = value;
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

        public override string ToString()
        {
            return String.Format("{0} - Lectures: {1} - Exercises: {2}",
                this.Name, this.NumberOfLectures, this.NumberOfExercises);
        }
    }
}
