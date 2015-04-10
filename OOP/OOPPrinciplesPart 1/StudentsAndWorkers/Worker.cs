namespace StudentsAndWorkers
{
    using System;

    public class Worker : Human
    {
        private const int workingDays = 5;

        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Week salary must be greater than zero");
                }

                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            private set
            {
                if (value < 1 || value > 8)
                {
                    throw new ArgumentException("Work hours per day must be between 1 and 8 hours");
                }

                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            return this.weekSalary / (decimal)(this.workHoursPerDay * workingDays);
        }
    }
}
