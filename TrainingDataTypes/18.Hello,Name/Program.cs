using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Hello_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            try
            {
                Console.WriteLine("Hello, {0}!", name);
            }
            catch
            {
               
            }
        }
    }
}
