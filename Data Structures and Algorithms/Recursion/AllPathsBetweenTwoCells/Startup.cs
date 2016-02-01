namespace AllPathsBetweenTwoCells
{
    using System;
    using System.Collections.Generic;

    /*
    07. We are given a matrix of passable and non-passable cells.
    Write a recursive program for finding all paths between two cells in the matrix.
    09. Write a recursive program to find the largest connected area of adjacent empty cells in a matrix.
    */
    public class Startup
    {
        private static readonly char[,] labyrinth =
        {
            {' ', ' ', ' ', 'x', ' ', ' ', ' '},
            {'x', 'x', ' ', 'x', ' ', 'x', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', 'x', 'x', 'x', 'x', 'x', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', 'e'},
        };

        private static readonly List<string> path = new List<string>();
        private static readonly List<int[]> visitedCells = new List<int[]>();

        private static int[] startingPoint;

        static void Main()
        {
            int startingRow = 0;
            int startingCol = 0;
            startingPoint = new[] { startingRow, startingCol };

            Console.WriteLine("Problem 07: ");
            Console.WriteLine();

            FindExit(labyrinth, startingRow, startingCol, string.Empty);

            Console.WriteLine();
            Console.WriteLine("Problem 09: ");
            Console.WriteLine();
            for (int i = 0; i < labyrinth.GetLength(0); i++)
            {
                for (int j = 0; j < labyrinth.GetLength(1); j++)
                {
                    if (labyrinth[i, j] == 'e')
                    {
                        Console.Write('E');
                        continue;
                    }

                    if (i == startingPoint[0] && j == startingPoint[1])
                    {
                        Console.Write('S');
                        continue;
                    }

                    var visited = false;
                    foreach (var cell in visitedCells)
                    {
                        if (cell[0] == i && cell[1] == j)
                        {
                            Console.Write('V');
                            visited = true;
                            break;
                        }
                    }

                    if (!visited)
                    {
                        Console.Write('-');
                    }
                }
                Console.WriteLine();
            }
        }

        private static void FindExit(char[,] lab, int row, int col, string direction)
        {
            if ((col < 0) || (row < 0) || (col >= lab.GetLength(1))
                || (row >= lab.GetLength(0)))
            {
                return;
            }

            if (lab[row, col] == 'e')
            {
                Console.WriteLine(string.Join(" => ", path));
                Console.WriteLine("Exit Found!");
            }

            if (lab[row, col] != ' ')
            {
                return;
            }

            lab[row, col] = 'v';
            if (direction != string.Empty)
            {
                visitedCells.Add(new[] { row, col });
                path.Add(direction);
            }

            FindExit(lab, row, col - 1, "L");
            FindExit(lab, row - 1, col, "U");
            FindExit(lab, row, col + 1, "R");
            FindExit(lab, row + 1, col, "D");


            lab[row, col] = ' ';
            if (path.Count > 0)
            {
                path.RemoveAt(path.Count - 1);
            }
        }
    }
}
