using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MatrixOfPolidromes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int row = list[0];
            int col = list[1];
            string[,] matrix = new string[row, col];
           
            
            for (int i = 0; i < row; i++)
            {
                for (int k = 0; k < col; k++)
                {


                    matrix[i, k] = "" + (char)('a' + i) + (char)('a' + i + k) + (char)('a' + i);


                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int k = 0; k < col; k++)
                {
                    Console.Write(matrix[i, k] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
