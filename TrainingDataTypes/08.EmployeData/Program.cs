using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.EmployeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            ulong id = ulong.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(" First name: {0}", firstName);
            Console.WriteLine(" Last name: {0}", lastName);
            Console.WriteLine(" Age: {0}", age);
            Console.WriteLine(" Gender: {0}", gender);
            Console.WriteLine(" Personal ID: {0} ", id);
            Console.WriteLine(" Unique Employee number: {0}", number);


        }
    }
}
