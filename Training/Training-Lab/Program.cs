using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine())*100;
            double h = double.Parse(Console.ReadLine())*100;

            var tablesPerRow = Math.Floor((h - 100) / 70);
            var rows = Math.Floor(( w / 120));

            var tables = (tablesPerRow * rows) - 3;

            Console.WriteLine(tables);


        }
    }
}
