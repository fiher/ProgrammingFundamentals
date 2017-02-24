using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] array = Console.ReadLine().ToLower().Split(' ').Select(long.Parse).ToArray();
            
            string[] input = Console.ReadLine().ToLower().Split();
            while (input[0] != "end")
            {
              switch(input[0] )
                {
                    case "swap":
                        Swap(array, long.Parse(input[1]), long.Parse(input[2]));
                        break;
                    case "decrease":
                        Decrease(array);
                        break;
                    case "multiply":
                        MultiplyInt(array, long.Parse(input[1]), long.Parse(input[2]));
                        break;
                }
                input = Console.ReadLine().ToLower().Split();
            }
            Console.WriteLine(string.Join(", ", array));
        }
        static long[] MultiplyInt(long[] array,long pos1, long pos2)
        {
            array[pos1] = array[pos1] * array[pos2];
            return array;
        }
        static long[] Decrease(long[]array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] -= 1;
            }
            return array;
        }
        static long[] Swap(long[]array, long pos1, long pos2)
        {
            long temp = array[pos1];
            array[pos1] = array[pos2];
            array[pos2] = temp;

            return array;
        }
    }
}
