using System;

/*
Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.
*/

class NullValuesArithmetic
{
    static void Main()
    {
        int? nullInteger = null;
        double? nullDouble = null;

        Console.WriteLine("Null Integer: " + nullInteger);
        Console.WriteLine("Null Double: " + nullDouble);

        nullInteger += 5;
        nullDouble += 9.5d;

        Console.WriteLine("Null Integer + number: " + nullInteger);
        Console.WriteLine("Null Double + number: " + nullDouble);

        nullInteger = 5;
        nullDouble = 9.5d;

        Console.WriteLine("Null Integer assign new value: " + nullInteger);
        Console.WriteLine("Null Double assign new value: " + nullDouble);
    }
}

