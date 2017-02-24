using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(a => int.Parse(a)).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                Swap(arr, i, arr.Length - 1 - i);
            }
            Console.WriteLine(string.Join(" ", arr.Reverse()));
        }
        private static void Swap(int[] arr, int firstIndex, int lastIndex)
        {
            var tmp = arr[firstIndex];
            arr[firstIndex] = arr[lastIndex];
            arr[lastIndex] = tmp;

        }
    }
}
