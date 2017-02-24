using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglePossition
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rectangle = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] rectangle1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if(rectangle[0] > rectangle1[0] && rectangle[1]> rectangle1[1]&& rectangle[2]> rectangle1[2]&& rectangle[3]>rectangle1[3])
            {
                Console.Write("Inside");
                return;
            }
            Console.Write("Not Inside");
        }
    }
  
    }

