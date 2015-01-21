using System;

/*
Using loops write a program that converts an integer number to its binary representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.
*/

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        long input = long.Parse(Console.ReadLine());

        string result = "";

        if(input == 0)
        {
            result = "0";
        }
        else
        {
            while(input > 0)
            {
                result += (input % 2);
                input /= 2;
            }
        }

        char[] temp = result.ToCharArray();
        Array.Reverse(temp);
        result = new string(temp);

        Console.WriteLine("Binary: " + result);
    }
}

