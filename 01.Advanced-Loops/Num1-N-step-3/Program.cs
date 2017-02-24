using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Num1_N_step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n =");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The numbers are =");
            for( int i = 1;i <= n;i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
