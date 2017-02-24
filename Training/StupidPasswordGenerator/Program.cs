using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            
            for ( int s1 = 1; s1 <n;s1++)
            {
                for(int s2 = 1; s2 <n; s2++)
                {
                    for (int s3 = 1; s3 <= l; s3++)
                    {

                        for (int s4 = 1; s4 <= l; s4++)
                        {

                            for (int s5 = 1; s5 <= n; s5++)
                            {
                                if(s5>s1 && s5>s2)
                                {//използваме принципа на ключалки на катинар
                                    Console.Write("" + s1 + s2 + (char)(s3 +'a'-1)+ (char)(s4+'a'-1) + s5 + " ");//с char работим с таблицата за букви
                                }// със празни кавички консолата не събира числовите стойности на s1+s2....s5 а ги долепя един до друг .
                            }
                        }
                    }
                }
            }
        }
    }
}
