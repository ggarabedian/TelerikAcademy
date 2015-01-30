using System;
using System.Numerics;

class AstrologicalDigits
{
    static void Main()
    {
        string some = Console.ReadLine();
        BigInteger sum = 0;

        some = some.Replace('.', '0');
        some = some.Replace('-', '0');

        BigInteger number = BigInteger.Parse(some);

        sum = CalculateNumberSum(number);
        Console.WriteLine(sum);
    }

    static BigInteger CalculateNumberSum(BigInteger number)
    {
        BigInteger result = 0;

        while(number > 0)
        {
            BigInteger temp = (BigInteger)number % 10;
            result += temp;
            number /= 10;
        }

        if (result > 9)
        {
            return CalculateNumberSum(result);
        }
        else 
        {
            return result; 
        }
    }
}

