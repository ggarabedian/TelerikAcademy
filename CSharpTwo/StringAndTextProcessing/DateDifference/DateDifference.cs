using System;

/*
Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
*/

class DateDifference
    {
        static void Main()
        {
            Console.Write("Enter first date(day.month.year format): ");
            string firstInput = Console.ReadLine();
            Console.Write("Enter second date(day.month.year format): ");
            string secondInput = Console.ReadLine();

            int numberOfDays = StringToDate(firstInput).Subtract((StringToDate(secondInput))).Days;

            Console.WriteLine(Math.Abs(numberOfDays)); 
        }

        static DateTime StringToDate(string str)
        {
            string[] splitStr = str.Split('.');
            DateTime result = new DateTime(int.Parse(splitStr[2]), int.Parse(splitStr[1]), int.Parse(splitStr[0]));
            return result;
        }
    }
