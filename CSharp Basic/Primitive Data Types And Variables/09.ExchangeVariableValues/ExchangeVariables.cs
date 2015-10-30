using System;

/*
Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by 
using some programming logic. Print the variable values before and after the exchange.
*/

class ExchangeVariables
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", b);

        a ^= b;
        b ^= a;
        a ^= b;

        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", b);
    }
}

//Using temp variable
/*      
        int tempVar;
        tempVar = a;
        a = b;
        b = tempVar;
*/