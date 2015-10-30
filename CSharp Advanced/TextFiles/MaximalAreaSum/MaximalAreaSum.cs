using System;
using System.IO;

/*
Write a program that reads a text file containing a square matrix of numbers.
Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
The first line in the input file contains the size of matrix N.
Each of the next N lines contain N numbers separated by space.
The output should be a single number in a separate text file.
*/

class MaximalAreaSum
{
    static void Main()
    {  
        string path = "../../Matrix.txt";
        Result(MaxSum(ReadMatrix(path)));
        Console.WriteLine("Max sum found!");
    }

    static int[,] ReadMatrix(string path)
    {
        StreamReader reader = new StreamReader(path);

        using (reader)
        {
            int n = int.Parse(reader.ReadLine());
            int[,] matrix = new int[n, n];
            string curRow;

            for (int row = 0; row < n; row++)           
            {
                curRow = reader.ReadLine();
                string[] rowElements = curRow.Split(' ');
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = int.Parse(rowElements[col]);
                }
            }
            return matrix;
        }
    }

    static int MaxSum(int[,] matrix)
    {
        int maxSum = int.MinValue;

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)     
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }
        }
        return maxSum;
    }

    static void Result(int maxSum)
    {
        using (StreamWriter result = new StreamWriter("../../Result.txt"))
        {
            result.WriteLine(maxSum);
        }
    }
}

