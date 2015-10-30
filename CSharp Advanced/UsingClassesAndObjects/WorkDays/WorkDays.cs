using System;

/*
Write a method that calculates the number of workdays between today and given date, passed as parameter.
Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified 
preliminary as array.
*/

static class WorkDays
{
    static DateTime[] Holidays = new DateTime[]
    {
        new DateTime(2015, 03, 03),
        new DateTime(2015, 05, 24),
        new DateTime(2015, 12, 24)
    };

    static void Main()
    {
        Console.Write("Enter date in format dd/mm/yyyy: ");
        string input = Console.ReadLine();
        DateTime currentDate = DateTime.Today;
        DateTime dateToCheck;

        if (!DateTime.TryParse(input, out dateToCheck)) 
        {
            throw new ArgumentException("Incorrect day format!");
        }

        var date = dateToCheck.Subtract(currentDate);

        Console.WriteLine(CalculateWorkingDays(currentDate, dateToCheck, Holidays));
    }

    static int CalculateWorkingDays(this DateTime startDay, DateTime lastDay, params DateTime[] Holidays)
    {
        startDay = startDay.Date;
        lastDay = lastDay.Date;
        if (startDay > lastDay)
            throw new ArgumentException("Incorrect last day " + lastDay);

        TimeSpan span = lastDay - startDay;
        int workingDays = span.Days + 1;
        int fullWeekCount = workingDays / 7;

        if (workingDays > fullWeekCount * 7)
        {
            int firstDayOfWeek = (int)startDay.DayOfWeek;
            int lastDayOfWeek = (int)lastDay.DayOfWeek;
            if (lastDayOfWeek < firstDayOfWeek)
                lastDayOfWeek += 7;
            if (firstDayOfWeek <= 6)
            {
                if (lastDayOfWeek >= 7)
                    workingDays -= 2;
                else if (lastDayOfWeek >= 6)
                    workingDays -= 1;
            }
            else if (firstDayOfWeek <= 7 && lastDayOfWeek >= 7)
                workingDays -= 1;
        }

        workingDays -= fullWeekCount + fullWeekCount;

        foreach (DateTime holiday in Holidays)
        {
            DateTime bh = holiday.Date;
            if (startDay <= bh && bh <= lastDay)
                --workingDays;
        }

        return workingDays;
    }
}

