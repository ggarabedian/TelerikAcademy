namespace RefactorAndImproveTheCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Minesweeper
    {     
        public static void Main()
        {
            const int WIN_CONDITION = 35;
            string command = string.Empty;
            char[,] playField = CreatePlayField();
            char[,] minePositions = PlaceMines();
            int pointsCounter = 0;
            bool playerIsDead = false;
            List<PointsClass> hallOfFame = new List<PointsClass>(6);
            int fieldRow = 0;
            int fieldColumn = 0;
            bool startingNewGame = true;
            bool gameWon = false;

            do
            {
                if (startingNewGame)
                {
                    Console.WriteLine(@"Let's play ""Minesweeper"". Try your luck and find all the fields without mines on them. " +
                    "Command 'top' shoes the leaderboard, command 'restart' starts a new game, command 'exit' leaves the game.");

                    DrawBoard(playField);

                    startingNewGame = false;
                }

                Console.Write("Enter row and column (separated by space): ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out fieldRow) &&
                    int.TryParse(command[2].ToString(), out fieldColumn) &&
                        fieldRow <= playField.GetLength(0) && fieldColumn <= playField.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        HallOfFame(hallOfFame);
                        break;
                    case "restart":
                        playField = CreatePlayField();
                        minePositions = PlaceMines();
                        DrawBoard(playField);
                        playerIsDead = false;
                        startingNewGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye, Bye, Bye!");
                        break;
                    case "turn":
                        if (minePositions[fieldRow, fieldColumn] != '*')
                        {
                            if (minePositions[fieldRow, fieldColumn] == '-')
                            {
                                EvaluateSelectedBox(playField, minePositions, fieldRow, fieldColumn);
                                pointsCounter++;
                            }

                            if (WIN_CONDITION == pointsCounter)
                            {
                                gameWon = true;
                            }
                            else
                            {
                                DrawBoard(playField);
                            }
                        }
                        else
                        {
                            playerIsDead = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nInvalid command. Try again.\n");
                        break;
                }

                if (playerIsDead)
                {
                    DrawBoard(minePositions);
                    Console.Write("\nBoooom! You died bravely with {0} points. " + "Enter a name to be show in the Hall of Fame: ", pointsCounter);

                    string playerName = Console.ReadLine();
                    PointsClass newHighScorer = new PointsClass(playerName, pointsCounter);
                    if (hallOfFame.Count < 5)
                    {
                        hallOfFame.Add(newHighScorer);
                    }
                    else
                    {
                        for (int i = 0; i < hallOfFame.Count; i++)
                        {
                            if (hallOfFame[i].Points < newHighScorer.Points)
                            {
                                hallOfFame.Insert(i, newHighScorer);
                                hallOfFame.RemoveAt(hallOfFame.Count - 1);
                                break;
                            }
                        }
                    }

                    hallOfFame.Sort((PointsClass firstPlayer, PointsClass secondPlayer) => secondPlayer.Name.CompareTo(firstPlayer.Name));
                    hallOfFame.Sort((PointsClass firstPlayer, PointsClass secondPlayer) => secondPlayer.Points.CompareTo(firstPlayer.Points));
                    HallOfFame(hallOfFame);

                    playField = CreatePlayField();
                    minePositions = PlaceMines();
                    pointsCounter = 0;
                    playerIsDead = false;
                    startingNewGame = true;
                }

                if (gameWon)
                {
                    Console.WriteLine("\nCongratulations! You opened all 35 fields without activating a mine");
                    DrawBoard(minePositions);
                    Console.WriteLine("Enter a name to be shown in the Hall Of Fame: ");
                    string playerName = Console.ReadLine();
                    PointsClass newHighScorer = new PointsClass(playerName, pointsCounter);
                    hallOfFame.Add(newHighScorer);
                    HallOfFame(hallOfFame);
                    playField = CreatePlayField();
                    minePositions = PlaceMines();
                    pointsCounter = 0;
                    gameWon = false;
                    startingNewGame = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria from Ivaylo 'Bomberman' Kenov!");
            Console.WriteLine("All rights reserved®.");
            Console.Read();
        }

        private static void HallOfFame(List<PointsClass> points)
        {
            Console.WriteLine("\nPoints:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} boxes", i + 1, points[i].Name, points[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The Hall of Fame is empty!\n");
            }
        }

        private static void EvaluateSelectedBox(char[,] playField, char[,] minePositions, int fieldRow, int fieldColumn)
        {
            char surroundingMinesCount = CalculateSurroundingMinesCount(minePositions, fieldRow, fieldColumn);
            minePositions[fieldRow, fieldColumn] = surroundingMinesCount;
            playField[fieldRow, fieldColumn] = surroundingMinesCount;
        }

        private static void DrawBoard(char[,] playField)
        {
            int fieldRows = playField.GetLength(0);
            int fieldColumns = playField.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < fieldRows; i++)
            {
                Console.Write("{0} | ", i);

                for (int j = 0; j < fieldColumns; j++)
                {
                    Console.Write(string.Format("{0} ", playField[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreatePlayField()
        {
            int fieldRows = 5;
            int fieldColumns = 10;
            char[,] playField = new char[fieldRows, fieldColumns];
            for (int i = 0; i < fieldRows; i++)
            {
                for (int j = 0; j < fieldColumns; j++)
                {
                    playField[i, j] = '?';
                }
            }

            return playField;
        }

        private static char[,] PlaceMines()
        {
            int fieldRows = 5;
            int fieldColumns = 10;
            char[,] playField = new char[fieldRows, fieldColumns];

            for (int i = 0; i < fieldRows; i++)
            {
                for (int j = 0; j < fieldColumns; j++)
                {
                    playField[i, j] = '-';
                }
            }

            List<int> minePositions = new List<int>();
            while (minePositions.Count < 15)
            {
                Random random = new Random();
                int randomPosition = random.Next(50);
                if (!minePositions.Contains(randomPosition))
                {
                    minePositions.Add(randomPosition);
                }
            }

            foreach (int minePos in minePositions)
            {
                int column = minePos / fieldColumns;
                int row = minePos % fieldColumns;

                if (row == 0 && minePos != 0)
                {
                    column--;
                    row = fieldColumns;
                }
                else
                {
                    row++;
                }

                playField[column, row - 1] = '*';
            }

            return playField;
        }

        private static char CalculateSurroundingMinesCount(char[,] playField, int currentRow, int currentColumn)
        {
            int minesCount = 0;
            int fieldRows = playField.GetLength(0);
            int fieldColumns = playField.GetLength(1);

            if (currentRow - 1 >= 0)
            {
                if (playField[currentRow - 1, currentColumn] == '*')
                {
                    minesCount++;
                }
            }

            if (currentRow + 1 < fieldRows)
            {
                if (playField[currentRow + 1, currentColumn] == '*')
                {
                    minesCount++;
                }
            }

            if (currentColumn - 1 >= 0)
            {
                if (playField[currentRow, currentColumn - 1] == '*')
                {
                    minesCount++;
                }
            }

            if (currentColumn + 1 < fieldColumns)
            {
                if (playField[currentRow, currentColumn + 1] == '*')
                {
                    minesCount++;
                }
            }

            if ((currentRow - 1 >= 0) && (currentColumn - 1 >= 0))
            {
                if (playField[currentRow - 1, currentColumn - 1] == '*')
                {
                    minesCount++;
                }
            }

            if ((currentRow - 1 >= 0) && (currentColumn + 1 < fieldColumns))
            {
                if (playField[currentRow - 1, currentColumn + 1] == '*')
                {
                    minesCount++;
                }
            }

            if ((currentRow + 1 < fieldRows) && (currentColumn - 1 >= 0))
            {
                if (playField[currentRow + 1, currentColumn - 1] == '*')
                {
                    minesCount++;
                }
            }

            if ((currentRow + 1 < fieldRows) && (currentColumn + 1 < fieldColumns))
            {
                if (playField[currentRow + 1, currentColumn + 1] == '*')
                {
                    minesCount++;
                }
            }

            return char.Parse(minesCount.ToString());
        }
    }
}