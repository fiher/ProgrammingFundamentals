using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PopulationAggregation1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimeters = new char[]{ '@', '#', '$', '&', '0','1','2','3','4','5','6','7','8','9'};
            SortedDictionary<string, long> countriesByTowns = new SortedDictionary<string, long>();
            SortedDictionary<string, long> townsByPopulation = new SortedDictionary<string, long>();
            while(true)
            {
                string command = Console.ReadLine();

                if(command == "stop")
                {
                    break;
                }
                string[] commandArgs = command.Split('\\');

                for (int i = 0; i < 2; i++)
                {
                    commandArgs[i] = string.Join("", commandArgs[i].Split(delimeters, StringSplitOptions.RemoveEmptyEntries));
                }
                if (char.IsUpper(commandArgs[0][0]))
                {
                    string countryName = commandArgs[0];
                    string townName = commandArgs[1];
                    long population = long.Parse(commandArgs[2]);
                    if(countriesByTowns.ContainsKey(countryName))
                    {
                        countriesByTowns[countryName]++;
                        
                    }
                    else
                    {
                        countriesByTowns.Add(countryName, 1);
                    }
                    if(townsByPopulation.ContainsKey(townName))
                    {
                        townsByPopulation[townName] = population;
                    }
                    else
                    {
                        townsByPopulation.Add(townName, population);
                    }
                        
                }
                else
                {
                    string townName = commandArgs[0];
                    string countryName = commandArgs[1];
                    int population = int.Parse(commandArgs[2]);
                }
            }
            foreach(var country in countriesByTowns)
            {
                Console.WriteLine("{0} -> {1}", country.Key, country.Value);
            }
            foreach (var town in townsByPopulation.OrderByDescending(kvp = > kvp.Value)) ;
            {
                Console.WriteLine("{0} -> {1}")
            }
        }
    }
}
