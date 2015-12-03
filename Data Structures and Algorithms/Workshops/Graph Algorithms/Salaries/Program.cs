namespace Salaries
{
    using System;

    class Program
    {
        static int c;
        static bool[,] employees;
        static long[] cache;

        static void Main()
        {
            c = int.Parse(Console.ReadLine());
            cache = new long[c];
            employees = new bool[c, c];

            for (int i = 0; i < c; i++)
            {
                string input = Console.ReadLine();

                for (int j = 0; j < c; j++)
                {
                    if (input[j] == 'Y')
                    {
                        employees[i, j] = true;
                    }
                }
            }

            long sumOfSalaries = 0;

            for (int i = 0; i < c; i++)
            {
                sumOfSalaries += FindSalary(i);
            }

            Console.WriteLine(sumOfSalaries);
        }

        static long FindSalary(int employee)
        {
            if (cache[employee] > 0)
            {
                return cache[employee];
            }

            long salary = 0;

            for (int i = 0; i < c; i++)
            {
                if (employees[employee, i])
                {
                    salary += FindSalary(i);
                }
            }

            if (salary == 0)
            {
                salary = 1;
            }

            cache[employee] = salary;

            return salary;
        }
    }
}
