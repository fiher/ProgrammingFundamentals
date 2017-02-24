using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAandMatrix_RemoveNegativeAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool empty = true;

            for (int i = num.Length-1; i >= 0; i--)
            {
                 if (num[i] >= 0)
                {
                    empty = false;
                    Console.WriteLine(num[i]);
                }
            }
            if(empty)
            {
                Console.WriteLine("empty");
            }
        }
    }
}
