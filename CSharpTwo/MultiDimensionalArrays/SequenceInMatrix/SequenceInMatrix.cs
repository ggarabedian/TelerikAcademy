using System;

/*
We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several 
neighbour elements located on the same line, column or diagonal.
Write a program that finds the longest sequence of equal strings in the matrix. 
*/

class SequenceInMatrix
{

    static int bestSeqLenght = 1;
    static string bestSeqString = string.Empty;

    static void Main()
    {
        Console.Write("Enter amount of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter amount of columns: ");
        int cols = int.Parse(Console.ReadLine());

        string[,] matrix = new string[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("Matrix[{0},{1}]: ", i, j);
                matrix[i, j] = Console.ReadLine();
            }
        }

        Console.WriteLine(new string('-', 30));
        PrintMatrix(matrix);
        Console.WriteLine(new string('-', 30));
        LineSequence(matrix);
        ColumnSequence(matrix);
        DiagonalSequence(matrix);
        Console.WriteLine(new string('-', 30));
        PrintResult(bestSeqLenght, bestSeqString);
    }

    static void LineSequence(string[,] someMatrix)
    {
        int currentSequence = 1;

        for (int i = 0; i < someMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < someMatrix.GetLength(1) - 1; j++)
            {
                if (someMatrix[i, j] == someMatrix[i, j + 1])
                {
                    currentSequence++;
                }
                else
                {
                    currentSequence = 1;
                }
                if (currentSequence > bestSeqLenght)
                {
                    bestSeqLenght = currentSequence;
                    bestSeqString = someMatrix[i, j];
                }
            }
        }
    }

    static void ColumnSequence(string[,] someMatrix)
    {
        int currentSequence = 1;

        for (int i = 0; i < someMatrix.GetLength(1); i++)
        {
            for (int j = 0; j < someMatrix.GetLength(0) - 1; j++)
            {
                if (someMatrix[j, i] == someMatrix[j + 1, i])
                {
                    currentSequence++;
                }
                else
                {
                    currentSequence = 1;
                }
                if (currentSequence > bestSeqLenght)
                {
                    bestSeqLenght = currentSequence;
                    bestSeqString = someMatrix[j,i];
                }
            }
        }
    }

    static void DiagonalSequence(string[,] someMatrix)
    {
        int currentSequence = 1;

        for (int i = 0; i < someMatrix.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < someMatrix.GetLength(1) - 1; j++)
            {
                if (someMatrix[i, j] == someMatrix[i + 1, j + 1])
                {
                    currentSequence++;
                    int iCounter = i + 2;
                    int jCounter = j + 2;
                    while (iCounter < someMatrix.GetLength(0) && jCounter < someMatrix.GetLength(1))
                    {
                        if (someMatrix[i, j] == someMatrix[iCounter, jCounter])
                        {
                            currentSequence++;
                            iCounter++;
                            jCounter++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    currentSequence = 1;
                }
                if (currentSequence > bestSeqLenght)
                {
                    bestSeqLenght = currentSequence;
                    bestSeqString = someMatrix[i, j];
                }
            }
        }
    }

    static void PrintMatrix(string[,] someMatrix)
    {
        for (int i = 0; i < someMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < someMatrix.GetLength(1); j++)
            {
                Console.Write(someMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void PrintResult(int bestSeqLenght, string bestSeqString)
    {
        for (int i = 0; i < bestSeqLenght; i++)
        {
            Console.Write(bestSeqString + " ");
        }
        Console.WriteLine();
    }
}

