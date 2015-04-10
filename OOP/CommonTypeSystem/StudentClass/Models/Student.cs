namespace StudentClass.Models
{
    using System;
    using System.Text;

    public class Student : ICloneable, IComparable
    {
        Random rand = new Random();

        #region Properties
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public long SSN { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public Specialties Specialty { get; set; }
        public Universities University { get; set; }
        public Faculties Faculty { get; set; }
        #endregion

        #region Enums
        public enum Specialties
        {
            Mathematician,
            Physicist,
            Chemist,
            Geographer,
            Journalist,
            Politician,
            Soldier
        }

        public enum Faculties
        {
            Math,
            Physics,
            Chemistry,
            Geography,
            Literature,
            Politology,
            Warfare
        }

        public enum Universities
        {
            TheSolveProblemsUniversity,
            TheCreateProblemsUniversity,
            TheBlowStuffUpUniversity,
            TheCleanBlowedStuffUniversity
        }
        #endregion

        public Student(string firstName, string middleName, string lastName, long ssn, string address, 
                       string mobileNumber, string email, string course, Universities university, 
                       Specialties specialty, Faculties faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = address;
            this.MobileNumber = mobileNumber;
            this.Email = email;
            this.Course = course;
            this.University = university;
            this.Specialty = specialty;
            this.Faculty = faculty;
        }       

        public override bool Equals(object obj)
        {
            if (!this.FirstName.Equals((obj as Student).FirstName)) return false;
            if (!this.MiddleName.Equals((obj as Student).MiddleName)) return false;
            if (!this.LastName.Equals((obj as Student).LastName)) return false;
            if (!this.SSN.Equals((obj as Student).SSN)) return false;
            if (!this.Address.Equals((obj as Student).Address)) return false;
            if (!this.MobileNumber.Equals((obj as Student).MobileNumber)) return false;         
            if (!this.Email.Equals((obj as Student).Email)) return false;
            if (!this.Course.Equals((obj as Student).Course)) return false;
            if (!this.University.Equals((obj as Student).University)) return false;
            if (!this.Specialty.Equals((obj as Student).Specialty)) return false;
            if (!this.Faculty.Equals((obj as Student).Faculty)) return false;           
            
          return true;
        }

        public static bool operator ==(Student st1, Student st2)
        {
            return st1.Equals(st2);
        }

        public static bool operator !=(Student st1, Student st2)
        {
            return !(st1.Equals(st2));
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(String.Format("Name: {0} {1} {2}", this.FirstName, this.MiddleName, this.LastName));
            result.AppendLine(String.Format("Social security number: {0}", this.SSN));
            result.AppendLine(String.Format("Address: {0}", this.Address));
            result.AppendLine(String.Format("Mobile number: {0}", this.MobileNumber));
            result.AppendLine(String.Format("Email: {0}", this.Email));
            result.AppendLine(String.Format("University: {0}", this.University));
            result.AppendLine(String.Format("Faculty: {0}", this.Faculty));
            result.AppendLine(String.Format("Specialty: {0} / Course: {1}", this.Specialty, this.Course));

            return result.ToString();
        }

        public override int GetHashCode()
        {
            int randomNumber = rand.Next(1111, 8888);
            int hash = (randomNumber * (int)(this.SSN / 10000));
            return hash;
        }

        public object Clone()
        {
            Student temp = new Student(this.FirstName, this.MiddleName,
                this.LastName, this.SSN, this.Address, this.MobileNumber, this.Email,
                this.Course, this.University, this.Specialty, this.Faculty);

            return temp;
        }

        public int CompareTo(object obj)
        {
            if (this.FirstName.CompareTo((obj as Student).FirstName) != 0)
            {
                return this.FirstName.CompareTo((obj as Student).FirstName);
            }

            if (this.MiddleName.CompareTo((obj as Student).MiddleName) != 0)
            {
                return this.MiddleName.CompareTo((obj as Student).MiddleName);
            }

            if (this.LastName.CompareTo((obj as Student).LastName) != 0)
            {
                return this.LastName.CompareTo((obj as Student).LastName);
            }

            if (this.SSN.CompareTo((obj as Student).SSN) != 0)
            {
                return this.SSN.CompareTo((obj as Student).SSN);
            }

            return 0;
        }
    }
}
