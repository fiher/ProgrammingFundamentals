﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            for (int i = 0; i < n; i++) 
            {
               var  currentNumber = int.Parse(Console.ReadLine());

                if(currentNumber > max)
                {
                    max = currentNumber;
                }
                Console.WriteLine(max);

            }
        }
    }
}
