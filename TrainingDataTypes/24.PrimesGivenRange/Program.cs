using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.PrimesGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            var result = GetPrimesInRange(start, end);
            Console.WriteLine(string.Join(", ",result));
            bool isEmpty = result.Count = 0;
            if(isEmpty)
            {
                Console.WriteLine("empty list");
            }
        }
        static List<int> GetPrimesInRange(int startRange,int endRange)
        {
            List<int> list = Enumerable.Range(startRange, endRange - startRange + 1).ToList() ;
            List<int> primes = new List<int>();
            primes.Add(2);
            
            for (int i = 3; i < endRange; i++)
            {
                bool isPrime = true;
                for (int j = 0; j < primes.Count; j++)
                {
                    if(i%primes[j]==0)
                    {
                        isPrime = false;
                        break;
                    }
                    if (isPrime)
                    {
                        primes.Add(i);
                    }
                    
                }
               
            }
            List<int> result = new List<int>();
            foreach(var item in primes)
            {
                if(primes[item] > startRange && primes[item] < endRange )
                {
                    result.Add(primes[item]);
                }
            }



            return primes;
        }
    }
}
