using System;

/*
Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; 
the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.
*/

class NumberAsArray
{
    static void Main()
    {
        Console.Write("Enter first positive number: ");
        string firstNumber = Console.ReadLine();
        Console.Write("Enter second positive number: ");
        string secondNumber = Console.ReadLine();

        AddTwoArrayNumbers(firstNumber, secondNumber);
    }

    static void AddTwoArrayNumbers(string a, string b)
    {
        char[] firstArray = a.ToCharArray();
        char[] secondArray = b.ToCharArray();

        Array.Reverse(firstArray);
        Array.Reverse(secondArray);

        Console.WriteLine(string.Join(", " , firstArray));
        Console.WriteLine(string.Join(", ", secondArray));

        int result = CalculateArraySum(firstArray) + CalculateArraySum(secondArray);
        Console.WriteLine("Sum of the elements of the two arrays: " + result);
    }

    static int CalculateArraySum(char[] array)
    {
        int result = 0;

        for (int i = 0; i < array.Length; i++)
        {
            result += array[i] - '0';
        }

        return result;
    }
}

