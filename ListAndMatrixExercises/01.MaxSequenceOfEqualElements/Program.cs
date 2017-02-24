using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            List<int> final = new List<int>();
            int count = 1;
            int maxCount = 1;
            for (int i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    count++;
                    result.Add(nums[i + 1]);
                }
                else
                {
                    count = 1;
                    result.Clear();
                    result.Add(nums[i+1]);

                }
                if (count > maxCount)
                {
                    final.Clear();
                    maxCount = count;
                    final.AddRange(result);
                }
            }
                if(maxCount == 1)
                {
                    Console.WriteLine(nums[0]);
                    return;
                }
            
            Console.WriteLine(string.Join(" ", final));
            
        }
    }
}
