using System;

/*
Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix holding the numbers 
from 1 to n*n in the form of square spiral like in the examples below.
*/

class SpiralMatrix
{
    static void Main()
    {
        Console.Write("Enter spiral size: ");
        int input = int.Parse(Console.ReadLine());

        int[,] matrix = new int[input, input];

        string direction = "right";
        int row = 0;
        int col = 0;

        for (int i = 1; i <= input * input; i++)
        {
            if (direction == "right" && (col >= input || matrix[row, col] != 0))
            {
                direction = "down";
                col--;
                row++;
            }
            else if (direction == "down" && (row >= input || matrix[row, col] != 0))
            {
                direction = "left";
                col--;
                row--;
            }
            else if (direction == "left" && (col < 0 || matrix[row, col] != 0))
            {
                direction = "up";
                col++;
                row--;
            }
            else if (direction == "up" && (row < 0 || matrix[row, col] != 0))
            {
                direction = "right";
                col++;
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

        for (int i = 0; i < input; i++)
        {
            for (int j = 0; j < input; j++)
            {
                Console.Write(matrix[i, j] + "  ");
            }
            Console.WriteLine();
        }
    }
}

