using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            double price = 0;
            if (km < 20)
            {
                if (time == "day")
                {
                    price = 0.70 + km * 0.79;

                }
                else
                {
                    price = 0.70 + km * 0.90;

                }
            }
            else if (km >= 20 && km < 100)
            {
                price = km * 0.09;
            }
            else if(km >= 100)
            {
                price = km * 0.06;
            }
            Console.WriteLine(price);



        }
    }
}
