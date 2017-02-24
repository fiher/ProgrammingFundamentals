using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDesert
{
    class Program
    {
        static void Main(string[] args)
        {
            double cash         = double.Parse(Console.ReadLine());
            int guests          = int.Parse(Console.ReadLine());
            double priceBanana  = double.Parse(Console.ReadLine())*2d;
            double priceEggs    = double.Parse(Console.ReadLine())*4d;
            double priceBerries = double.Parse(Console.ReadLine())/5d;

            double moneyNeeded = priceBanana + priceEggs + priceBerries ;
            double Total = 0.0;
            double totalguests = guests / 6;
            if(guests%6 == 0)
            {    
                Total = moneyNeeded * totalguests;
            }
           else
            {
                totalguests += 1;
                Total = moneyNeeded * totalguests;
            }
            if (Total > cash)
            {
                double difference = Total - cash;
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", difference);
            }
            else
            {

                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", Total);
            }

        }
    }
}
