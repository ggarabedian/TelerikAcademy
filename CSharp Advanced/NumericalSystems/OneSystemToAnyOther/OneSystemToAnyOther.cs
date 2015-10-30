using System;
using System.Text;

/*
Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).
*/

class OneSystemToAnyOther
{
    static void Main()
    {
        Console.Write("Enter the numeral system of the number: ");
        int originalBase = int.Parse(Console.ReadLine());
        Console.Write("Enter number to be converted: ");
        string input = Console.ReadLine();
        Console.Write("Enter the numeral system to convert the number in: ");
        int toConvertToBase = int.Parse(Console.ReadLine());

        Console.WriteLine("The number after conversion: " + ConvertBaseXToBaseY(input, originalBase, toConvertToBase));
    }

    static string ConvertBaseXToBaseY(string number, int originalBase, int toConvertToBase)
    {
        return ConvertBase10AndAbove(ConvertBase10AndBelow(number, originalBase), toConvertToBase);
    }

    static string ConvertBase10AndAbove(int a, int b)
    {
        string h = String.Empty;
        char ch;
        while (a != 0)
        {
            ch = GetLetter(a % b);
            h = ch + h;
            a /= b;
        }

        return h;
    }

    static int ConvertBase10AndBelow(string str, int a)
    {
        int d = 0;
        int number;
        for (int i = str.Length - 1, p = 1; i >= 0; i--, p *= a)
        {
            number = GetNumber(str, i);
            d += number * p;
        }
        return d;
    }

    static char GetLetter(int i)
    {
        if (i >= 10)
        {
            return (char)('A' + i - 10);
        }
        else
        {
            return (char)('0' + i);
        }
    }

    static int GetNumber(string str, int i)
    {
        if (str[i] >= 'A')
        {
            return str[i] - 'A' + 10;
        }
        else
        {
            return str[i] - '0';
        }
    }

}

