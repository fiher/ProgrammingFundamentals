using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputParts = input.Split('|');
            Console.WriteLine(String.Join("\n",inputParts.Reverse()));
            inputParts = inputParts.Reverse().ToArray();
            for (int i = 0; i < inputParts.Length; i++)
            {
                List<int> partNums = inputParts[i]
                    .Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)//StringSplitOptions.RemoveEmptyEntries е много важно !!!!!!!!!!!
                    .Select(int.Parse)
                    .ToList();
                Console.WriteLine(String.Join(" ", partNums)+ " ");
            }
        }
    }
}
