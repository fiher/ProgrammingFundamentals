using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strawberry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dash = 0;
            int dot = n;
            for (int i = (n/2)+1; i < n; i++)
            {
                Console.WriteLine(new string('-', dash) + "\\" + new string('-', dot) + "|" + new string('-', dot) + "/" + new string('-', dash));
                dot -= 2;
                dash += 2;
            }
            int dott = n;
            int dotti = 1;
            for (int i = n/2; i < n; i++)
            {
                Console.WriteLine(new string('-', dott) + "#" + new string('.', dotti) + "#" + new string('-', dott));
                dott -= 2;
                dotti += 4;
            }
            Console.WriteLine("#" + new string('.', (n * 2) + 1) + "#");
            int dom = 1;
            int bum = (n * 2) - 1;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('-', dom) + "#" + new string('.', bum) + "#" + new string('-', dom));
                dom++;
                bum -= 2;
            }
        }
    }
}
