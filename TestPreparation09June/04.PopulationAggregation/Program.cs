using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PopulationAggregation
{
    class Program
    {
        static void Main(string[] args)
        {
            var separators = new char[]
                     { '@', '#', '$', '&', '\\','0','1','2','3','4','5','6','7','8','9' };
            string[] input = Console.ReadLine().Split('\\');
            List<string> country = new List<string>();
            
            List<string> city = new List<string>();
            List<string> words = new List<string>();

            while (input[0] != "stop")
            {
                string[] clearInput = new string[input.Length];
                string population = "";
                for (int i = 0; i < input.Length-1; i++)
                {
                    clearInput = input[i].Split(separators, StringSplitOptions.RemoveEmptyEntries);
                }
                foreach (var word in clearInput)
                {  
                    for (int i = 0; i < 1 ; i++)
                    {
                        if (char.IsLower(word[i]))
                        {
                            city.Add(word);
                             population = input[2];
                        }
                        else
                        {
                            country.Add(word);
                        }
                    }
                }
                input = Console.ReadLine().Split('\\');
            }
            


        }

        }
    }

