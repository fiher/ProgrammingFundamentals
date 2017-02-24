using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;
            for (int i = 0; i < n; i++)
            {
                int element = int.Parse(Console.ReadLine());
                if(i%2 ==0)
                {
                    oddSum += element;
                }
                else
                {
                    evenSum += element;
                }
            }
            if ( oddSum==evenSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("sum = {0}", oddSum);
            }
             else
            {
                Console.WriteLine("No");
                Console.WriteLine("diff = {0}", Math.Abs(oddSum - evenSum));
            }
        }
    }
}
