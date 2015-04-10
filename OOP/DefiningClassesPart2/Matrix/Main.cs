namespace DefiningClassesPart2Main.MatrixClass
{
    using System;

    public class MatrixMain
    {
        static void Main()
        {
            Matrix<int> matrixA = new Matrix<int>(4, 4);
            Matrix<int> matrixB = new Matrix<int>(4, 4);
            Random rand = new Random();

            for (int i = 0; i < matrixA.RowsCount; i++)
            {
                for (int j = 0; j < matrixA.ColsCount; j++)
                {
                    matrixA[i, j] = rand.Next(10, 40) + 30;
                    matrixB[i, j] = rand.Next(10, 30);
                }
            }

            Console.WriteLine(matrixA.ToString());
            Console.WriteLine(matrixB.ToString());

            Console.WriteLine((matrixA + matrixB).ToString());

            Console.WriteLine((matrixA - matrixB).ToString());

            Console.WriteLine((matrixA * matrixB).ToString());

        }
    }
}
