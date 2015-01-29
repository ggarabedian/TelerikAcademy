using System;

class TribonacciTriangle
{
    static void Main()
    {
        long firstNumber = long.Parse(Console.ReadLine());
        long secondNumber = long.Parse(Console.ReadLine());
        long thirdNumber = long.Parse(Console.ReadLine());
        long length = long.Parse(Console.ReadLine());

        long nextNumber = firstNumber + secondNumber + thirdNumber;
        
        Console.WriteLine(firstNumber);
        Console.WriteLine(secondNumber + " " + thirdNumber);

        for (int row = 1; row <= length - 2; row++)
        {
            for (int col = 0; col < row + 2; col++)
            {

                nextNumber = firstNumber + secondNumber + thirdNumber;
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
                thirdNumber = nextNumber;
                Console.Write(nextNumber + " ");
            }
            Console.WriteLine();
        }
    }
}

