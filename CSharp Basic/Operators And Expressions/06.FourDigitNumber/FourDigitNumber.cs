using System;
using System.Collections.Generic;

/*
Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0. 
*/

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int fourthDigit = number % 10;
        int thirdDigit = (number / 10) % 10;
        int secondDigit = (number / 100) % 10;
        int firstDigit = (number / 1000) % 10;

        Console.WriteLine("Sum of digits: " + (firstDigit + secondDigit + thirdDigit + fourthDigit));
        Console.WriteLine("Reversed order: {0}{1}{2}{3}", fourthDigit, thirdDigit, secondDigit, firstDigit );
        Console.WriteLine("Last digit in first position: {0}{1}{2}{3}", fourthDigit, firstDigit, secondDigit, thirdDigit);
        Console.WriteLine("Exchange second and third digit: {0}{1}{2}{3}", firstDigit, thirdDigit, secondDigit, fourthDigit);
    }
}

