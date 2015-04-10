using System;

/*
Write a class Matrix, to hold a matrix of integers. Overload the operators for adding, subtracting and multiplying of 
matrices, indexer for accessing the matrix content and ToString().
*/

class MatrixMain
{
    static void Main()
    {
        Matrix firstMatrix = new Matrix(3, 3);
        firstMatrix[0, 0] = 1;
        firstMatrix[1, 1] = 5;
        firstMatrix[2, 1] = -10;
        firstMatrix[2, 2] = 13;
        firstMatrix[1, 0] = 7;

        Matrix secondMatrix = new Matrix(3, 3);
        secondMatrix[0, 1] = 4;
        secondMatrix[1, 1] = 17;
        secondMatrix[2, 1] = 3;
        secondMatrix[0, 2] = -2;
        secondMatrix[2, 0] = 9;

        Matrix addition = firstMatrix + secondMatrix;
        Matrix subtraction = firstMatrix - secondMatrix;
        Matrix multiplication = firstMatrix * secondMatrix;

        Console.WriteLine("First Matrix: ");
        Console.Write(firstMatrix.ToString()); 
        Console.WriteLine(new string('-', 15));
        Console.WriteLine("Second Matrix: ");
        Console.Write(secondMatrix.ToString());
        Console.WriteLine(new string('-', 15));
        Console.WriteLine("Addition:");
        Console.Write(addition.ToString());
        Console.WriteLine(new string('-', 15));
        Console.WriteLine("Subtraction:");
        Console.Write(subtraction.ToString());
        Console.WriteLine(new string('-', 15));
        Console.WriteLine("Multiplication:");
        Console.Write(multiplication.ToString());
        Console.WriteLine(new string('-', 15));

    }
}

