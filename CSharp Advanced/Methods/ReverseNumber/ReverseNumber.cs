using System;

/*
Write a method that reverses the digits of given decimal number.
*/

class ReverseNumber
{
    static void Main()
    {
        Console.Write("Enter number to be reversed: ");
        string input = Console.ReadLine();

        Console.WriteLine(ReverseGivenNumber(input));
    }

    static double ReverseGivenNumber(string number)
    {
        char[] numberArr = number.ToCharArray();
        char[] resultArr = new char[numberArr.Length];

        for (int i = 0; i < numberArr.Length; i++)
        {
            resultArr[resultArr.Length - i - 1] = numberArr[i];
        }

        return double.Parse(new string(resultArr));
    }
}

