using System;
using System.Globalization;

/*
Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the 
date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
*/

class DateInBulgarian
{
    static void Main()
    {
        Console.Write("Enter date and time (day.month.year hour:minute:second format): ");
        string input = Console.ReadLine();

        DateTime date = StringToDateAndTime(input);

        CultureInfo currentCulture = new CultureInfo("bg-BG");
        string dayOfWeek = currentCulture.DateTimeFormat.GetDayName(date.DayOfWeek);

        date = date.AddHours(6).AddMinutes(30);

        Console.WriteLine("After 6 hours and 30 minutes it will be {0}", date);
    }

    static DateTime StringToDateAndTime(string str)
    {
        string[] splitStr = str.Split(new char[] {'.', ':', ' '}, StringSplitOptions.RemoveEmptyEntries);
        DateTime result = new DateTime(int.Parse(splitStr[2]), int.Parse(splitStr[1]), int.Parse(splitStr[0]),
                                       int.Parse(splitStr[3]), int.Parse(splitStr[4]), int.Parse(splitStr[5]));
        return result;
    }
}

