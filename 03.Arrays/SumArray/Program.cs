using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // var n = int.Parse(Console.ReadLine());
            // var k = int.Parse(Console.ReadLine());
            // var seq = new long[n];
            // seq[0] = 1;
            // for (int current = 1; current < n; current++)
            // {
            //     var start = Math.Max(0, current - k);
            //     var end = current - 1;
            //     long sum = 0;
            //     for (int i = 0; i < k; i++)
            //     {
            //         sum = start + end;
            //     }
            //         
            // }
            // Console.WriteLine(string.Join(" ", seq));
            //

            int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] m = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var arr = Math.Max(n.Length, m.Length);
            var sumArr = new int[arr];
            for (int i = 0; i < arr; i++)
                sumArr[i] =
                  n[i % n.Length] +
                  m[i % m.Length];
            Console.WriteLine(string.Join(" ", sumArr));

        }
    }
}
