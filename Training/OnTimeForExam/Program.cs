using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int studHour = int.Parse(Console.ReadLine());
            int studMin = int.Parse(Console.ReadLine());

            
            var examTime = examHour * 60 + examMin;
            var studTime = studHour * 60 + studMin;
            var result = examTime - studTime;

            if (result < 0)
            {
                result = Math.Abs(result);
                Console.WriteLine("Late");
                if (result < 60)
                {
                    Console.WriteLine("{0} minutes after the start", result);
                }
                else
                {
                    Console.WriteLine("{0}:{1:00} hours after the start", result / 60, result % 60);
                }
            }
            else if (result >= 0 && result <= 30)
            {

                Console.WriteLine("On Time");
                if (result != 0)
                {
                    Console.WriteLine("{0} minutes before the start", result);
                }
            }
            else
            {
                Console.WriteLine("Early");
                if (result < 60)
                {
                    Console.WriteLine("{0} minutes before the start", result);
                }
                else
                {      
                    Console.WriteLine("{0}:{1:00} hours before the start", result / 60, result % 60);
                 }
            }
            
            

        }
    }
}
