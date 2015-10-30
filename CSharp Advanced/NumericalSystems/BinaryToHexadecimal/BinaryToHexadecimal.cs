using System;
using System.Collections.Generic;

/*
Write a program to convert binary numbers to hexadecimal numbers (directly).
*/

class BinaryToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter a number in binary format: ");
        string input = Console.ReadLine().PadLeft(32, '0');
        Console.WriteLine("Hexadecimal Format: " + ConvertBinaryToHexadecimal(input));      
    }

    static string ConvertBinaryToHexadecimal(string str)
    {
        Dictionary<string, char> binaryToHexChar = new Dictionary<string, char> 
        {
        { "0000", '0' },
        { "0001", '1' },
        { "0010", '2' },
        { "0011", '3' },
        { "0100", '4' },
        { "0101", '5' },
        { "0110", '6' },
        { "0111", '7' },
        { "1000", '8' },
        { "1001", '9' },
        { "1010", 'A' },
        { "1011", 'B' },
        { "1100", 'C' },
        { "1101", 'D' },
        { "1110", 'E' },
        { "1111", 'F' }
        };

        string chunk = "";
        string result = "";

        for (int i = 0; i < str.Length; i += 4)
        {
            chunk = str.Substring(i, 4);
            if (chunk == "0000")
            {
                continue;
            }
            else
            {
                result += binaryToHexChar[chunk];
            }
        }
        
        return result;
    }
    
}
