using System;
using System.Text;

class FallDown
{
    static void Main()
    {
        int[,] matrix = new int[8, 8];
        int counter = 0;

        for (int row = 0; row < 8; row++)
        {
            int input = int.Parse(Console.ReadLine());
            string inputToString = Convert.ToString(input, 2).PadLeft(8, '0');

            for (int col = 0; col < 8; col++)
            {
                matrix[row, col] = int.Parse(inputToString[col].ToString());
            }
        }

        for (int col = 0; col < 8; col++)
        {
            for (int row = 0; row < 8; row++)
            {
                if (matrix[row, col] == 1)
                {
                    counter++;
                    matrix[row, col] = 0;
                }
            }

            for (int i = 0; i < counter; i++)
            {
                matrix[7 - i, col] = 1;
            }
            counter = 0;
        }

        for (int row = 0; row < 8; row++)
        {
            StringBuilder sb = new StringBuilder();

            for (int col = 0; col < 8; col++)
            {
                sb.Append(matrix[row, col]);
            }

            int num = Convert.ToInt32(sb.ToString(), 2);
            Console.WriteLine(num);
        }
    }
}

