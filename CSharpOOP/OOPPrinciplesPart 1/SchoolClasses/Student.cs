namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Student : People
    {
        private int uniquesClassNumber;
        private static List<int> uniqueNumbersList = new List<int>();

        public Student(string name, int uniquesClassNumber)
            : base(name)
        {
            this.UniquesClassNumber = uniquesClassNumber;
        }       

        public int UniquesClassNumber
        {
            get
            {
                return this.uniquesClassNumber;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Unique class number must be greater than 0");
                }

                if (uniqueNumbersList.Contains(value))
                {
                    throw new ArgumentException("Unique class number already present");
                }

                uniqueNumbersList.Add(value);
                this.uniquesClassNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} - ID: {1}", this.Name, this.UniquesClassNumber);
        }
    }
}
