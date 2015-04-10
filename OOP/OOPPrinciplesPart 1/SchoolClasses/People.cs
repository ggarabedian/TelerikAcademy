namespace SchoolClasses
{
    using System;

    public abstract class People : IComment
    {
        private string name;
        private string comment;

        public People(string name)
            : base()
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null, empty or whitespace");
                }
                this.name = value;
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
    }
}
