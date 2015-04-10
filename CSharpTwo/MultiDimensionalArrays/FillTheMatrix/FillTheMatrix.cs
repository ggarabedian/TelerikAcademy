using System;

/*
Write a program that fills and prints a matrix of size (n, n) as shown below:
*/

class FillTheMatrix
{

    static int arraySize;

    static void Main()
    {
        Console.Write("Enter array size: ");
        arraySize = int.Parse(Console.ReadLine());

        int[,] matrix = new int[arraySize, arraySize];
        int[,] matrixD = new int[arraySize, arraySize];

        FillMatrixA(matrix);
        Console.WriteLine("\n {0} \n", new string('-', 25));
        FillMatrixB(matrix);
        Console.WriteLine("\n {0} \n", new string('-', 25));
        FillMatrixC(matrix);
        Console.WriteLine("\n {0} \n", new string('-', 25));
        FillMatrixD(matrixD);
    }
    
    // Fill matrix as shown in example a)
    static void FillMatrixA(int[,] matrix)
    {
        int currentElement = 1;

        for (int col = 0; col < arraySize; col++)
        {
            for (int row = 0; row < arraySize; row++)
            {
                matrix[row, col] = currentElement;
                currentElement++;
            }
        }

        PrintMatrix(matrix);
    }

    // Fill matrix as shown in example b)
    static void FillMatrixB(int[,] matrix)
    {
        int currentElement = 1;
        string direction = "down";

        for (int col = 0; col < arraySize; col++)
        {
            if (direction == "down")
            {
                for (int row = 0; row < arraySize; row++)
                {
                    matrix[row, col] = currentElement;
                    currentElement++;
                }
                direction = "up";
            }
            else
            {
                for (int row = arraySize - 1; row >= 0; row--)
                {
                    matrix[row, col] = currentElement;
                    currentElement++;
                }
                direction = "down";
            }
        }

        PrintMatrix(matrix);
    }

    // Fill matrix as shown in example c)
    static void FillMatrixC(int[,] matrix)
    {
        int currentElement = 1;
        int lastRow = arraySize - 1;
        int lastCol = 0;
        int row = arraySize - 1;
        int col = 0;

        while (true)
        {
            matrix[row,col] = currentElement;
            row++;
            col++;
            if (row > arraySize - 1 || row < 0)
            {
                row = lastRow - 1;
                col = 0;
                lastRow = row;              
            }
            if (row < 0 || col > arraySize - 1)
            {
                row = 0;
                col = lastCol + 1;
                lastCol = col;
            }
            
            if (currentElement == arraySize * arraySize)
            {
                break;
            }
            currentElement++;
        }

        PrintMatrix(matrix);
    }

    // Fill matrix as shown in example d)
    static void FillMatrixD(int[,] matrix)
    {
        string direction = "down";
        int row = 0;
        int col = 0;

        for (int i = 1; i <= arraySize * arraySize; i++)
        {
            if (direction == "right" && (col >= arraySize || matrix[row, col] != 0))
            {
                direction = "up";
                col--;
                row--;
            }
            else if (direction == "down" && (row >= arraySize || matrix[row, col] != 0))
            {
                direction = "right";
                col++;
                row--;
            }
            else if (direction == "left" && (col < 0 || matrix[row, col] != 0))
            {
                direction = "down";
                col++;
                row++;
            }
            else if (direction == "up" && (row < 0 || matrix[row, col] != 0))
            {
                direction = "left";
                col--;
                row++;
            }

            matrix[row, col] = i;

            if (direction == "right")
            {
                col++;
            }
            else if (direction == "down")
            {
                row++;
            }
            else if (direction == "left")
            {
                col--;
            }
            else if (direction == "up")
            {
                row--;
            }
        }

        PrintMatrix(matrix);
    }

    // Print the matrix on the console
    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < arraySize; row++)
        {
            for (int col = 0; col < arraySize; col++)
            {
                Console.Write(matrix[row, col] + "  ");
            }
            Console.WriteLine();
        }
    }
}

