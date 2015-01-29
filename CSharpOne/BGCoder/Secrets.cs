using System;
using System.Numerics;

class Secrets
{
    static void Main()
    {
        BigInteger input = BigInteger.Parse(Console.ReadLine());

        if (input < 0)
        {
            input = -input;
        }
        BigInteger tempInput = input;
        BigInteger secretSum = 0;
        long position = 1;

        while (tempInput > 0)
        {
            BigInteger curElement = tempInput % 10;
            if (position % 2 == 1)
            {
                secretSum += curElement * position * position;
            }
            else
            {
                secretSum += curElement * curElement * position;
            }
            tempInput /= 10;
            position++;
        }

        BigInteger seqLength = secretSum % 10;

        if (seqLength == 0)
        {
            Console.WriteLine(secretSum);
            Console.WriteLine("{0} has no secret alpha-sequence", input);
            return;
        }

        BigInteger charToStart = secretSum;

        while (charToStart > 26)
        {
            charToStart -= 26;
        }

        string alphaSeq = "";
        char curChar = (char)(charToStart + 'A' - 1);

        for (int i = 0; i < seqLength; i++)
        {
            curChar = (char)(curChar + 1);
            if (curChar > 'Z')
            {
                curChar = 'A';
            }
            alphaSeq += curChar;
          
        }

        Console.WriteLine(secretSum);
        Console.WriteLine(alphaSeq);
    }
}

