using System;

/*
Write a program that reads 3 numbers:
integer a (0 <= a <= 500)
floating-point b
floating-point c
The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
The number a should be printed in hexadecimal, left aligned
Then the number a should be printed in binary form, padded with zeroes
The number b should be printed with 2 digits after the decimal point, right aligned
The number c should be printed with 3 digits after the decimal point, left aligned.
*/

class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Enter the first number(0 <= number <= 500): ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        float secondNumber = float.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        float thirdNumber = float.Parse(Console.ReadLine());

        Console.Write(firstNumber.ToString("X").PadRight(10) + "|");
        Console.Write(Convert.ToString(firstNumber, 2).PadLeft(10, '0') + "|");
        Console.Write("{0, 10:0.00}|", secondNumber);
        Console.Write("{0, -10:0.000}|", thirdNumber);
        Console.WriteLine();

    }
}