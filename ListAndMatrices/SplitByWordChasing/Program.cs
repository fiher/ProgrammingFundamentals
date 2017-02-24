using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitByWordChasing
{
    class Program
    {
        static void Main(string[] args)
        {

            var separators = new char[]
  { ',', ';', ':', '.', '!', ' ' };
            var words = Console.ReadLine().Split(separators,
              StringSplitOptions.RemoveEmptyEntries).ToList();
            var lowerCaseWords = new List<string>();
            var mixedCaseWords = new List<string>();
            var upperCaseWords = new List<string>();
            foreach (var word in words)
            { // TODO: process each word }
                Console.WriteLine("Lower-case: {0}",
                  string.Join(", ", lowerCaseWords));
                // TODO: print the other lists


            }
        }
    }
}
