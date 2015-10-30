using System;

/*
Write a program that encodes and decodes a string using given encryption key (cipher). The key consists of a sequence of 
characters. The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string 
with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.
*/

class EncodeDecode
{
    static void Main()
    {
        Console.Write("Enter sequence to be encoded: ");
        char[] sequence = Console.ReadLine().ToCharArray();
        Console.Write("Enter cipher: ");
        char[] cipher = Console.ReadLine().ToCharArray();

        char[] encodedSeq = EncodingDecoding(sequence, cipher);
        char[] decodedSeq = EncodingDecoding(encodedSeq, cipher);
        Console.WriteLine("The encoded sequence: " + new string(encodedSeq));
        Console.WriteLine("The decoded sequence: " + new string(decodedSeq));
    }

    static char[] EncodingDecoding(char[] seq, char[] code)
    {
        char[] result = new char[seq.Length];

        for (int i = 0, j = 0; i < seq.Length; i++, j++)
        {
            result[i] = (char)(seq[i] ^ code[j]);
            if (j >= code.Length - 1)
            {
                j = 0;
            }
        }
        return result;
    }
}

