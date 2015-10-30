using System;
using System.Globalization;
using System.Threading;

/*
Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
Display them in the standard date format for Canada.
*/

class DatesFromTextInCanada
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-CA");

        Console.WriteLine("Enter text: ");
        string input = Console.ReadLine();

        string[] textSplit = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("Extracted dates: ");
        for (int i = 0; i < textSplit.Length; i++)
        {
            try
            {
                DateTime date = DateTime.ParseExact(textSplit[i].TrimEnd(new char[] { ',', '.', '!', '?' }),
                                "d.M.yyyy", CultureInfo.InvariantCulture);
                Console.WriteLine(date.Date.ToLongDateString());
            }
            catch (FormatException) { }
        }
    }
}

