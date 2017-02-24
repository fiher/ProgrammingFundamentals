using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> num = new List<int>();

            for (int i = 0; i < nums.Count; i++)
            {
                
                if (Math.Sqrt(nums[i])/2 == 0 )
                {
                    num.Add(nums[i]);
                }
              
            }
            num.Sort();
            Console.WriteLine(string.Join(" ", num));


           

            foreach (var n in nums)
            {
                if (Math.Sqrt(n) == Math.Floor(Math.Sqrt(n)))
                {
                    num.Add(n);
                }
            }
            num.Sort();
            num.Reverse();
            Console.WriteLine(string.Join(" ", num));
        }
    }
}
