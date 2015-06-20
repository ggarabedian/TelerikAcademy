using System;

/*
Write a method GetMax() with two parameters that returns the larger of two integers.
Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
*/

class GetLargestNumber
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        int largest = GetMax(firstNumber, secondNumber);
        largest = GetMax(largest, thirdNumber);

        Console.WriteLine("The largest number is " + largest);
    }

    static int GetMax(int number1, int number2)
    {
        if (number1 >= number2)
        {
            return number1;
        }
        else
        {
            return number2;
        }
    }
}