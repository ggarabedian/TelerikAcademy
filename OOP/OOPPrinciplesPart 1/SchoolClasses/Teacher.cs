namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Teacher : People
    {
        private List<Discipline> disciplines;

        public Teacher(string name)
            : base(name)
        {
            this.disciplines = new List<Discipline>();
        }

        public Teacher(string name, List<Discipline> disciplines)
            : this(name)
        {
            this.disciplines = disciplines;
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.disciplines.Add(discipline);
        }

        public List<Discipline> GetDiscipline()
        {
            return new List<Discipline>(this.disciplines);
        }

        public override string ToString()
        {
            return string.Format("{0}", this.Name);
        }
    }
}
