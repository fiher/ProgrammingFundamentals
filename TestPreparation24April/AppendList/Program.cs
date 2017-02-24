using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendList
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split('|');

            string[] reverse = new string[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                reverse[i] = str[str.Length - 1 - i].Trim();
            }
            Console.WriteLine(string.Join(" ", reverse));
           
        }
    }
}
