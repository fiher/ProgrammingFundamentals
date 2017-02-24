using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TriggeredCell
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dimentions = Console.ReadLine().Split();
            int rows = int.Parse(dimentions[0]);
            int cols = int.Parse(dimentions[1]);
            int[][] matrix = new int[rows][];
            for (int currentRow = 0; currentRow < rows; currentRow++)
            {
                matrix[currentRow] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            string[] targetedCellDimentions = Console.ReadLine().Split();
            int targetRow = int.Parse(targetedCellDimentions[0]);
            int targetCol = int.Parse(targetedCellDimentions[1]);

            int targetCellValue = matrix[targetRow][targetCol];
            int sum = 0;
            for (int currentRow = targetRow - 1; currentRow <= targetRow + 1; currentRow++)
            {
                for (int currentCol = targetCol - 1; currentCol < targetCol + 1; currentCol++)
                {
                    if (currentRow == targetRow && currentCol == targetCol)
                    {
                        continue;
                    }
                    sum += matrix[currentRow][currentCol];
                }
            }

            for (int currentRow = targetRow - 1; currentRow <= targetRow + 1; currentRow++)
            {
                for (int currentCol = targetCol - 1; currentCol < targetCol + 1; currentCol++)
                {
                    if (currentRow == targetRow && currentCol == targetCol)
                    {
                        continue;
                    }
                    matrix[currentRow][currentCol] *= matrix[targetRow][targetCol];
                }
            }
            matrix[targetRow][targetCol] = matrix[targetRow][targetCol] * sum;
            for (long i = 0; i < matrix.GetLength(0); i++)
            {
                for (long j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
