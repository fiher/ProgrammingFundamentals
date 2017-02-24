using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffIntegerSize
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());

            if(n >=0 && n<=255)
            {
                Console.WriteLine("byte");
            }
            if(n>=-128 && n<=127)
            {
                Console.WriteLine("sbyte");
            }
            if(n>=-32768 && n<=32767)
            {
                Console.WriteLine("ushort");
            }
        }
    }
}
