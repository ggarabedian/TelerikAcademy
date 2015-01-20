using System;

/*
Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. 
As a result print the values a and b, separated by a space.
*/

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double firstVar = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double secondVar = double.Parse(Console.ReadLine());

        double tempVar = 0;

        if (firstVar > secondVar)
        {
            tempVar = firstVar;
            firstVar = secondVar;
            secondVar = tempVar;
        }

        Console.WriteLine(firstVar + " " + secondVar);
    }
}

