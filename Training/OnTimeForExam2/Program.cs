using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForExam2
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int studHour = int.Parse(Console.ReadLine());
            int studMin = int.Parse(Console.ReadLine());

            int examTime = (examHour * 60) + examMin;  //() Са излишни в този случай ,но е добре да се пишат 
            int studTime = (studHour * 60) + studMin; // -||-
            int difference = examTime - studTime;
            
            if(difference <0)
            {
                Console.WriteLine("Late");
                    if(difference > -60)
                {
                    Console.WriteLine("{0} minutes after the start",Math.Abs(difference));
                }
                    else
                {
                    Console.WriteLine("{0}:{1:00} hours after the start", Math.Abs(difference/60),Math.Abs(difference%60));
                }
            }
            else if ( difference> 0)
            {
                if ( difference <=30)
                {
                    Console.WriteLine("On Time");
                    Console.WriteLine("{0} minutes before the start", difference);
                }
                else if(difference <60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0} minutes before the start", difference);
                }
                else
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0}:{1:00} hours before the start", difference / 60, difference % 60);
                }
            }
            else
            {
                Console.WriteLine("On Time");
            }
        }
    }
}
