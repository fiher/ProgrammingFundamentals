using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid_Of_Numbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;

            for (int rows = 1; rows <= n; rows++)
            {
                for (int cows = 1; cows <= rows; cows++)
                { 
                if (cows > 1)
                {
                    Console.Write(" ");
                }
                    if (num > n)
                    {
                        break;
                    }
                        Console.Write(num);
                        num++;
                    
               }
                Console.WriteLine();
            }
            
        }
    }
}
