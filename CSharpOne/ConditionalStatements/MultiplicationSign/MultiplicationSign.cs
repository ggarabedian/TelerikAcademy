using System;

/*
Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
Use a sequence of if operators.
*/

class MultiplicationSign
{
    static void Main()
    {
        Console.Write("Write a number: ");
        double firstNumber = Double.Parse(Console.ReadLine());
        Console.Write("Write a number: ");
        double secondNumber = Double.Parse(Console.ReadLine());
        Console.Write("Write a number: ");
        double thirdNumber = Double.Parse(Console.ReadLine());
        int counter = 0;
        char sign = ' ';

        if (firstNumber < 0)
        {
            counter++;
        }

        if (secondNumber < 0)
        {
            counter++;
        }

        if (thirdNumber < 0)
        {
            counter++;
        }

        if (counter == 0 || counter == 2)
        {
            sign = '+';
        }
        else
	    {
            sign = '-';
	    }

        if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
        {
            sign = '0';
        }

        Console.WriteLine(sign);
    }
}

