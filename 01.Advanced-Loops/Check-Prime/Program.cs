using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var nqma = 2;
            var prime = true;
            while (n - 1 >= nqma)
            {
                if (n % nqma == 0)
                {
                    prime = false;
                    break;
                }
                nqma++;

            }
            if(prime)
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }
        }
    }
}
