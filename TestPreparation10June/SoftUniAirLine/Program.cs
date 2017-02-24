using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SoftUniAirLine
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<double> overAllProfit = new List<double>();
            for (int i = 0; i < n; i++)
            {


                int adultPassengersCount = int.Parse(Console.ReadLine());
                double adultTicketPrize = double.Parse(Console.ReadLine());
                int youthPassengerCount = int.Parse(Console.ReadLine());
                double youthTicketPrize = double.Parse(Console.ReadLine());
                double prizePerHour = double.Parse(Console.ReadLine());
                double fuelConsumption = double.Parse(Console.ReadLine());
                int flightDuration = int.Parse(Console.ReadLine());

                double income = (adultPassengersCount * adultTicketPrize) + (youthPassengerCount * youthTicketPrize);
                double expenses = flightDuration * fuelConsumption * prizePerHour;
                double profit = income - expenses;
                overAllProfit.Add(profit);
                if (profit >= 0)
                {
                    Console.WriteLine("You are ahead with {0:f3}$.", profit);
                }
                else
                {
                    Console.WriteLine(" We've got to sell more tickets! We've lost {0:f3}$.", profit);
                }

            }
            
            Console.WriteLine("Overall profit -> {0:f3}$.",overAllProfit.Sum() );
            Console.WriteLine("Average profit -> {0:f3}$.",overAllProfit.Sum()/ n);
        }
    }
}
