using System;

/*
Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum 
of its elements.
*/

class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter amount of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter amount of columns: ");
        int cols = int.Parse(Console.ReadLine());

        if (rows < 3 || cols < 3)
        {
            Console.WriteLine("3x3 square impossible to find with current input!");
            return;
        }

        int[,] matrix = new int[rows, cols];
        int currentSum = 0;
        int bestSum = 0;
        int startRow = 0;
        int startCol = 0;

        Console.WriteLine("Enter elements of the matrix: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("Enter element at index [{0},{1}]: ", i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 1; i < rows - 1; i++)
        {
            for (int j = 1; j < cols - 1; j++)
            {
                currentSum = matrix[i, j] + matrix[i, j - 1] + matrix[i, j + 1] +
                             matrix[i + 1, j] + matrix[i + 1, j - 1] + matrix[i + 1, j + 1] +
                             matrix[i - 1, j] + matrix[i - 1, j - 1] + matrix[i - 1, j + 1];

                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                    startRow = i;
                    startCol = j;
                }
            }
        }
        Console.WriteLine(new string('-', 35));
        Console.WriteLine("The whole matrix: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine(new string('-', 35));
        Console.WriteLine("The 3x3 square with maximal sum is: ");
        for (int i = startRow - 1; i <= startRow + 1; i++)
        {
            for (int j = startCol - 1; j <= startCol + 1; j++)
            {
                Console.Write(matrix[i,j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("with sum = {0}", bestSum);
    }
}

