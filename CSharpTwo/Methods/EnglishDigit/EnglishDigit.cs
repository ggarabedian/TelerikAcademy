using System;

/*
Write a method that returns the last digit of given integer as an English word.
*/

class EnglishDigit
{
    static void Main()
    {
        Console.Write("Enter the number: ");
        int input = int.Parse(Console.ReadLine());

        Console.WriteLine("THe last digit of the number is: {0}", LastDigitToWord(input));
    }

    static string LastDigitToWord(int number)
    {
        int lastDigit = number % 10;
        string word = string.Empty;

        switch (lastDigit)
        {
            case 1: word = "one"; break;
            case 2: word = "two"; break;
            case 3: word = "three"; break;
            case 4: word = "four"; break;
            case 5: word = "five"; break;
            case 6: word = "six"; break;
            case 7: word = "seven"; break;
            case 8: word = "eight"; break;
            case 9: word = "nine"; break;
            case 0: word = "zero"; break;
        }
        return word;
    }
}