using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RandomizeWordsSecondOption
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputWords = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions
                .RemoveEmptyEntries)
                .ToList();
            Random rand = new Random();
            int listLength = inputWords.Count;
            for(int i = 0;i<listLength;i++)
            {
                int randomIndex = rand.Next(0, inputWords.Count - 1);
                Console.WriteLine(inputWords[randomIndex]);
                inputWords.RemoveAt(randomIndex);
            }
        }
    }
}
