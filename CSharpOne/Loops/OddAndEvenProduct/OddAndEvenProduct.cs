using System;

/*
You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
*/

class OddAndEvenProduct
{
    static void Main()
    {
        Console.Write("Enter integers separated by a space: ");
        string integers = Console.ReadLine();

        string[] arrayOfIntegers = integers.Split(' ');

        int oddProduct = 1;
        int evenProduct = 1;

        for (int i = 0; i < arrayOfIntegers.Length; i++)
        {
            if (i % 2 == 0)
            {
                evenProduct *= int.Parse(arrayOfIntegers[i]);
            }
            else
            {
                oddProduct *= int.Parse(arrayOfIntegers[i]);
            }
        }

        if (evenProduct == oddProduct)
        {
            Console.WriteLine("Is the product of the even and odd numbers equal: yes");
        }
        else
        {
            Console.WriteLine("Is the product of the even and odd numbers equal: no");
        }
    }
}