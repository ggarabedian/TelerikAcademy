using System;

/*
Write a program to read your birthday from the console and print how old you are now and how 
old you will be after 10 years.
 */

class AgeAfterTenYears
{
    static void Main()
    {
        Console.Write("Enter your birthday (day/month/year): ");
        string myBirthday = Console.ReadLine();
        DateTime birthdayDate;
        DateTime.TryParse(myBirthday, out birthdayDate);

        DateTime currentDate = DateTime.Now;

        int currentAge = 0;
        int ageAfterTenYears = 0;

        if (currentDate.Month > birthdayDate.Month)
        {
            currentAge = currentDate.Year - birthdayDate.Year;
            ageAfterTenYears = currentAge + 10;
        }
        else if (currentDate.Month < birthdayDate.Month)
        {
            currentAge = currentDate.Year - birthdayDate.Year - 1;
            ageAfterTenYears = currentAge + 10;
        }
        else
        {
            if (currentDate.Day > birthdayDate.Day)
            {
                currentAge = currentDate.Year - birthdayDate.Year;
                ageAfterTenYears = currentAge + 10;
            }
            else if (currentDate.Day < birthdayDate.Day)
            {
                currentAge = currentDate.Year - birthdayDate.Year - 1;
                ageAfterTenYears = currentAge + 10;
            }
            else
            {
                currentAge = currentDate.Year - birthdayDate.Year;
                ageAfterTenYears = currentAge + 10;
                Console.WriteLine("HAPPY BIRTHDAY");
            }
        }

        Console.WriteLine("You are {0} years old. After ten years you are going to be {1} years old.",
                                currentAge, ageAfterTenYears);
    }
}

