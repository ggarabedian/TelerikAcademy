using System;

/*
A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
bank name, IBAN, 3 credit card numbers associated with the account. Declare the variables needed to keep the 
information for a single bank account using the appropriate data types and descriptive names.
*/

class BankAccountData
{
    static void Main()
    {
        string firstName = "John";
        string middleName = "Missing";
        string lastName = "Doe";
        decimal balance = 2750.50M;
        string bankName = "Central Cooperative Bank";
        string IBAN = "4382AI49329AZ";

        string creditCardOne = "4505 9865 2564 8513";
        string creditCardTwo = "7462 5489 2315 9422";
        string creditCardThree = "1125 2233 6598 4758";

        Console.WriteLine("Account holder: " + firstName + " " + middleName + " " + lastName);
        Console.WriteLine("Current balance: " + balance + "$");
        Console.WriteLine("Bank name: " + bankName);
        Console.WriteLine("IBAN : " + IBAN);
        Console.WriteLine("Credit cards linked to the account: " + "\nVisa #1: " + creditCardOne + 
                                                                   "\nVisa #2: " + creditCardTwo + 
                                                                   "\nMastercard: " + creditCardThree);
    }
}

