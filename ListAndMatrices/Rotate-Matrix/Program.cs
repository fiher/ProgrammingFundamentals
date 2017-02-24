using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Rotate_Matrix
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int cols = int.Parse(Console.ReadLine());
//            int rows = int.Parse(Console.ReadLine());
//            
//
//            string[,] matrix = new string[cols ,rows];
//
//            // a b c d 
//            for (int i = 0; i <cols; i++)
//            {
//                string inputRow = Console.ReadLine();
//                string[] inputCols = inputRow.Split();
//                for (int k = 0; k < rows; k++)
//                {
//                    matrix[i, k] = inputCols[k];
//                }
//                
//            }
//            for (int i = 0; i < cols; i++)
//            {
//                for (int k = rows; k > 0; k--)
//                {
//                    Console.Write(matrix[k, i]+ " ");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}


namespace _09.Rotate_a_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            string[,] shit = new string[height, width];


            for (int i = 0; i < height; i++)
            {
                string[] temp = Console.ReadLine().Split(' ');

                for (int i2 = 0; i2 < temp.Length; i2++)
                {
                    shit[i, i2] = temp[i2];

                }
            }
            //0.1 A
            //0.2 B
            //0.3 C
            //0.4 D
            //Column.Row

            //2.0 I -> 0.0 I
            //1.0 E -> 1.0 E
            string[,] rotatedShit = new string[width, height];

            for (int i = 0; i < height; i++)
            {
                for (int i2 = 0; i2 < width; i2++)
                {
                    //rotatedShit[i, i2] = shit[shit.GetLength(1) - i2, shit.GetLength(0) - i];
                    int columns = shit.GetLength(1) - 1;
                    int rows = shit.GetLength(0) - 1;
                    rotatedShit[i2, i] = shit[i, i2];
                }
            }


            for (int i2 = 0; i2 < width; i2++)
            {
                for (int i = height - 1; i >= 0; i--)
                {
                    Console.Write(rotatedShit[i2, i] + " ");
                }
                Console.Write("\n");
            }



        }
    }
}