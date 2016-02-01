namespace PathBetweenTwoCells
{
    using System;

    /*
    08. Modify the above program to check whether a path exists between two cells without finding all possible paths.
    Test it over an empty 100 x 100 matrix.
    */
    public static class Startup
    {
        private static readonly int[][] Directions =
            {
                new[] { 1, 0 },
                new[] { -1, 0 },
                new[] { 0, 1 },
                new[] { 0, -1 }
            };

        public static void Main()
        {
            var visited = new bool[100, 100];
            var labyrinth = new int[100, 100];

            CheckIfPathExists(labyrinth, visited, 0, 0);
            Console.WriteLine(visited[50, 50]);
        }

        public static void CheckIfPathExists(int[,] labyrinth, bool[,] visited, int y, int x)
        {
            if (!IsInRange(y, x, labyrinth.GetLength(0), labyrinth.GetLength(1)))
            {
                return;
            }

            if (visited[y, x])
            {
                return;
            }

            visited[y, x] = true;

            foreach (var direction in Directions)
            {
                CheckIfPathExists(labyrinth, visited, y + direction[0], x + direction[1]);
            }
        }

        private static bool IsInRange(int y, int x, int rows, int cols)
        {
            var rowIsInRange = y >= 0 && y < rows;
            var colIsInRange = x >= 0 && x < cols;

            return rowIsInRange && colIsInRange;
        }
    }
}