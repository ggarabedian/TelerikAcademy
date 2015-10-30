using System;

/*
A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.
*/

class CompanyInformation
{
    static void Main()
    {
        Console.Write("Enter company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Enter company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Enter company phone number: ");
        string companyPhoneNumber = Console.ReadLine();
        Console.Write("Enter company fax number: ");
        string companyFaxNumber = Console.ReadLine();
        Console.Write("Enter company web site: ");
        string companyWebSite = Console.ReadLine();
        Console.Write("Enter manager's first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Enter manager's last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Enter manager's phone number: ");
        string managerPhoneNumber = Console.ReadLine();
        Console.Write("Enter manager's age: ");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('-', 30));

        Console.WriteLine("Company name: " + companyName);
        Console.WriteLine("Company address: " + companyAddress);
        Console.WriteLine("Company phone number: " + companyPhoneNumber);
        Console.WriteLine("Company fax number: " + companyFaxNumber);
        Console.WriteLine("Company web site: " + companyWebSite);
        Console.WriteLine("Company manager: {0} {1} (age: {2}, phone number: {3}).", managerFirstName, managerLastName, age, managerPhoneNumber);
    }
}

