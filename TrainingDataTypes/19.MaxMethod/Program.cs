using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.MaxMethod
{
    class Program
    {
       static long n = long.Parse(Console.ReadLine());
       static long m = long.Parse(Console.ReadLine());
       static long k = long.Parse(Console.ReadLine());
       static long biggestnum = n;
        static void Main(string[] args)
        {
            Console.WriteLine(GetMax());
        }
        private static long GetMax()
        {
            
            List<long> list = new List<long>();
            list.Add(n);
            list.Add(m);
            list.Add(k);
            for (int i = 0; i < 3; i++)
            {
                if (list[i] > biggestnum)
                {
                    biggestnum = list[i];
                }
            }
            return biggestnum;
        }
    }
}
