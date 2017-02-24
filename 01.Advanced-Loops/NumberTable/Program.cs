﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    int num = rows + cols + 1;
                    if(num>n)num = 2 * n - num;
                    Console.Write(num+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
