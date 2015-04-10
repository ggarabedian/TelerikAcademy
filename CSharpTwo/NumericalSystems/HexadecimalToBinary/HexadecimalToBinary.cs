using System;
using System.Collections.Generic;

/*
Write a program to convert hexadecimal numbers to binary numbers (directly).
*/

class HexadecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter a number in hexadecimal format: ");
        string input = Console.ReadLine();
        Console.WriteLine("Binary Format: " + ConvertHexadecimalToBinary(input));
    }

    static string ConvertHexadecimalToBinary(string str)
    {
        Dictionary<char, string> hexCharacterToBinary = new Dictionary<char, string> 
        {
        { '0', "0000" },
        { '1', "0001" },
        { '2', "0010" },
        { '3', "0011" },
        { '4', "0100" },
        { '5', "0101" },
        { '6', "0110" },
        { '7', "0111" },
        { '8', "1000" },
        { '9', "1001" },
        { 'A', "1010" },
        { 'B', "1011" },
        { 'C', "1100" },
        { 'D', "1101" },
        { 'E', "1110" },
        { 'F', "1111" }
        };

        string result = "";

        foreach (char c in str)
        {
            result += hexCharacterToBinary[char.ToUpper(c)];
        }
        return result;
    }
}



