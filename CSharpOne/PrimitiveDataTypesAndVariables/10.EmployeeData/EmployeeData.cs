using System;

/*
A marketing company wants to keep record of its employees. Each record would have the following characteristics:
First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
Use descriptive names. Print the data at the console.
*/

class EmployeeData
{
    static void Main()
    {
        string firstName = "John";
        string lastName = "Doe";
        byte age = 33;
        char gender = 'm';
        long idNumber = 8306112507;
        int employeeNumber = 27562959;

        Console.WriteLine("Name: {0} {1}", firstName, lastName);
        Console.WriteLine("Gender: {0}", gender);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("ID Number: {0}", idNumber);
        Console.WriteLine("Employee Number: {0}", employeeNumber);
    }
}

