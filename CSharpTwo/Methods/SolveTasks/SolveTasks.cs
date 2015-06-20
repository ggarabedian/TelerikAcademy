using System;
using System.Text;
using System.Linq;

/*
Write a program that can solve these tasks:
Reverses the digits of a number
Calculates the average of a sequence of integers
Solves a linear equation a * x + b = 0
Create appropriate methods.
Provide a simple text-based menu for the user to choose which task to solve.
Validate the input data:
The decimal number should be non-negative
The sequence should not be empty
a should not be equal to 0
*/

class SolveTasks
{
    static void Main()
    {
        Menu();
    }

    static void Menu()
    {
        Console.WriteLine("1) Reverse given number.");
        Console.WriteLine("2) Calculate average of given sequence of numbers.");
        Console.WriteLine("3) Solve a linear equation.");
        Console.WriteLine("4) Exit program.");
        Console.Write("What do you want to do: ");
        char choice = char.Parse(Console.ReadLine());

        switch (choice)
        {
            case '1': ReverseDigits(); break;
            case '2': CalculateAverage(); break;
            case '3': SolveLinearEquation(); break;
            case '4': return;
            default: Console.WriteLine("Invalid Input!"); ; break;
        }
    }

    static void ReverseDigits()
    {
        Console.Write("Enter number to be reversed: ");
        string input = Console.ReadLine();

        if (input == string.Empty || input.Any(x => char.IsLetter(x)))
        {
            Console.WriteLine("Invalid input! Try again!");
        }

        StringBuilder result = new StringBuilder();

        for (int i = input.Length - 1; i >= 0; i--)
        {
            result.Append(input[i]);
        }

        Console.WriteLine("The number reversed: " + result.ToString());
    }

    static void CalculateAverage()
    {
        Console.Write("Enter sequence of numbers separated by spaces: ");        
        string[] input = Console.ReadLine().Split(' ');

        int result = 0;

        foreach (string str in input)
        {
            result += int.Parse(str);
        }

        result /= input.Length;

        Console.WriteLine("The average of this sequence is: " + result);
    }

    static void SolveLinearEquation()
    {
        Console.Write("Enter linear equation to be solved (a*x+b): ");
        string[] input = Console.ReadLine().Split(new string[] { " ", "*x+", "*x-", }, StringSplitOptions.None);

        if (input[0] == "0")
        {
            Console.WriteLine("Invalid Input!");
            return;
        }

        decimal result = ((decimal.Parse(input[1]) * -1) / decimal.Parse(input[0]));

        Console.WriteLine("The result is {0:N2}.", result);
    }
}

