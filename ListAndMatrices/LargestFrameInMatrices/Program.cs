using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestFrameInMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] matrix = new int[dimentions[0], dimentions[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = num[j];
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    FindFrame(matrix, matrix[i,j],i,j);
                }
            }

        }
        void FindFrame(int[,]matrix ,int currElement,int i,int j)
        {
            int frameSizeI = 0;
            int frameSizeJ = 0;
            while(true)
            {
                if(currElement == matrix[i,j+1]&& j+1<matrix.GetLength(1))
                {
                    frameSizeI++;
                }
                else if(currElement == matrix[i+j, j] && j + 1 < matrix.GetLength(1))
            }
        }
    }
}
