using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNames
{
    class Program
    {

        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int maxValue = int.MinValue;
            string maxName = "";
                
            for (int i = 0; i < input; i++)
            {
                
                string name = Console.ReadLine();
                int number = int.Parse(Console.ReadLine());
                for (int k = 0; k < name.Length; k++)
                {
                    char pidiras = name[k];
                    if (pidiras % 2 == 0)
                    {
                        //    Even.Add(c);
                        number += pidiras;
                    }
                    else
                    {
                        //     Odd.Add(c);
                        number -= pidiras;
                    }
                }
               // for (char c in name)
               // {
                   
                    
              //      int nums = (Even.Sum() + number) - Odd.Sum();
                   
              

               // }
                if (number > maxValue)
                {
                    maxValue = number;
                    maxName = name;
                }
            }
            Console.WriteLine("The winner is {0} - {1} points", maxName, maxValue);
        }
    }
}
