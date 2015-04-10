namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        private string firstName;
        private string lastName;
        private string fn;
        private string phoneNumber;
        private string email;
        private int groupNumber;
        private List<int> marks;

        public Student(string firstName, string lastName, string fn, string phoneNumber, string email, int groupNumber, List<int> marks)
            : base()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fn;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.GroupNumber = groupNumber;
            this.Marks = marks;
        }

        #region Properties

        public string FirstName 
        {
            get 
            { 
                return this.firstName; 
            }
            private set 
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty");
                }
                this.firstName = value; 
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty");
                }
                this.lastName = value;
            }
        }

        public string FN
        {
            get
            {
                return this.fn;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("FN cannot be null or empty");
                }

                if (value.Length != 10)
                {
                    throw new ArgumentException("FN must contain exactly 10 digits");
                }

                if (!value.All(Char.IsDigit))
                {
                    throw new FormatException("FN must contain only numbers");
                }

                this.fn = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Phone number cannot be null or empty");
                }

                if (!value.All(Char.IsDigit))
                {
                    throw new FormatException("FN must contain only numbers");
                }

                this.phoneNumber = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty");
                }
                if (!value.Contains('@'))
                {
                    throw new ArgumentException("Invalid email");
                }
                this.email = value;
            }
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            private set
            {
                if (value < 1 || value > 4)
                {
                    throw new ArgumentException("Group number must be between 1 and 4");
                }
                this.groupNumber = value;
            }
        }

        public List<int> Marks
        {
            get
            {
                return this.marks;
            }
            private set
            {
                this.marks = value;
            }
        }

        #endregion

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
