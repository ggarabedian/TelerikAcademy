namespace DefiningClassesPart2Main.MatrixClass
{
    using System;
    using System.Text;

    public class Matrix<T> where T : IComparable
    {
        private T[,] matrix;
        private int rowsCount;
        private int colsCount;

        public Matrix(int rows, int cols)
        {
            this.RowsCount = rows;
            this.ColsCount = cols;
            this.matrix = new T[rows, cols];
        }

        public T this[int row, int col]
        {
            get
            {
                if ((row < 0 || row >= this.RowsCount) || (col < 0 || col >= this.ColsCount))
                {
                    throw new IndexOutOfRangeException("Index is outside the bounds of the matrix");
                }
                return this.matrix[row, col];
            }
            set
            {
                if ((row < 0 || row >= this.RowsCount) || (col < 0 || col >= this.ColsCount))
                {
                    throw new IndexOutOfRangeException("Index is outside the bounds of the matrix");
                }

                this.matrix[row, col] = value;
            }

        }

        public int RowsCount
        {
            get
            {
                return this.rowsCount;
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("The matrix must have at least one row");
                }

                this.rowsCount = value;
            }
        }

        public int ColsCount
        {
            get
            {
                return this.colsCount;
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("The matrix must have at least one column");
                }

                this.colsCount = value;
            }
        }

        public static bool operator true(Matrix<T> matrix)
        {
            return MatrixBool(matrix);
        }

        public static bool operator false(Matrix<T> matrix)
        {
            return MatrixBool(matrix);
        }

        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.ColsCount != secondMatrix.ColsCount ||
                firstMatrix.RowsCount != secondMatrix.RowsCount)
            {
                throw new Exception("Matrices have different dimensions");
            }

            Matrix<T> summedMatrix = new Matrix<T>(firstMatrix.RowsCount, firstMatrix.ColsCount);

            for (int row = 0; row < firstMatrix.RowsCount; row++)
            {
                for (int col = 0; col < firstMatrix.ColsCount; col++)
                {
                    summedMatrix[row, col] = (dynamic)firstMatrix[row, col] + secondMatrix[row, col];
                }
            }

            return summedMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.ColsCount != secondMatrix.ColsCount ||
                firstMatrix.RowsCount != secondMatrix.RowsCount)
            {
                throw new Exception("Matrices have different dimensions");
            }

            Matrix<T> subtractedMatrix = new Matrix<T>(firstMatrix.RowsCount, firstMatrix.ColsCount);

            for (int row = 0; row < firstMatrix.RowsCount; row++)
            {
                for (int col = 0; col < firstMatrix.ColsCount; col++)
                {
                    subtractedMatrix[row, col] = (dynamic)firstMatrix[row, col] - secondMatrix[row, col];
                }
            }

            return subtractedMatrix;
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.ColsCount != secondMatrix.RowsCount)
            {
                throw new Exception("The matrices cannot be multiplied.");
            }

            Matrix<T> multipliedMatrix = new Matrix<T>(firstMatrix.RowsCount, secondMatrix.ColsCount);
            int result;

            for (int row = 0; row < multipliedMatrix.RowsCount; row++)
            {
                for (int col = 0; col < multipliedMatrix.ColsCount; col++)
                {
                    result = 0;
                    for (int index = 0; index < multipliedMatrix.ColsCount; index++)
                    {
                        result += (dynamic)firstMatrix[row, index] * secondMatrix[index, col];
                    }
                    multipliedMatrix[row, col] = (dynamic)result;
                }
            }

            return multipliedMatrix;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int row = 0; row < this.RowsCount; row++)
            {
                for (int col = 0; col < this.ColsCount; col++)
                {
                    sb.Append(this.matrix[row, col] + " ");
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }

        private static bool MatrixBool(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.RowsCount; row++)
            {
                for (int col = 0; col < matrix.ColsCount; col++)
                {
                    if (matrix[row, col] != (dynamic)0)
                        return true;
                }
            }
            return false;
        }
    }
}
